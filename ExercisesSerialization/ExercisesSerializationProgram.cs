using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesSerialization
{
    class ExercisesSerializationProgram
    {
        static void Main(string[] args)
        {
            XMLSerialization ser = XMLSerialization.ReadIt();

            ser.WriteIt();

            Console.WriteLine("Name = {0}", ser.Name);
            Console.WriteLine("FacultyNumber = {0}", ser.FacultyNumber);
            Console.WriteLine();
    
            JSONSerialization jsonSer = new JSONSerialization();
            jsonSer.Name = "Gogo";
            jsonSer.FacultyNumber = 12345;
            Ser();
         
        }
        public static void Ser()
        {
            JSONSerialization jsonSer = new JSONSerialization();
            jsonSer.Name = "Gogo";
            jsonSer.FacultyNumber = 123456;
            string json = JsonConvert.SerializeObject(jsonSer);
            File.WriteAllText("json.txt", json);

        }
        public static void DeSer()
        {
            JSONSerialization jsonSer = new JSONSerialization();
            jsonSer.Name = "Gogo";
            jsonSer.FacultyNumber = 123456;
            string json = JsonConvert.SerializeObject(jsonSer);

        }
    }
}
