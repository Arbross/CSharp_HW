using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwnSerializationLibrary;

namespace Test_project_for_own_library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>();
            str.Add("qweqwe");
            str.Add("qweqwe");
            str.Add("qweqwe");

            Serialization.XmlSerialization<List<string>>(str);
        }
    }
}
