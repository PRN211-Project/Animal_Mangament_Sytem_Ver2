using System;
using System.Collections.Generic;

#nullable disable

namespace Animal_Management_System.Models
{
    public partial class FoodAnimal
    {
        public int Id { get; set; }
        public int? FoodId { get; set; }
        public int? AnimalId { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Food Food { get; set; }
    }
}
