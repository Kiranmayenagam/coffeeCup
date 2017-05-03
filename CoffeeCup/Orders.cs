using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    class Orders
    {
        #region Variables
        private static int lastCheckno = 1;
        #endregion
        #region Properties
        public int CheckNo { get; private set; }
        public string  CustomerName { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string  Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Tax { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalAmount { get; set; }
        #endregion
        #region Construction
        public Orders()
        {
            CheckNo = ++lastCheckno;
        }
        public Orders(string customerName) : this()
        {
            CustomerName = customerName;
        }
        public Orders(string customerName,string productName) : this(customerName)
        {
            ProductName = productName;
        }
        public Orders(string customerName,string productName,decimal price) : this(productName)
        {
            Price = price;
        }
        public Orders(string customerName,string productName,decimal price,string quantity) : this()
        {
            Quantity = quantity;
        }
        public Orders(string customerName,string productName,decimal price,string quantity,decimal amount) : this(quantity)
        {
            Amount = amount;
        }
        public Orders(string customerName,string productName,decimal price,string quantity,decimal amount,decimal totalAmount) : this()
        {
            TotalAmount = totalAmount;
        }
        public Orders(string customerName,string productName,decimal price,string quantity,decimal amount,decimal totalAmount,decimal tax) : this()
        {
            Tax = tax;
        }
        public Orders(string customerName,string productName,decimal price,string quantity,decimal amount,decimal totalAmount,decimal tax,decimal grandTotal) : this()
        {
            GrandTotal = grandTotal;
        }
        public Orders(string customerName,string productName,decimal price,string quantity,decimal amount,decimal totalAmount,decimal tax,decimal grandTotal,decimal discount) : this()
        {
            Discount = discount;
        }
        public Orders(string customerName,string productName,decimal price,string quantity,decimal amount,decimal totalAmount,decimal tax,decimal grandTotal,decimal discount,decimal finalAmount) : this()
        {
            FinalAmount = finalAmount;
        }
        #endregion
        #region Methods
        public string AddtoOrder(string productName,decimal price)
        {
            ProductName += productName;
            Price = price;
            return "Total Price";
        }
        public string DetelefromOrder(string productName,decimal price)
        {
            ProductName = productName;
            Price = price;
            return "Total Price";
        }
        #endregion

    }
}
