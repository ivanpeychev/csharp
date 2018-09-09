using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Point3D
{
    /* STATIC */
    //Fields
    private static readonly Point3D _O = new Point3D(0, 0, 0);

    //Properties
    public static Point3D O
    {
        get
        {
            return _O;
        }
    }

    /* NON STATIC */
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    //Constructors
    public Point3D(int _x, int _y, int _z)
    {
        this.x = _x;
        this.y = _y;
        this.z = _z;
    }

    //Methods
    public void Print()
    {
        Console.WriteLine($"{this.x},{this.y},{this.z}");
    }

    public string GetCoords()
    {
        return string.Format($"{this.x},{this.y},{this.z}");
    }
}
