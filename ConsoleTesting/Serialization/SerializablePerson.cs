using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Serialization
{
  [Serializable]
  class SerializablePerson
  {
    public string Name { get; set; }
    public int Age { get; set; }

    internal void Save(string fileName)
    {
      var formatter = new BinaryFormatter();
      using (Stream stream = File.OpenWrite(fileName))
      {
        formatter.Serialize(stream, this);
      }
    }

    internal static SerializablePerson Load(string fileName)
    {
      SerializablePerson temp;
      var formatter = new BinaryFormatter();
      using (Stream stream = File.OpenRead(fileName))
      {
        temp = (SerializablePerson)formatter.Deserialize(stream);
      }
      return temp;
    }
  }
}
