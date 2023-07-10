using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PiController;
using PiController.Properties;

namespace RPICommander
{
    public class SaveObject
    {
        public ConcurrentBag<Device> Devices { get; set; }
        public ConcurrentBag<Command> Commands { get; set; }
        public SaveObject()
        {
            Devices = new ConcurrentBag<Device>();
            Commands = new ConcurrentBag<Command>();
        }
    }
    public class Serializer
    {

        public Serializer() { }

        string filepath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\RPI_Controller\\RpiController.json";

        public void JsonSerialize_(object data, bool toAppend = false)
        {
            EvaluatePath(filepath);

            if (File.Exists(filepath))
                File.Delete(filepath);

            JsonSerializer jsonSerializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            try
            {
                using (StreamWriter sw = new StreamWriter(filepath, toAppend))
                using (JsonTextWriter jsonWriter = new JsonTextWriter(sw))
                    jsonSerializer.Serialize(jsonWriter, data);
            }
            catch (Exception)
            {

                return;
            }
        }

        public object JsonDeserialize_(Type type, string filepath)
        {
            if (!File.Exists(filepath))
                return null;

            JObject obj = null;

            JsonSerializer jsonSerializer = new JsonSerializer()
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            };
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                using (JsonReader jsonReader = new JsonTextReader(sr))
                    obj = jsonSerializer.Deserialize(jsonReader) as JObject;

                if (obj == null)
                    return null;

                SaveObject sobj = (SaveObject)obj.ToObject(type);
                return sobj;
            }
            catch (Exception) { return null; }
        }
        private void EvaluatePath(string path)
        {

            try
            {
                string folder = Path.GetDirectoryName(path);
                if (!Directory.Exists(folder))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(folder);
                }
            }
            catch (IOException ioex)
            {

            }
        }

        public string GetDBPath()
        {
            return filepath;
        }
    }
}
