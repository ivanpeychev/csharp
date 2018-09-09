using System.Collections.Generic;

class Path : List<Point3D>
{
    public void List()
    {
        foreach (var point in this)
        {
            point.ToString();
        }
    }
}