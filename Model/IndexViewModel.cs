using asp.net_task1.Entity;

namespace asp.net_task1.Models
{
    public class IndexViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<FastFood> FastFoods { get; set; }
        public List<HotMeal> HotMeals { get; set; }
    }
}