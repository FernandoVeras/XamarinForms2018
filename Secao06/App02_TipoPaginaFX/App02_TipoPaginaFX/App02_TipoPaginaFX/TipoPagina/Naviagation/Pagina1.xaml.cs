using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaFX.TipoPagina.Naviagation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();

            Title = "Pagina 1";

            btnPage2.Clicked += (sender, e) => { Navigation.PushAsync(new Pagina2(), true); };

            btnChamarModal.Clicked += (sender, e) => { Navigation.PushModalAsync(new Modal()); };
        }
    }
}