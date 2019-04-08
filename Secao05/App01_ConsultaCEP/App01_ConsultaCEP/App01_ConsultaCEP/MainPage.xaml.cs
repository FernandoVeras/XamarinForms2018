using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultaCEP.Servico;
using App01_ConsultaCEP.Servico.Modelo;

namespace App01_ConsultaCEP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnPesquisar.Clicked += BuscarCep;
        }

        private void BuscarCep(object sender, EventArgs e)
        {
            var cep = txtCep.Text;
            if (string.IsNullOrEmpty(cep) || !int.TryParse(cep, out int result) || (cep.Length <= 0 || cep.Length > 8))
            {
                DisplayAlert("Erro!", "Informe um CEP válido!", "OK");
            }
            else
            {
                cep.Trim();

                var endereco = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                lbResultado.Text = string.Format("Endereço é: {0},{1},{2}", endereco.logradouro, endereco.bairro, endereco.localidade);
            }
        }
    }
}
