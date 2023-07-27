using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace LinQDemo
{
    public class FactInternetSales
    {
        [Key]
        public string SalesOrderNumber { get; set; }
        public int ProductKey { get; set; }
        public DateTime OrderDate { get; set; }
        public Int16 OrderQuantity { get; set; }

    }
}
