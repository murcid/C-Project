using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final
{
    public class ClassOrder
    {
        public ClassOrder(int id, int customerID, string date, int p1, int p2, int p3, decimal subtotal, decimal tax, decimal total)
        {
            ID = id;
            CustomerID = customerID;
            Date = date;
            P1 = p1;
            P2 = p2;
            P3 = p3;
            Subtotal = subtotal;
            Tax = tax;
            Total = total;
        }

        public ClassOrder(int customerID, string date, int p1, int p2, int p3, decimal subtotal, decimal tax, decimal total)
        {
            CustomerID = customerID;
            Date = date;
            P1 = p1;
            P2 = p2;
            P3 = p3;
            Subtotal = subtotal;
            Tax = tax;
            Total = total;
        }

        public ClassOrder(int id, string date, decimal total)
        {
            ID = id;
            Date = date;
            Total = total;
        }

        public int ID { get; set; }
        public int CustomerID { get; set; }
        public String Date { get; set; }
        public int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }
        public Decimal Subtotal { get; set; }
        public Decimal Tax { get; set; }
        public Decimal Total { get; set; }

    }
}