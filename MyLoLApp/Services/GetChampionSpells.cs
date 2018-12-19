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
    public class GetChampionSpells
    {
        public string championsUrl = "http://lol-guide.ru/api/championspells/?championid=";

        public List<ChampionSpells> GetSpellsChampions(int key)
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(championsUrl + key);
                List<ChampionSpells> champions = JsonConvert.DeserializeObject<List<ChampionSpells>>(json);
                return champions.Select(x => new ChampionSpells
                {
                    fkey = x.fkey,
                    name = x.name,
                    description = x.description,
                    spelltype = x.spelltype,
                    image = x.image
                    
                }).ToList();
            }
        }
    }
}

public class ChampionSpells
{
    public int fkey { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string spelltype { get; set; }
    public string image { get; set; }
}

