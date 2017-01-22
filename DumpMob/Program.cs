using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleFileFormats.Objects;
using TempleFileFormats.Common;

namespace DumpObj
{
	class Program
	{
		private static int ObjRead = 0;

		static void Main(string[] args)
		{
			//args = new string[] { "G_8C6BA44F_6CA6_4A37_BDC4_388F1734DE15.mob" };
            args = new string[] { "G_C13C68B0_08E4_42FD_97EE_AFBCC6CD308B.mob" };
            //args = new string[] { "G_A3AA4341_235F_4EF9_8B34_9205FC970D99.mob" };
			//args = new string[] { "001020 - Wall.pro" };
            //args = new string[] { "016086 - PC.pro" };

			if (args.Length != 1)
			{
				Console.WriteLine("Usage: DumpObj <Obj-filename|directory>");
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

			Console.WriteLine("Done. Reading {0} object.", ObjRead);
			Console.ReadKey();
		}

		private static void DumpAllIn(string filename)
		{
			foreach (var file in Directory.EnumerateFiles(filename, "*.mob", SearchOption.AllDirectories))
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
			ObjRead++;

			GameObject obj;
			using (var reader = new BinaryReader(new FileStream(filename, FileMode.Open)))
			{
				obj = new GameObjectReader(reader).Read();
			}

			Console.WriteLine("{0}", obj.Type);
            Console.WriteLine("  ObjectID {0}", obj.Id);
			Console.WriteLine("  Proto_ID {0}", obj.ProtoId);
            Console.WriteLine("\n");

			foreach (var prop in obj.Properties)
			{
				if (prop.Value is IEnumerable && !(prop.Value is string))
				{
					IEnumerable e = prop.Value as IEnumerable;
					List<string> vals = new List<string>();
					foreach (var k in e)
					{
						vals.Add(k == null ? "null" : k.ToString());
					}
					Console.WriteLine("  {0}: {1}", prop.Key, string.Join(", ", vals));
				}
				else
				{
					Console.WriteLine("  {0}: {1}", prop.Key, prop.Value);
				}
			}

			w.WriteLine(new Export<GameObject>(obj).GetText());

		}
	}
}
