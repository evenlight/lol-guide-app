using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace MyLoLApp.Services
{
    public class GetInfoChampion
    {
        public string championsUrl = "http://lol-guide.ru/api/championinfo/?championid=";

        public List<ChampionLore> GetChampLore(int key)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(championsUrl+key);
                List<ChampionLore> champions = JsonConvert.DeserializeObject<List<ChampionLore>>(json);

                return champions.Select(x => new ChampionLore
                {
                    lore = x.lore

                }).ToList();
            }
        }
    }
    public class ChampionLore
    {
        public string lore { get; set; }
    }
}
