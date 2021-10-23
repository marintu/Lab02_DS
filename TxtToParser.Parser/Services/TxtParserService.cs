using System.Collections.Generic;
using System.IO;
using TxtToParser.Model.Models;

namespace TxtToParser.Parser.Services
{
    public class TxtParserService
    {
        public IEnumerable<Person> ParseTxtFile(string fileName)
        {
            var fileInfo = new FileInfo(fileName);

            if(!fileInfo.Exists)
            {
                Enumerable.Empty<Person>();
            }
            //ucitaj file
            var rows =File.ReadAllLines(fileName);

            var persons = new List<Person>();
            //rastavi na redove
            foreach (var row in rows)
            {
                var person=ParseRow(row);
                if(person is null)
                {
                    continue;
                    
                }
                persons.Add(person);
            }
            return persons;

            
            //svaki red rastavi u kolumne
            //kreiraj tip ovisno o type-u
            
        }
        private static Person ParseRow(string row)
            {
                var columns=row.Split(';');   
                if(columns.Length < 7)
                {
                    return null;
                }

                var type = columns[0];
                var name = columns[2];
                var oib = columns[1];

                if(name ==string.Empty)
                {
                    return null;
                }

                var person = type switch
                {
                    "Student"=>new Student(avgGrade:0.0),
                    "Professor"=> new Professor(),
                    _=>null
                };
            }
    }
}

