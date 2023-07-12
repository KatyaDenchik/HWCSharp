//using Draft;
//using System.IO;



//internal class FileInf
//{
//	private string path;

//	public FileInf(string path)
//	{
//		this.path = path;
//	}

//	public List<FileInf> GetListExtension(List<FileInf> extensionsList)
//	{
//		var result = Directory.GetFiles(path, "*", SearchOption.AllDirectories)
//							  .GroupBy(file => new { Exception = Path.GetExtension(file), Count = file.Count() })
//							  .ToList();

//		extensionsList = result;
//		return extensionsList;
//	}
//}

//internal class Program
//{
//	private static void Main(string[] args)
//	{
//		FileInf n = new FileInf(@"D:\sims");

//		var myFiles = new List<FileInf>();

//		n.GetListExtension(myFiles);
//		Console.WriteLine();
//	}
//}

//using System;
//using System.Collections.Generic;
//using System.IO;

//internal class FileInf
//{
//	public string path;

//	public FileInf(string path)
//	{
//		this.path = path;
//	}

//	public List<FileInf> GetListExtension()
//	{
//		List<FileInf> extensionsList = new List<FileInf>();

//		string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

//		var result = files.GroupBy(file => new { Extension = Path.GetExtension(file), Count = files.Count() })
//						  .ToList();

//		foreach (var group in result)
//		{
//			FileInf fileInf = new FileInf(group.Key.Extension);
//			extensionsList.Add(fileInf);
//		}

//		return extensionsList;
//	}
//}

//internal class Program
//{
//	private static void Main(string[] args)
//	{
//		FileInf n = new FileInf(@"D:\sims");

//		List<FileInf> myFiles = n.GetListExtension();

//		foreach (FileInf file in myFiles)
//		{
//			Console.WriteLine(file.path);
//		}
//	}
//}


using System;
using System.Collections.Generic;
using System.IO;

internal class FileInf
{
	private string path;

	public FileInf(string path)
	{
		this.path = path;
	}

	public List<string> GetExtensionCounts()
	{
		List<string> extensionCounts = new List<string>();

		string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

		var result = files.GroupBy(file => Path.GetExtension(file))
						  .Select(file => $"{file.Key}: {file.Count()}");

		extensionCounts.AddRange(result);

		return extensionCounts;
	}
}

internal class Program
{
	private static void Main(string[] args)
	{
		FileInf n = new FileInf(@"D:\sims");

		List<string> extensionCounts = n.GetExtensionCounts();

		foreach (string extensionCount in extensionCounts)
		{
			Console.WriteLine(extensionCount);
		}
	}
}


