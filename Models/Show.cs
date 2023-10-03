using ApplicationTemplate.Services;
using System.Collections.Generic;
using System.IO;
using System;

namespace ApplicationTemplate.Models
{
    public class Show : Media
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public string Writers { get; set; }

        public override void Display()
        {
            string path = "shows.csv";

            StreamReader sr = new StreamReader(path);
            sr.ReadLine();



            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var values = line.Split(",");

                int id = Convert.ToInt32(values[0]);
                string title = values[1];
                int season = Convert.ToInt32(values[2]);
                int episode = Convert.ToInt32(values[3]);
                string writers = values[4];

                Console.WriteLine($"Id: {id}\nTitle: {title}\nFormat: {season}\nLength: {episode}\nRegion: {writers}\n");

            }
            sr.Close();
        }
    }
}

