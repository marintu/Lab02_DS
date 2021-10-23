using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using TxtToParser.Parser.Services;
using TxtToParser.Model.Models;
using System.Text.Json.Serialization;

namespace TxtToParser.Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var txtFileLocation = args[0];
            
            Console.WriteLine("Choose serializer: 1 - XML, 2 - JSON ");
            var serializerType=Console.ReadLine();
            switch (serializerType)
            {
                case 1:
                    var xmlFileLocation = args[1];
                    Console.WriteLine("You choose XML serializer!");
                case 2:
                    var jsonFileLocation = args[1];
                    Console.WriteLine("You choose JSON serializer!");
                default:
                    Console.WriteLine("Please choose one of the two!");

            }
            
            //var persons = TxtToParser.ParseTxtFile(txtFileLocation);
            var persons = TxtToParser.Parser.Services.TxtParserService.ParseTxtFile(txtFileLocation);
        }
        private static void SerializePersonsToXml(IEnumerable<Person> persons, string xmlFileLocation ){
            XmlSerializer ser = new XmlSerializer(typeof(List<Person>));

            var xmlFileStream = new FileStream(xmlFileLocation, FileMode.Create);

            ser.Serialize(xmlFileStream, persons.ToList());
        }
        private static void SerializePersonsToJSON(IEnumerable<Person> persons, string jsonFileLocation ){
            JsonSerializer ser = new JsonSerializer(typeof(List<Person>));

            var jsonFileStream = new FileStream(jsonFileLocation, FileMode.Create);

            ser.Serialize(jsonFileLocation, persons.ToList());


        }
    }
}
