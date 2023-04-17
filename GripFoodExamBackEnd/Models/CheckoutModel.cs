namespace GripFoodExamBackEnd.Models
{
    public class CheckoutModel
    {
        public string Id { set; get; } = "";
        public string Name { set; get; } = "";
        public decimal Price { set; get; }
        public int Qty { get; set; }
        public decimal SubTotal { set; get; }
    }
}
