using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class Boat : BaseEntity
    {
        public int ColorId { get; set; }
        public Color Color { get; set; }
       
    }
}
