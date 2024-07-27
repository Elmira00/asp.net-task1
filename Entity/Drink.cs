namespace asp.net_task1.Entity
{
    public class Drink:Food
    {
        public bool IsAlcoholic { get; set; }
        public string Packaging { get; set; }
        public float Volume { get; set; }
    }
}
