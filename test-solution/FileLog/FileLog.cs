namespace FileActions
{
	public static class FileLog
	{
		public static void Write(string str, string file_path)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();

			using (System.IO.StreamWriter file = new System.IO.StreamWriter(file_path, true))
			{
				sb.AppendLine(string.Empty);
				sb.AppendLine(System.DateTime.Now.ToString());
				sb.AppendLine("-------------------------------");
				sb.AppendLine(str);
				sb.AppendLine("-------------------------------");
				file.Write(sb);
			}
		}
	}
}