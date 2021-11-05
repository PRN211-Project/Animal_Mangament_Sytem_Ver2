using System;
using System.Collections.Generic;

#nullable disable

namespace Animal_Management_System.Models
{
    public partial class Food
    {
        public Food()
        {
            FoodAnimals = new HashSet<FoodAnimal>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ExpiredDate { get; set; }

        public virtual ICollection<FoodAnimal> FoodAnimals { get; set; }
    }
}
