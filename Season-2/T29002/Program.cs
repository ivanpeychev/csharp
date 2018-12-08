using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
	static void Main()
	{
		string basePath = @"D:\Desktop\Temp";

		var files = Directory.GetFiles(basePath);

		foreach (var file in files)
		{
			string fileName = Path.GetFileName(file);
			string extension = Path.GetExtension(fileName);

			string subDir = string.Format($@"{basePath}\{extension.TrimStart('.')}");
			if (!Directory.Exists(subDir))
			{
				Directory.CreateDirectory(subDir);
			}

			string newFile = string.Format($@"{subDir}\{fileName}");
			File.Move(file, newFile);
		}
	}
}
