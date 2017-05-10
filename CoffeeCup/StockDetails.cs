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
        public NameofProduct ProductName { get; set; }
        public NameOfBrand  BrandName { get; set; }
        public string  AvaiableQuty { get; set; }
        #endregion
        #region Constructions
        public StockDetails()
        {
            ProductId = ProductId;
        }
        public StockDetails(NameofProduct productName) :this()
        {
            ProductName = productName;
        }
        public StockDetails(int productId,NameofProduct productName,NameOfBrand brandName) : this(productName)
        {
            BrandName = brandName;
        }
        public StockDetails(int productId,NameofProduct productName,NameOfBrand brandName,string avaiablequty) : this()
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
