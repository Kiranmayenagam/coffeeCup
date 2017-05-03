using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    class AddNewProduct
    {
        #region Variables
        private static int lastItemId = 0123;
        #endregion
        #region properies 
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public  decimal Price { get; set; }
        public string Quantity{ get; set; }
        #endregion
        #region Construction
        public AddNewProduct()
        {
            ItemId = ++lastItemId;
        }
        public AddNewProduct(string itemName) : this()
        {
            ItemName = itemName;
        }
        public AddNewProduct(decimal price) :this()
        {
            Price = price;
        }
        public AddNewProduct(int itemId,string itemName,decimal price,string quantity) : this(price)
        {
            Quantity = quantity;
        }
        #endregion
        #region Method
        public string Save(int itemId,string itemName,decimal price,string quantity)
        {
            ItemId = ItemId;
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
            return "Save the item";
        }
        public void Detele(int itemid)
        {
            ItemId = ItemId;
        }


        #endregion
    }
}
