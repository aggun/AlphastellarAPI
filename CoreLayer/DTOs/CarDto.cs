﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DTOs
{
    public class CarDto
    {
        public string Model { get; set; }
        public int ColorId { get; set; }
        public bool wheels { get; set; }
        public bool Headlights { get; set; }
    }
}
