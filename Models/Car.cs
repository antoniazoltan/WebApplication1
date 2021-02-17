using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Car
    {
        public int ID { get; set; }

        [Display(Name = "Car Name")]
        public string Brand { get; set; }
        public string Manufacturer { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseCarDate { get; set; }

        public int PlantID { get; set; }
        public Plant Plant { get; set; }

        public ICollection<CarCategory> CarCategories { get; set; }
    }
}
