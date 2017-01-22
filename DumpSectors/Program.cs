using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleFileFormats.Maps;
using TempleFileFormats.Objects;

namespace DumpSectors
{
    class Program
    {

        private static int sectorsRead = 0;

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: DumpSector <sec-filename|directory>");
            }

            //            var filename = args[0];
            var filename = "0.sec";

            using (var w = new StreamWriter("sector.log", false, Encoding.UTF8, 8192))
            {
                
                if (Directory.Exists(filename))
                {
                    DumpAllIn(filename, w);
                }
                else
                {
                    DumpFile(filename, w);
                }
            }

            Console.WriteLine("Done. Written {0} sectors to sector.log.", sectorsRead);
            Console.ReadKey();
            
        }
        

        
        private static void DumpAllIn(string filename, StreamWriter w)
        {
            foreach (var file in Directory.EnumerateFiles(filename, "*.sec", SearchOption.AllDirectories)) {
                DumpFile(file, w);
            }
        }

        private static void DumpFile(string filename, StreamWriter w)
        {
            WriteHeader(filename, w);

            sectorsRead++;

            var sectorIo = new SectorIo(null);
            Sector sector;

            using (var reader = new BinaryReader(new FileStream(filename, FileMode.Open)))
            {
                sector = sectorIo.ReadSector(reader);
            }

            if (sector.SectorScript != null)
            {
                w.WriteLine("Sector Script: {0}", sector.SectorScript);
            }

            if (sector.TileScripts.Count > 0)
            {
                WriteHeader("Tile Scripts", w);

                foreach (var tileScript in sector.TileScripts)
                {
                    w.WriteLine("  {0}", tileScript);
                }
            }
            
            for (int i = 0; i < sector.Lights.Count; ++i)
            {
                if (i == 0)
                {
                    WriteHeader("Lights", w);
                }

                var light = sector.Lights[i];
                w.WriteLine("Light {0}", i);
                w.WriteLine("  Pos: {0}", light.Position);
                /*                
                var particles = light.Particles;
                if (particles != null && particles.ParticleSystemHash != 0)
                {
                    w.WriteLine("  Particles: {0} (Handle: {1})", particles.ParticleSystemHash, particles.ParticleSystemHandle);
                }
                */
                w.WriteLine();

            }

            if (sector.Objects.Count > 0)
            {
                WriteHeader("Objects", w);

                foreach (var obj in sector.Objects)
                {
                    w.WriteLine("{1} {0}", obj.Id, obj.Type);
                    w.WriteLine("  Proto ID {0}", obj.ProtoId);
                    foreach (var prop in obj.Properties)
                    {
                        if (prop.Value is IEnumerable)
                        {
                            IEnumerable e = prop.Value as IEnumerable;
                            List<string> vals = new List<string>();
                            foreach (var k in e) {
                                vals.Add(k == null ? "null" : k.ToString());
                            }
                            w.WriteLine("  {0}: {1}", prop.Key, string.Join(", ", vals));
                        }
                        else
                        {
                            w.WriteLine("  {0}: {1}", prop.Key, prop.Value);
                        }
                        
                    }
                    w.WriteLine();
                }
            }

        }

        private static void WriteHeader(string name, StreamWriter w)
        {
            w.WriteLine();
            w.WriteLine("=====================================================================");
            w.WriteLine(name.ToUpper());
            w.WriteLine("=====================================================================");
            w.WriteLine();
        }
    }
}
