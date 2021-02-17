using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Plant
    {
        public int ID { get; set; }
        public string PlantName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
