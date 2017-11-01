using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Eu4ModEditor.JSON
{
    public class JSonManager<T>
    {
        public Type Type;

        public JSonManager()
        {
            Type = typeof(T);
        }

        public T Load(string path)
        {
            T instance;

            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(File.ReadAllText(path)));
            //Désérialisation
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

            instance = (T)ser.ReadObject(stream);

            return instance;
        }

        public void Save(string path, object o)
        {
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream

                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, o);
            }
        }
    }
}
