using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public bool Headlights { get; set; }
    }
}
