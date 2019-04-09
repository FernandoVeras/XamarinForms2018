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
    public partial class Modal : ContentPage
    {
        public Modal()
        {
            InitializeComponent();

            btnFechaModal.Clicked += FecharModal;
        }

        private void FecharModal(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}