namespace Tecno;

public class Ingredient
{
    public int IngredientId { get; set; }
    public string IngredientName { get;}
    public ICollection<ProductIngredient> ProductIngredients{ get; set; }
}
