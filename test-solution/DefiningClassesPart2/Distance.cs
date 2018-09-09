using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Distance
{
    public static double BetweenTwoPoints(Point3D a, Point3D b)
    {
        return Math.Sqrt(Math.Pow((a.x - b.x), 2) + Math.Pow((a.y - b.y), 2) + Math.Pow((a.z - b.z), 2));
    }
}