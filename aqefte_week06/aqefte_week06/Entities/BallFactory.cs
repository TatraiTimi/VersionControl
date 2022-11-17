﻿using aqefte_week06.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqefte_week06.Entities
{
    public class BallFactory : IToyFactory
    {
        public Color BallColor { get; set; }    
        public Abstractions.Toy CreateNew()
        {
            return new Ball(BallColor);
        }
    }
}
