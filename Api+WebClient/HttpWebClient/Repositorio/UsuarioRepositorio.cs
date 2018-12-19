using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UsuarioAPI.Models;
using Newtonsoft.Json;

namespace HttpWebClient.Repositorio
{
    public class UsuarioRepositorio
    {
        HttpClient cliente = new HttpClient();

        

        public UsuarioRepositorio(){
            cliente.BaseAddress = new System.Uri("http://localhost:5000");

            cliente.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
        }

        public async Task<List<Usuario>> GetUsuariosAsync(){
            HttpResponseMessage response = await cliente.GetAsync("api/usuarios");

            if(response.IsSuccessStatusCode){
                var dados = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Usuario>>(dados);
            }
            return new List<Usuario>();
        }

        public async Task<Usuario> GetUsuarioAsync(long Id){
            HttpResponseMessage response = await cliente.GetAsync($"api/usuarios/{Id}");

            if(response.IsSuccessStatusCode){
                var usuario = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Usuario>(usuario);
            }
            return new Usuario();
        }

        public async Task<bool> PostUsuarioAsync(Usuario usuario){
            HttpResponseMessage response = await cliente.PostAsJsonAsync("api/usuarios",usuario);

            if(response.IsSuccessStatusCode){
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteUsuarioAsync(long Id){
            HttpResponseMessage response = await cliente.DeleteAsync($"api/usuarios/{Id}");

            if(response.IsSuccessStatusCode){
                return true;
            }
            return false;
        }

        public async Task<string> PutUsuarioAsync(long Id, Usuario usuario){
            HttpResponseMessage response = await cliente.PutAsJsonAsync($"api/usuarios/{Id}",usuario);

            if(response.IsSuccessStatusCode){
                return "Inserido OK";
            }
            return await response.Content.ReadAsStringAsync();
        }
        
    }
}