using Banco_BibliotecaDDL.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp_Formularios.HTTP
{
    public class ClientSingleton
    {
        private static ClientSingleton instancia;
        private HttpClient client;
        private ClientSingleton()
        {
            client = new HttpClient();
        }
        public static ClientSingleton GetInstance()
        {
            if (instancia == null)
                instancia = new ClientSingleton();
            return instancia;
        }


        public async Task<string> GetAsync(string url) // ver si le mando por parametros y funciona... 
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<string> GetAsync(string url, string usuarioJson) // ver si es usuario api
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode) // lo cambio por mi validacion
                content = await result.Content.ReadAsStringAsync();
            return content;
        }


        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PostAsync(url, content); // llega hasta aca y se clava
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
    }
}
