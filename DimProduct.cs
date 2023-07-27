using System.ComponentModel.DataAnnotations;

namespace LinQDemo
{
    public class DimProduct
    {
        [Key]
        public int ProductKey { get; set; }
        public string EnglishProductName { get; set; }
    }
}
