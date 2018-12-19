using System.Collections.Generic;
using Xamarin.Forms;
using MyLoLApp.Services;
using System.Threading.Tasks;

namespace MyLoLApp.Views
{
    public partial class ChampionsPage : ContentPage
    {
        public List<Champion> Champions { get; set; }

        public ChampionsPage()
        {
            InitializeComponent();

            var champions = new GetAllChampions();
            Champions = champions.GetAllChamps();
            this.BindingContext = this;

        }

        public void GetChampInfo(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var champion = e.SelectedItem as Champion;
                Navigation.PushAsync(new ChampionViewPage(champion.title, champion.id, champion.blurb, champion.name, champion.fkey));
            }

            champList.SelectedItem = null;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
