using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultaCEP.Servico.Modelo;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace App01_ConsultaCEP.Servico
{
    public class ViaCEPServico
    {
        private static readonly string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            try
            {
                var novoEnderecoUrl = string.Format(EnderecoURL, cep);

                var client = new WebClient();
                var stringRetornada = client.DownloadString(novoEnderecoUrl);

                return JsonConvert.DeserializeObject<Endereco>(stringRetornada);
            }
            catch (Exception e)
            {
                return new Endereco();
            }
        }
    }
}
