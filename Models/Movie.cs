using ApplicationTemplate.Services;
using System.IO;
using System;
using System.Collections.Generic;

namespace ApplicationTemplate.Models
{
    public class Movie : Media
    {
        public string Genres { get; set; }

        public override void Display()
        {
            string path = "movies.csv";


            StreamReader sr = new StreamReader(path);
            sr.ReadLine();



            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var values = line.Split(",");

                int id = Convert.ToInt32(values[0]);
                string title = values[1];   
                string genres = values[2];


                Console.WriteLine($"Id: {id}\nTitle: {title}\nFormat: {genres}");

            }
            sr.Close();
        }
    }
}

