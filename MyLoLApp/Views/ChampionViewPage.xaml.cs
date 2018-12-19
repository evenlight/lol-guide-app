using System;
using System.Collections.Generic;
using System.Text;
using MyLoLApp.Services;
using Xamarin.Forms;

namespace MyLoLApp.Views
{
    public partial class ChampionViewPage : ContentPage
    {
        public List<ChampionLore> ChampionLore { get; set; }
        public List<ChampionSpells> ChampionSpells { get; set; }

        public ChampionViewPage(string title, string id, string description, string name, int fkey)
        {
            string championDescription = "";

            InitializeComponent();

            //Получим лор чемпиона
            var GetLore = new GetInfoChampion();

            ChampionLore = GetLore.GetChampLore(fkey);

            foreach (var lore in ChampionLore)
            {
                championDescription = lore.lore;
            }

            ////Получим все скиллы чемпиона
            var GetSpells = new GetChampionSpells();
            ChampionSpells = GetSpells.GetSpellsChampions(fkey);

            //для отрисовки картинок
            string imageChampUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/"+id+"_0.jpg";

            //Биндим в XAML
            ChampName.Text = name;
            ChampDescription.Text = championDescription.Replace("<br>", "\n");
            ChampImage.Source = imageChampUrl;
            Title = name;
            this.BindingContext = this;
        }

    }
}
