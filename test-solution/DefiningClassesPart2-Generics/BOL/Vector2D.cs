using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Vector2D
{
    public int X { get; set; }

    public int Y { get; set; }

    public Vector2D(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public static Vector2D operator+ (Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X + b.X, a.Y + b.Y);
    }
}