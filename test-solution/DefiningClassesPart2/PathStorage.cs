using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

static class PathStorage
{
    private const string file_dir = @"D:\Desktop\Temp\";
    private const string file_name = "test.txt";

	private static StringBuilder sb = new StringBuilder();

	public static void WriteToFile(string FilePath, Path Path)
    {
		foreach (Point3D point in Path)
        {
            sb.AppendLine(point.GetCoords());
        }

		using (StreamWriter file = new StreamWriter(FilePath, true))
		{
			file.Write(sb);
		}

		sb.Clear();
	}

	//public static void LoadFromFile(string FilePath)
	//{
	//	Path path = new Path();

	//	using (System.IO.StreamReader sr = new System.IO.StreamReader(FilePath))
	//	{
	//		while (!String.IsNullOrEmpty(sr.ReadLine()))
	//		{
	//			Console.WriteLine(sr.ReadLine());
	//			sr.ReadLine().Split(',').ToList().FindIndex(i => i.Count() == 1);
	//			//Console.WriteLine();
	//		}
	//	}
	//}
}