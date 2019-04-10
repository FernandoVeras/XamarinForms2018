using App02_TipoPaginaFX.TipoPagina.Naviagation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaFX.TipoPagina.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();

            this.DoSomething();
        }

        private void DoSomething()
        {
            Children.Add(new NavigationPage(new Pagina1()) { Title = "Teste Fernando1" });
            Children.Add(new NavigationPage(new Pagina2()) { Title = "Teste Fernando2" });
        }
    }
}