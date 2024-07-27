namespace asp.net_task1.Entity
{
    public class HotMeal : Food
    {
        public int ServingSize { get; set; } //1 2 3plate
        public bool IsVegetarian { get; set; }
        public string SpiceLevel { get; set; }//hot medium  mild
    }
}
