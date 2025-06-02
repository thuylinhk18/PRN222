﻿using Interface_Segregation_Principle_Demo.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_Demo.Utilities
{
    internal class Utilities
    {
        internal static List<Video> ReadData(string fileID)
        {
            var filename = "Data/BookStore" + fileID + ".json";
            var cadJSON = ReadFile(filename);
            return JsonConvert.DeserializeObject<List<Video>>(cadJSON);
        }

        // ------------------------------------------------------

        internal static string ReadFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
