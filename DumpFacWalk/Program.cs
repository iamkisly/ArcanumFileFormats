using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcanumFileFormats.FacWalk;
using ArcanumFileFormats.Common;

namespace DumpFacWalk
{
	class Program
	{
		private static int facwalkRead = 0;

		static void Main(string[] args)
		{

			if (args.Length != 1)
			{
				Console.WriteLine("Usage: DumpFacWalk <facwalk-filename|directory>");
			}

			var path = args[0];

			if (Directory.Exists(path))
			{
				DumpAllIn(path);
			}
			else
			{
				using (var w = new StreamWriter(Path.GetFileName(path) + ".json", false, Encoding.UTF8, 8192))
				{
					DumpFile(path, w);
					w.Flush();
					w.Close();
				}
			}

			Console.WriteLine("Done. Written {0} facades.", facwalkRead);
			Console.ReadKey();
		}

		private static void DumpAllIn(string filename)
		{
			foreach (var file in Directory.EnumerateFiles(filename, "facwalk.*", SearchOption.AllDirectories))
			{
				using (var w1 = new StreamWriter(file + ".json", false, Encoding.UTF8, 8192))
				{
					DumpFile(file, w1);
					w1.Flush();
					w1.Close();
				}
			}

		}

		private static void DumpFile(string filename, StreamWriter w)
		{
			facwalkRead++;

			FacWalk obj;
			using (var reader = new BinaryReader(new FileStream(filename, FileMode.Open)))
			{
				obj = new FacWalkReader(reader).Read();
			}
            w.WriteLine(new Export<FacWalk>(obj).GetText());
		}
	}
}
