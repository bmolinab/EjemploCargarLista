using EjemploCargarLista.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCargarLista.Servicio
{
    public class ApiServices
    {
        public async Task<List<AmortizacionModel>> Datos()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://servicesappcliente.azurewebsites.net");
                var url = "/api/cabecera/tablamortizacion?cuotaCantidad=60000&cuotaPlazo=36&cuotaTipoPrestamo=1";
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var result = await response.Content.ReadAsStringAsync();
                var Lista = JsonConvert.DeserializeObject<List<AmortizacionModel>>(result);
                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
