using App02_TipoPaginaFX.TipoPagina.Naviagation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaFX.TipoPagina.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maaster : MasterDetailPage
    {
        public Maaster()
        {
            InitializeComponent();

            btnPagina1.Clicked += (sender, e) => { Detail = new Pagina1(); };
            btnPagina2.Clicked += (sender, e) => { Detail = new Pagina2(); };
            btnPagina3.Clicked += (sender, e) => { Detail = new Conteudo(); };
        }
    }
}