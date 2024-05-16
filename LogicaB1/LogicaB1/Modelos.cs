using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaB1
{
    public class Modelos
    {

        public class Articulo
        {

            public string ItemCode { get; set; }
            public string ItemName { get; set; }
            public double AvgStdPrice { get; set; }
            public string SWW { get; set; }
            public double Price { get; set; }
            public IList<ItemPrices> ItemPrices { get; set; }
            [JsonProperty("ItemWarehouseInfoCollection")]
            public IList<ItemWarehouseInfoCollection> Bodegas { get; set; }

        }

        public class ItemWarehouseInfoCollection
        {
            [JsonProperty("WarehouseCode")]
            public string CodigoAlmacen { get; set; }

            [JsonProperty("WarehouseName")]
            public string NombreAlmacen { get; set; }

            public double InStock { get; set; }
        }

        public class listanombresbodega
        {
            public List<ItemWarehouseInfoCollection> Value { get; set; }
        }



        public class listadescripcion
        {
            public List<Item> value { get; set; }
        }

        public class Item
        {       
            public string ItemCode { get; set; }
            public string SWW { get; set; }
            public string ItemName { get; set; }
        }


        public class ItemPrices
        {
            public int PriceList { get; set; }
            public double Price { get; set; }
            public string Currency { get; set; }
            public double AdditionalPrice1 { get; set; }
            //public IList<undefined> AdditionalCurrency1 { get; set; }
            public double AdditionalPrice2 { get; set; }
            //public IList<undefined> AdditionalCurrency2 { get; set; }
            public double BasePriceList { get; set; }
            public double Factor { get; set; }
            //public IList<undefined> UoMPrices { get; set; }

        }

        public class Cotizaciones
        {
            public string CodigoSap { get; set; }
            public string Descripcion { get; set; }
            public double Cantidad { get; set; }
            public double Costo { get; set; }
            public double Precio { get; set; }
            public double Total { get; set; }
        }

        public class listasoli
        {
           
            public IList<SolicitudTraslado> value { get; set; }

        }


        public class SolicitudTraslado
        {
            public string CardName { get; set; }
            public string Comments { get; set; }
            public string FromWarehouse { get; set; }
            public string ToWarehouse { get; set; }
            public string DocNum { get; set; }
            public string DocEntry { get; set; }
        }









        public class StockTransferLines
        {            
           
            public string ItemCode { get; set; }
            public string ItemDescription { get; set; }
            public string Quantity { get; set; }           
            public string WarehouseCode { get; set; }
            public string FromWarehouseCode { get; set; }

        }
        public class listasoliinfo
        {
            
            public IList<StockTransferLines> StockTransferLines { get; set; }

        }


        public class ListaMateriales
        {
            public string TreeCode { get; set; }
            public string TreeType { get; set; }
            public double Quantity { get; set; }
            public string ProductDescription { get; set; }
            public List<Contenidolistamateriales> ProductTreeLines { get; set; }
        }

        public class Contenidolistamateriales
        {
            public string ItemCode { get; set; }
            public double Quantity { get; set; }
            public string Warehouse { get; set; }
            public double Price { get; set; }
            public double Costo { get; set; }
            public string Currency { get; set; }
            public string ItemName { get; set; }
            // Agregar más propiedades según sea necesario
        }










    }
}
