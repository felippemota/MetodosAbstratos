﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Shape()
        {

        }

        public Color Color { get; set;}

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();


    }






}
