using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcanumFileFormats.ObjectsNew;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.Config;
using System.Reflection;
using System.ComponentModel;

namespace DumpObj
{
	class Program
	{
        private static int ObjRead = 0;

		static void Main(string[] args)
		{

			args = new string[] { "G_7FF2711B_119E_4315_9472_1A7F4E7F3E72.mob", @"/home/me/workspace/proto_1/" /*@"F:\proto_1"*/ };

            if (args.Length != 1)
			{
				Console.WriteLine("Usage: DumpObj <Obj-filename|directory>");
			}

			var path = args[0];
            var path_to_proto = args[1];

            if (Directory.Exists(path_to_proto))
            {
                foreach (var file in Directory.EnumerateFiles(path_to_proto, "*.pro", SearchOption.AllDirectories))
                {
                    GameObject obj;
                    using (var reader = new BinaryReader(new FileStream(file, FileMode.Open)))
                    {
						//if (file == path_to_proto + "\\016086 - PC.pro") 
						{
							obj = reader.GameObjectReader(); //TODO: use GameObjectReader only for tests! in prodaction use GameObjectHeaderReader
                            obj.Header.filename = file;

                            ObjectConfig.ObjectList.Add (obj);
							Console.Write (file + "  ");
							Console.Write (obj.Header.ObjectId.ToString () + "  ");



                            Console.WriteLine((reader.BaseStream.Position == reader.BaseStream.Length).ToString() + "  " + reader.BaseStream.Position.ToString() + "  " + reader.BaseStream.Length.ToString());

							if (reader.BaseStream.Position != reader.BaseStream.Length) {
                                Console.WriteLine(" !!! not full reading !!!");
                                Console.Read ();
							}
								
						}
                    }
                }
            }



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

		private static void DumpAllIn(string dirname)
		{
			foreach (var file in Directory.EnumerateFiles(dirname, "*.mob", SearchOption.AllDirectories))
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
				obj = reader.GameObjectReader();
			}

			Console.WriteLine("{0}", obj.Header.GameObjectType);
            Console.WriteLine("  ObjectID {0}", obj.Header.ObjectId.ToString());
			Console.WriteLine("  Proto_ID {0}", obj.Header.ProtoId.ToString());
            Console.WriteLine("\n");

			w.WriteLine(new Export<GameObject>(obj).GetText());


			using (var writer = new BinaryWriter (new FileStream (filename+".write.mob", FileMode.OpenOrCreate))) {
				writer.GameObjectWirter (obj);

				writer.Flush ();
				writer.Close ();
				writer.Dispose ();
			}

		}
	}
}
