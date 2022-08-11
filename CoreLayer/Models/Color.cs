using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class Color : BaseEntity
    {
        public ICollection<Boat> Boats { get; set; }
        public ICollection<Bus> Buses { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
