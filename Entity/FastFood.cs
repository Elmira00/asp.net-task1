using Microsoft.AspNetCore.Authentication;

namespace asp.net_task1.Entity
{
    public class FastFood:Food
    {
        public int PreparationTime { get; set; }//minutes
        public string SpecialAdding { get; set; }//no onion ,extra sauce
    }
}
