using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CBRConectaAdmin.Clases
{
    static class DocumentRequests
    {
        public static async Task SubirArchivo(string rubro, string identificador, string path, string url)
        {
            var client = new HttpClient();
            var bytes = File.ReadAllBytes(path);
            var byteArrayContent = new ByteArrayContent(bytes);
            var rubroContent = new StringContent(rubro);
            var idContent = new StringContent(identificador);
            var multipartContent = new MultipartFormDataContent();
            multipartContent.Add(byteArrayContent, "archivo", Path.GetFileName(path));
            multipartContent.Add(rubroContent, "rubro");
            multipartContent.Add(idContent, "id");
            var postResponse = await client.PostAsync(url, multipartContent);
        }

        public static async Task ActualizarArchivo(int id, string rubro, string identificador, string path, string url)
        {
            var client = new HttpClient();
            var bytes = File.ReadAllBytes(path);
            var byteArrayContent = new ByteArrayContent(bytes);
            var rubroContent = new StringContent(rubro);
            var idContent = new StringContent(identificador);
            var idCatContent = new StringContent(id.ToString());
            var multipartContent = new MultipartFormDataContent();
            multipartContent.Add(idCatContent, "idArchivo");
            multipartContent.Add(byteArrayContent, "archivo", Path.GetFileName(path));
            multipartContent.Add(rubroContent, "rubro");
            multipartContent.Add(idContent, "id");
            var postResponse = await client.PutAsync(url, multipartContent);
        }
    }
}
