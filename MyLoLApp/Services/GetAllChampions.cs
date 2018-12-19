using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace MyLoLApp.Services
{
    public class GetAllChampions
    {
        static string championsUrl = "http://lol-guide.ru/api/champions/";

        public List<Champion> GetAllChamps()
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(championsUrl);
                List<Champion> champions = JsonConvert.DeserializeObject<List<Champion>>(json);

                return champions.Select(x => new Champion
                {
                    id = x.id,
                    name = x.name,
                    title = x.title,
                    blurb = x.blurb,
                    image = x.image,
                    fkey = x.fkey

                }).ToList();
            }
        }
    }

    public class Champion
    {
        public string id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public string image { get; set; }
        public int fkey { get; set; }
    }
}
