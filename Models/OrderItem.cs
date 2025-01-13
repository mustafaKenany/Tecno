using Humanizer;

namespace Tecno;

public class OrderItem
{
    public int OrderItemId { get; set;}
    public int OrderId { get; set;}
    public Order? Orders { get; set;}
    public int Quanityt { get; set;}
    public decimal Price { get; set;}
    public Product? Products { get; set;}
    public int ProductId { get; set;}
    

}
