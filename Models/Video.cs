using ApplicationTemplate.Services;
using System.Collections.Generic;
using System.IO;
using System;

namespace ApplicationTemplate.Models
{
    public class Video : Media
    {
        public string Format { get; set; }
        public int Length { get; set; }
        public string Regions { get; set; }



        public override void Display()
        {
            string path = "videos.csv";

            StreamReader sr = new StreamReader(path);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var values = line.Split(",");

                int id = Convert.ToInt32(values[0]);
                string title = values[1];
                string format = values[2];
                int length = Convert.ToInt32(values[3]);
                string region = values[4];

                Console.WriteLine($"Id: {id}\nTitle: {title}\nFormat: {format}\nLength: {length}\nRegion: {region}\n");
                
            }
            sr.Close();
        }
    }
}

