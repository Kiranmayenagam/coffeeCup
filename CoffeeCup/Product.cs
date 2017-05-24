using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{/// <summary>
/// enum is that which creates a data type to a product 
/// Name of products is that there are products 
/// </summary>
    public enum NameofProduct
    {
        Darkroast,
        Semiroast,
        Instantcoffee
    }
    public enum NameOfBrand
    {
        Starbucks,
        BarCoffee
    }
    public enum Weights
    {
        TenOz,
        halfpound,
        onepound,
     }
    public class Product
    {
        #region Variables
        private static int productid = 0;
        #endregion
        #region properties
        [Key]
        public int ProductId { get;set; }
        public NameofProduct ProductName { get; set; }
        public NameOfBrand BrandName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        #endregion
        #region Construction
        public Product()
        {
            ProductId = ++productid;
        }
        public Product(NameofProduct productName) :this()
        {
            ProductName = productName;
        }
        public Product(NameofProduct productName,NameOfBrand brandName) :this(productName)
        {
            BrandName = brandName;
        }
        public Product(decimal productPrice) : this()
        {
            ProductPrice = productPrice;
        }
        public Product(int productId,NameofProduct productName,NameOfBrand brandName,decimal productPrice,int quantity) :this()
        {
            Quantity = quantity;
        }
        #endregion
        #region Method
        public string Save(int productId,NameofProduct productName,NameOfBrand brandName,decimal productPrice,int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            BrandName = brandName;
            ProductPrice = productPrice;
            Quantity = quantity;
            return "Save product details";
        }
        public void Detele(int productId)
        {
            ProductId = productId;
        }


        #endregion
    }


}
