namespace MvcStok.Models
{
    public class ProductVM
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }

    }
}