using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FileActions;

class Program
{
    static void Main()
    {
        Path path = new Path();

        Point3D p1 = new Point3D(1, 3, 5);
        path.Add(p1);

        Point3D p2 = new Point3D(2, 6, 1);
        path.Add(p2);

        path.Add(new Point3D(5, 7, 9));

		path.Add(new Point3D(11, 7, 14));

		//Console.WriteLine(Distance.BetweenTwoPoints(p1, p2));

		//path.List();

		//PathStorage.WriteToFile(FilePath: @"D:/Desktop/test.txt", Path: path);

		//PathStorage.LoadFromFile(FilePath: @"D:/Desktop/test.txt");


		FileLog.Write("nice", file_path: @"D:\Desktop\debuglog.txt");
	}
}