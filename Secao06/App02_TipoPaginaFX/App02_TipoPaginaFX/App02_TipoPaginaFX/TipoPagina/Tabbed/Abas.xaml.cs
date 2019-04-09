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

            this.SetTitle();
        }

        private void SetTitle()
        {
            Title = ToolbarItems.Where(x => x.IsEnabled).Select(w => w.Text).FirstOrDefault();
        }
    }
}