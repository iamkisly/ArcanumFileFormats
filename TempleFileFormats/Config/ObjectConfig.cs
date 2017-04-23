using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcanumFileFormats.ObjectsNew;

namespace ArcanumFileFormats.Config
{
    public static class ObjectConfig
    {
        //Lists
        public static List<GameObject> ObjectList = new List<GameObject>();

        //Path
        public static string path_to_prototype_folder = String.Empty;

		//Random
		public static Random random = new Random();
    }
}
