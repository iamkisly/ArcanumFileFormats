using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcanumFileFormats.Maps;


namespace DumpSectors
{
    class Program
    {

        private static int sectorsRead = 0;

        static void Main(string[] args)
        { /*
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
            */

            DumpAllIn("", new StreamWriter("E:\\sector.log", false, Encoding.UTF8, 8192));
            File.WriteAllLines(@"E:\sec_decode_art.txt", TempleFileFormats.Utils.temp.list_art_id.Distinct().ToArray());
            Console.WriteLine("Done. Written {0} sectors to sector.log.", sectorsRead);
            Console.ReadKey();
            
        }
        

        
        private static void DumpAllIn(string filename, StreamWriter w)
        {
            {
                //DumpFile("e:\\Новая папка (1)\\virtualbox_share\\Arcanum Multiverse Edition\\DATS\\Arcanum\\maps\\Arcanum1-024-fixed\\68920804301.sec", w);
            }
            foreach (string file in File.ReadLines(@"E:\sec.txt", Encoding.GetEncoding("windows-1251"))) { 
                //foreach (var file in Directory.EnumerateFiles(filename, "*.sec", SearchOption.AllDirectories)) {

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
					w.WriteLine("{1} {0}", obj.Header.ObjectId, obj.Header.GameObjectType);
					w.WriteLine("  Proto ID {0}", obj.Header.ProtoId);

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
