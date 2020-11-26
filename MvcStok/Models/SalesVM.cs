namespace MvcStok.Models
{
    public class SalesVM
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int ProductPiece { get; set; }
        public decimal price { get; set; }
    }
}