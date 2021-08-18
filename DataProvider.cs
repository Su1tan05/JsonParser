using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DataProvider
    {
        private static readonly string _nameOfConfigFile= "Config.json";

        private static Config config;

        public static Config GetConfig()
        {
            string objectJsonFile = File.ReadAllText(_nameOfConfigFile);
            config = JsonConvert.DeserializeObject<Config>(objectJsonFile);
            return config;
        }
    }
}
