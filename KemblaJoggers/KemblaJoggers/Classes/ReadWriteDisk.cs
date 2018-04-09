using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace KemblaJoggers
{
    public static class ReadWriteDisk
    {
        static readonly string mainPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        static readonly string dataPath = Path.Combine(mainPath, "data.json");
        //static readonly string userPath = Path.Combine(mainPath, "user.json");

        public static void WriteData()
        {
            
        }

    }
}
