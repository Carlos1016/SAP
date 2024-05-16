using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static LogicaB1.Modelos;
using static System.Net.WebRequestMethods;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace LogicaB1
{
    public class SAPB1
    {
        private HttpClient client;


        public SAPB1()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            client = new HttpClient(clientHandler);

        }

        public void login()
        {

            //string url2 = " https://181.114.56.16:8934/b1s/v1/Login";
            string url2 = " https://181.114.56.16:8934/b1s/v1/Login";
            client.DefaultRequestHeaders.Clear();
            string parametros = "{\r\n  \"CompanyDB\": \"SBO_PARSEMA\",\r\n    \"Password\": \"mvb2F1j0\",\r\n    \"UserName\": \"soporteit\"\r\n}";

            dynamic jsonString = JObject.Parse(parametros);

            var httpContent = new StringContent(jsonString.ToString(), Encoding.UTF8, "application/json");

            var response2 = client.PostAsync(url2, httpContent).Result;
            var res2 = response2.Content.ReadAsStringAsync().Result;

            dynamic r2 = JObject.Parse(res2);

        }

        public bool ArticulosEX(string codigo)
        {
            string identificadorConGuion = codigo.Replace("‐", "-");

            string url = $"https://181.114.56.16:8934/b1s/v1/Items?$filter=ItemCode eq '{identificadorConGuion}'";
            var response = client.GetAsync(url).Result;
            var res = response.Content.ReadAsStringAsync().Result;
            dynamic responseObject = JObject.Parse(res);

            if (responseObject.value.Count == 0)
            {
                return false;

            }

            else
            {
                return true;

            }
        }

        public Articulo Articulos(string codigo)
        {
            string identificadorConGuion = codigo.Replace("‐", "-");
            //https://181.114.56.16:8934/b1s/v1/Items?$select=ItemCode,ItemName,AvgStdPrice,ItemPrices,SWW,ItemWarehouseInfoCollection&$filter=ItemName eq 'RENTA DE MONTACARGAS ELECTRICO'

            //string url = $"https://181.114.56.16:8934/b1s/v1/Items?$select=ItemCode,ItemName,AvgStdPrice,ItemPrices,SWW,ItemWarehouseInfoCollection&$filter=ItemCode eq '{codigo}'";
            string url = $"https://181.114.56.16:8934/b1s/v1/Items('{NormalizarCadena(identificadorConGuion)}')?$select=ItemCode,ItemName,AvgStdPrice,ItemPrices,SWW,ItemWarehouseInfoCollection";

            var response = client.GetAsync(url).Result;
            var res = response.Content.ReadAsStringAsync().Result;
            dynamic responseObject = JObject.Parse(res).ToString();
            Articulo Arti = JsonConvert.DeserializeObject<Articulo>(responseObject);
            //Arti.Bodegas.OrderBy(b => b.InStock);

            return NombreBodega(Arti);
        }


        public Articulo NombreBodega(Articulo Arti)
        {
            string desbodega = "https://181.114.56.16:8934/b1s/v1/Warehouses?$select=WarehouseCode,WarehouseName";
            var response = client.GetAsync(desbodega).Result;
            var res = response.Content.ReadAsStringAsync().Result;
            dynamic responseObject = JObject.Parse(res).ToString();


            List<ItemWarehouseInfoCollection> listabodegas = JsonConvert.DeserializeObject<listanombresbodega>(responseObject).Value;


            foreach (var item in Arti.Bodegas)
            {
                foreach (var item2 in listabodegas)
                {

                    if (item.CodigoAlmacen == item2.CodigoAlmacen)
                    {

                        item.NombreAlmacen = item2.NombreAlmacen;

                    }

                }
            }
            return Arti;
        }



        static string NormalizarCadena(string cadena)
        {

            // Reemplazar guiones con el mismo carácter estándar
            cadena = cadena.Replace('-', '-');


            return cadena;
        }



        public List<Item> buscardescripcion(string des)
        {
            string desbodega = $"https://181.114.56.16:8934/b1s/v1/Items?$select=ItemCode,ItemName&$filter=contains(ItemName,'{des.ToUpper()}')";
            var response = client.GetAsync(desbodega).Result;
            var res = response.Content.ReadAsStringAsync().Result;
            dynamic responseObject = JObject.Parse(res).ToString();

            var itemsResponse = JsonConvert.DeserializeObject<listadescripcion>(responseObject);

            List<Item> itemList = new List<Item>();
            foreach (var item in itemsResponse.value)
            {
                itemList.Add(new Item { ItemCode = item.ItemCode, ItemName = item.ItemName });
            }

            return itemList;
        }




        public List<SolicitudTraslado> SolicitudTraslado(DateTime fechaInicio, DateTime fechaFin)
        {

            //DateTime fechaInicio = fecha1;
            //DateTime fechaFin = fecha2;
            List<SolicitudTraslado> lista = new List<SolicitudTraslado>();
          
            string url = $"https://181.114.56.16:8934/b1s/v1/InventoryTransferRequests?$filter=CreationDate ge '{fechaInicio:s}' and CreationDate le '{fechaFin:s}'&$select=CardName,FromWarehouse,ToWarehouse,Comments,DocNum,DocEntry";
            
            var response = client.GetAsync(url).Result;
            var res = response.Content.ReadAsStringAsync().Result;
            dynamic responseObject = JObject.Parse(res).ToString();           


            var itemsResponse = JsonConvert.DeserializeObject<listasoli>(responseObject);

            foreach (var item in itemsResponse.value)
            {
                lista.Add(new SolicitudTraslado { CardName = item.CardName, Comments = item.Comments, FromWarehouse = item.FromWarehouse, ToWarehouse = item.ToWarehouse, DocNum = item.DocNum, DocEntry=item.DocEntry });
            }




            return lista;

        }


        public List<StockTransferLines> SolicitudTraslado(string solicitudID)
        {

           
            List<StockTransferLines> lista = new List<StockTransferLines>();

            string url = $"https://181.114.56.16:8934/b1s/v1/InventoryTransferRequests({solicitudID})?$select=StockTransferLines";

            var response = client.GetAsync(url).Result;
            var res = response.Content.ReadAsStringAsync().Result;
            dynamic responseObject = JObject.Parse(res).ToString();


            var itemsResponse = JsonConvert.DeserializeObject<listasoliinfo>(responseObject);

            foreach (var item in itemsResponse.StockTransferLines)
            {
                lista.Add(new StockTransferLines { ItemCode = item.ItemCode, ItemDescription = item.ItemDescription, Quantity = item.Quantity, WarehouseCode = item.WarehouseCode, FromWarehouseCode = item.FromWarehouseCode });
            }


            return lista;

        }


        public List<Item> buscarcodigoadicional(string des)
        {
            string desbodega = $"https://181.114.56.16:8934/b1s/v1/Items?$select=ItemCode,SWW,ItemName&$filter=contains(SWW,'{des.ToUpper()}')";
            var response = client.GetAsync(desbodega).Result;
            var res = response.Content.ReadAsStringAsync().Result;
            dynamic responseObject = JObject.Parse(res).ToString();

            var itemsResponse = JsonConvert.DeserializeObject<listadescripcion>(responseObject);

            List<Item> itemList = new List<Item>();
            foreach (var item in itemsResponse.value)
            {
                itemList.Add(new Item { ItemCode = item.ItemCode, SWW = item.SWW, ItemName = item.ItemName });
            }

            return itemList;
        }




        

        public ListaMateriales Listamateriales(string des)
        {
            ListaMateriales productTree=new ListaMateriales();

            string identificadorConGuion = des.Replace("‐", "-");
            string url = $"https://181.114.56.16:8934/b1s/v1/ProductTrees('{NormalizarCadena(identificadorConGuion)}')";

            var response = client.GetAsync(url).Result;
            var res = response.Content.ReadAsStringAsync().Result;
            dynamic responseObject = JObject.Parse(res).ToString();
            productTree = JsonConvert.DeserializeObject<ListaMateriales>(responseObject);

            
             productTree = JsonConvert.DeserializeObject<ListaMateriales>(responseObject);

            if (productTree.ProductDescription!=null)
            {
                foreach (var item in productTree.ProductTreeLines)
                {
                    item.Costo = Busarcosto(item.ItemCode).AvgStdPrice;


                }



            }




            return productTree;
        }




        public Articulo Busarcosto(string des)
        {


            string identificadorConGuion = des.Replace("‐", "-");
            string url = $"https://181.114.56.16:8934/b1s/v1/Items('{NormalizarCadena(identificadorConGuion)}')";

            var response = client.GetAsync(url).Result;
            var res = response.Content.ReadAsStringAsync().Result;
            dynamic responseObject = JObject.Parse(res).ToString();

            Articulo costart = JsonConvert.DeserializeObject<Articulo>(responseObject);








            return costart;
        }

















    }
}
