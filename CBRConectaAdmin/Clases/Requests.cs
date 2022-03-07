using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using CBRConectaAdmin.Clases;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CBRConectaAdmin.Clases
{
    internal class Requests
    {
        //Dominio donde está alojada la API
        string domain = "http://www.cbrapitest.somee.com";
        
        //Petición para realizar el inicio de sesión
        public async Task<bool> login (string user, string pass)
        {
            try
            {
                string url = domain + "/api/usuario/log";
                var client = new RestClient(url);
                var request = new RestRequest();
                var body = new LoginRequest { usuario = user, contraseña = pass };
                request.AddBody(body);
                var response = await client.PostAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    dynamic jsonGot = JValue.Parse(response.Content);
                    if (jsonGot[0].privilegios == 1)
                    {
                        UserData.id = jsonGot[0].id;
                        UserData.nombre = jsonGot[0].nombre;
                        UserData.apellido = jsonGot[0].apellido;
                        UserData.privilegios = jsonGot[0].privilegios;
                        UserData.usuario = jsonGot[0].usuario;
                        UserData.puesto = jsonGot[0].puesto;
                        UserData.departamento = jsonGot[0].departamento;
                        UserData.email = jsonGot[0].email;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        
        //Petición para guardar un archivo PDF como plantila
        public async Task<bool> guardarPDFAsync (string rubro, string id, string path)
        {
            try
            {
                await DocumentRequests.SubirArchivo(rubro, id, path, domain + "/api/Archivos/subirPlantilla");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }
       
        //Petición para subir un archivo PDF como plantilla ya existente
        public async Task<bool> actualizarPDFAsync(int id, string rubro, string identificador, string path)
        {
            try
            {
                await DocumentRequests.ActualizarArchivo(id, rubro, identificador, path, domain + "/api/Archivos/ActualizarArchivo");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        //Petición para obtener un PDF plantill de la base de datos
        public async Task <byte[]> obtenerPDFAsync (int id)
        {
            try
            {
                string url = domain + "/api/archivos/obtenerarchivo";
                var client = new RestClient(url);
                var request = new RestRequest();
                var body = new DocumentRequest { id = id };
                request.AddBody(body);
                var response = await client.PostAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    dynamic jsonGot = JValue.Parse(response.Content);
                    return jsonGot;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        //Petición para registrar usuarios
        public async Task<string> singupAsync(string nombre, string apellido, int privilegios, string usuario, string contraseña, string puesto, string departamento, string email)
        {
            try
            {
                string resultado = "";
                //Cuerpo de la petición
                string jsonBody = @"{""nombre"":""" + nombre + @""",""apellido"":""" + apellido + @""", ""privilegios"": """ + privilegios + @""",""usuario"": """ + usuario + @""", ""contraseña"": """ + contraseña + @""", ""puesto"": """ + puesto + @""", ""departamento"": """ + departamento + @""", ""email"": """ + email + @""" }";

                //Petición
                WebRequest request = WebRequest.Create(domain + "/api/usuario/postuser");

                //Headers
                request.Method = "POST";
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8";


                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(jsonBody);
                    streamWriter.Flush();
                }

                //Se realiza la petición
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    resultado = await streamReader.ReadToEndAsync();
                }

                if (resultado != "")
                {
                    dynamic jsonGot = JValue.Parse(resultado);
                    if (resultado.Contains("error"))
                    {
                        resultado = jsonGot[0].mensaje;
                        return resultado;
                    }
                    else
                    {
                        resultado = "Éxito";
                        return resultado;
                    }
                }
                else
                {
                    resultado = "Respuesta de json vacía.";
                    return resultado;
                }
            }
            catch(Exception ex)
            {
                string resultado = ex.ToString();
                Console.WriteLine(resultado);
                return resultado;
            }
        }

        //Petición para crear un proyecto(obra)
        public async Task<string> crearProyecto(string nombre, DateTime inicio, string NoProyecto, string status,string path)
        {
            try
            {
                var client = new HttpClient();
                string url = domain + "/api/Proyectos/CrearProyecto";
                var bytes = File.ReadAllBytes(path);
                var byteArrayContent = new ByteArrayContent(bytes);
                var nombreContent = new StringContent(nombre);
                var fechaContent = new StringContent(inicio.ToString());
                var noProyectoContent = new StringContent(NoProyecto);
                var statusContent = new StringContent(status);
                var multipartContent = new MultipartFormDataContent();
                multipartContent.Add(byteArrayContent, "archivo", Path.GetFileName(path));
                multipartContent.Add(nombreContent, "nombre");
                multipartContent.Add(fechaContent, "fecha");
                multipartContent.Add(noProyectoContent, "NoProyecto");
                multipartContent.Add(statusContent, "Status");
                var postResponse = await client.PostAsync(url, multipartContent);
                var response = await postResponse.Content.ReadAsStringAsync();

                dynamic jsonGot = JValue.Parse(response);
                if (response.Contains("error"))
                {
                    Console.WriteLine(jsonGot[0].mensaje);
                    return jsonGot[0].mensaje;
                }
                else
                {
                    return "Éxito";
                }

            }
            catch (Exception ex)
            {
                string message = ex.ToString();
                Console.WriteLine(message);
                return message;
            }
        }

        //Petición para obtener todos los proyectos (activos o inactivos)
        public async Task<dynamic> obtenerProyectos()
        {
            string url = domain + "/api/Proyectos/MostarTodasLasObras";
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                var response = await client.GetAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //Petición para obtener todos los empleados en la BD
        public async Task<dynamic> obtenerEmpleados()
        {
            string url = domain + "/api/Usuario/ObtenerEmpleados";
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                var response = await client.GetAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //Petición para asignar un trabajador a una obra
        public async Task<string> asignarTrabajador(string idUsuario, string idObra)
        {
            string url = domain + "/api/Proyectos/AsignarTranbajador";
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                var body = new AsignarTrabajadorRequest { obra = idObra, usuario = idUsuario };
                request.AddBody(body);
                var response = await client.PostAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    
        //Petición para obtener todo el catálogo de archivos plantilla
        public async Task<dynamic> obtenerCatalogo()
        {
            string url = domain + "/api/Archivos/ObtenerCatalogo";
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                var response = await client.GetAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //Obtiene el usuario asignado en una obra específica
        public async Task<dynamic> userInObra(dynamic obra)
        {
            string url = domain + "/api/Proyectos/UsuariosEnObtra";
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                var body = new UserInObraRequest { id = obra };
                request.AddBody(body);
                var response = await client.PostAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    
        //Obtiene la lista de archivos que hay por cada obra
        public async Task<dynamic> obtenerDocsPerObra(int idObra)
        {
            string url = domain + "/api/Proyectos/ArchivosObra";
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                var body = new UserInObraRequest { id = idObra };
                request.AddBody(body);
                var response = await client.PostAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //Obtiene la lista de archivos que hay por cada obra
        public async Task<byte[]> obtenerPDFPerObra(int idFile)
        {
            try
            {
                string url = domain + "/api/Archivos/ObtenerArchivoObra";
                var client = new RestClient(url);
                var request = new RestRequest();
                var body = new DocumentRequest { id = idFile };
                request.AddBody(body);
                var response = await client.PostAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    dynamic jsonGot = JValue.Parse(response.Content);
                    return jsonGot;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
    }
}
