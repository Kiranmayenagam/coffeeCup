using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCup
{
    /// <summary>
    /// This class defines about the Orders and checks 
    /// </summary>
    public class Orders
    {
        #region Variables
        /// <summary>
        /// This Variable give every new check a new number 
        /// </summary>
        private static int lastCheckno = 1;
        #endregion
        #region Properties
        /// <summary>
        /// Enter the complete data of the order.
        /// </summary>
        [Key]
        public int CheckNo { get; private set; }
        public DateTime OrderDate { get; set; }
        public string  CustomerName { get; set; }
        public NameofProduct ProductName { get; set; }
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
        /// <summary>
        /// constructors are created 
        /// when checkno is given by +1 increment to lastCheckno.
        /// </summary>
        public Orders()
        {
            CheckNo = ++lastCheckno;
        }
        public Orders(DateTime orderdate) : this()
        {
            OrderDate = orderdate;
        }
        public Orders( string customerName) : this()
        {
            CustomerName = customerName;
        }
        public Orders (string customerName,NameofProduct productName) : this()
        {
            ProductName = productName;
        }
        public Orders(string customerName,NameofProduct productName,decimal price) : this()
        {
            Price = price;
        }
        public Orders(string customerName,NameofProduct productName,decimal price,string quantity) : this()
        {
            Quantity = quantity;
        }
        public Orders(string customerName,NameofProduct productName,decimal price,string quantity,decimal amount) : this(quantity)
        {
            Amount = amount;
        }
        public Orders(string customerName,NameofProduct productName,decimal price,string quantity,decimal amount,decimal totalAmount) : this()
        {
            TotalAmount = totalAmount;
        }
        public Orders(string customerName,NameofProduct productName,decimal price,string quantity,decimal amount,decimal totalAmount,decimal tax) : this()
        {
            Tax = tax;
        }
        public Orders(string customerName,NameofProduct productName,decimal price,string quantity,decimal amount,decimal totalAmount,decimal tax,decimal grandTotal) : this()
        {
            GrandTotal = grandTotal;
        }
        public Orders(string customerName,NameofProduct productName,decimal price,string quantity,decimal amount,decimal totalAmount,decimal tax,decimal grandTotal,decimal discount) : this()
        {
            Discount = discount;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerName">enter customer name</param>
        /// <param name="productName">productname which the customer want to bye </param>
        /// <param name="price">price given to the product</param>
        /// <param name="quantity">quantityof the product</param>
        /// <param name="amount">amount of products </param>
        /// <param name="totalAmount">total amount of all purchases</param>
        /// <param name="tax">tax </param>
        /// <param name="grandTotal">grand total </param>
        /// <param name="discount">discounts with any</param>
        /// <param name="finalAmount">final amount of product</param>
        public Orders(string customerName,NameofProduct productName,decimal price,string quantity,decimal amount,decimal totalAmount,decimal tax,decimal grandTotal,decimal discount,decimal finalAmount) : this()
        {
            FinalAmount = finalAmount;
        }
        #endregion
        #region Methods
        /// <summary>
        /// when we want to add new product to the order
        /// </summary>
        /// <param name="productName"> productname</param>
        /// <param name="price">price of the product</param>
        /// <returns>enter the total price </returns>
        public string AddtoOrder(NameofProduct productName,decimal price)
        {
            ProductName = productName;
            Price = price;
            return "Total Price";
        }
        /// <summary>
        /// Delete which is already in the order
        /// </summary>
        /// <param name="productName">product name</param>
        /// <param name="price">price of the product</param>
        /// <returns>return total price of that order</returns>
        public string DetelefromOrder(NameofProduct productName,decimal price)
        {
            ProductName = productName;
            Price = price;
            return "Total Price";
        }
        #endregion
        #region 
        class Payments
        {
            
        }
#endregion
    }
}
