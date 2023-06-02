namespace FoodieFinder.Models
{
    public class Filters
    {
        public bool NoMeat { get; set; } = false;
        public int MaxIngredients { get; set; } = 0;
        public int MaxPreparationTime { get; set; } = 0;

    }
}
