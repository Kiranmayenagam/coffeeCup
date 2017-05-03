using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    class StockDetails
    {
        #region Properties
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string  BrandName { get; set; }
        public string  AvaiableQuty { get; set; }
        #endregion
        #region Constructions
        public StockDetails()
        {
            ProductId = ProductId;
        }
        public StockDetails(string productName) :this()
        {
            ProductName = productName;
        }
        public StockDetails(int productId,string productName,string brandName) : this(productName)
        {
            BrandName = brandName;
        }
        public StockDetails(int productId,string productName,string brandName,string avaiablequty) : this(brandName)
        {
            AvaiableQuty = avaiablequty;
        }
        #endregion
        #region Method 
        public void Close()
        {
            
        }
        #endregion 
    }
}
