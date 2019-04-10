using App02_TipoPaginaFX.TipoPagina.Naviagation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaFX.TipoPagina.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoPagina3 : ContentPage
    {
        public TipoPagina3()
        {
            InitializeComponent();

            btnClicar.Clicked += MudarPagina;
            btnAbrirMasterDetail.Clicked += (sender, e) => { App.Current.MainPage = new Master.Maaster(); };
        }

        public void MudarPagina(object sender, EventArgs e)
        {
            // colcoar dentro da navigation page pra poder ter o controle de ir e voltar entre as páginas
            //App.Current.MainPage = new NavigationPage(new Pagina1());
            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}