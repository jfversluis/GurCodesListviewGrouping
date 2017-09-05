using System.Collections.ObjectModel;
using GurCodesListviewGrouping.Models;
using GurCodesListviewGrouping.Services;
using MvvmHelpers;
using Xamarin.Forms;
using System.Linq;

namespace GurCodesListviewGrouping
{
    public partial class GurCodesListviewGroupingPage : ContentPage
    {
        public ObservableCollection<Grouping<string, Superhero>> Items { get; set; } = new ObservableCollection<Grouping<string, Superhero>>();

        public GurCodesListviewGroupingPage()
        {
            InitializeComponent();

            //foreach (var h in SuperheroService.GetSuperheroes())
            //Items.Add(h);

            var items = from hero in SuperheroService.GetSuperheroes()
                        orderby hero.Name
                        group hero by hero.Name[0].ToString().ToUpperInvariant() into heroGroup
                        select new Grouping<string, Superhero>(heroGroup.Key, heroGroup);

            foreach (var g in items)
                Items.Add(g);

            BindingContext = this;
        }
    }
}