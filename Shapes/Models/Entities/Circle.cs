﻿using System.Globalization;

namespace Shapes.Models.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Circle color = {Color}, radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}, area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
