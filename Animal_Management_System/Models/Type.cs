using System;
using System.Collections.Generic;

#nullable disable

namespace Animal_Management_System.Models
{
    public partial class Type
    {
        public Type()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
