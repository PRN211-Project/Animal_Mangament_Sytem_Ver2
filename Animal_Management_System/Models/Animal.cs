using System;
using System.Collections.Generic;

#nullable disable

namespace Animal_Management_System.Models
{
    public partial class Animal
    {
        public Animal()
        {
            FoodAnimals = new HashSet<FoodAnimal>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Weight { get; set; }
        public int? Age { get; set; }
        public DateTime? ImportedDateTime { get; set; }
        public int? TypeId { get; set; }
        public int? AreaId { get; set; }

        public virtual Area Area { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<FoodAnimal> FoodAnimals { get; set; }
    }
}
