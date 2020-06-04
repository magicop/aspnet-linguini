using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using WebLinguini.Models.DTO;
using System.Text;
using WebLinguini.Models.ViewModel;

namespace WebLinguini.Models
{
    public class ApiRestful
    {

        public string BASE_URL = "http://localhost:8034/";
        static HttpClient client = new HttpClient();

        // Hechas
        
        #region Categorias

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<Categoria> listarCategorias()
        {
            try
            {
                var client = new HttpClient();
                List<Categoria> list = new List<Categoria>();
                List<Categoria> list2 = new List<Categoria>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/categoria/all").Result;

                var task = client.GetAsync("api/categoria/all")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Categoria>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Categoria c = new Categoria();
                         c.idCategoria = item.idCategoria;
                         c.nombreCategoria = item.nombreCategoria;
                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar
        #endregion


        #endregion

        #region Carta

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<Carta2> listarCartas()
        {
            try
            {
                var client = new HttpClient();
                List<Carta2> list2 = new List<Carta2>();
                List<Carta2> list = new List<Carta2>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/carta/listarCartas").Result;

                var task = client.GetAsync("api/carta/listarCartas")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list2 = JsonConvert.DeserializeObject<List<Carta2>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Carta2 c = new Carta2();
                         c.idCarta = item.idCarta;
                         c.nombreCarta = item.nombreCarta;
                         c.valorCarta = item.valorCarta;
                         c.nombreCategoria = item.nombreCategoria;
                         c.imagenCarta = item.imagenCarta;

                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar

        public Carta buscarCarta(Carta c)
        {
            try
            {
                var client = new HttpClient();
                Carta list = new Carta();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string url = BASE_URL + "api/carta/" + c.idCarta;
                HttpResponseMessage response = client.GetAsync(url).Result;

                var task = client.GetAsync(url)
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<Carta>(jsonString.Result);
                    
                     c.idCarta = list.idCarta;
                     c.nombreCarta = list.nombreCarta;
                     c.valorCarta = list.valorCarta;
                     c.nombreCategoria = list.nombreCategoria;
                     c.imagenCarta = list.imagenCarta;
                     

                 });

                task.Wait();

                return c;
            }
            catch
            {
                return null;
            }
        }
        #endregion


        #endregion

        #region Empleado

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<Empleado> listarEmpleados()
        {
            try
            {
                var client = new HttpClient();
                List<Empleado> list = new List<Empleado>();
                List<Empleado> list2 = new List<Empleado>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/empleado/listarEmpleados").Result;

                var task = client.GetAsync("api/empleado/listarEmpleados")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Empleado>>(jsonString.Result);

                     var prueba = list.ToArray();


                     foreach (var item in prueba)
                     {
                         Empleado c = new Empleado();
                         c.idEmpleado = item.idEmpleado;
                         c.apMaternoEmpleado = item.apMaternoEmpleado;
                         c.apPaternoEmpleado = item.apPaternoEmpleado;
                         c.direccionEmpleado = item.direccionEmpleado;
                         c.nombreEmpleado = item.nombreEmpleado;
                         c.rutEmpleado = item.rutEmpleado;
                         c.telefonoEmpleado = item.telefonoEmpleado;
                         c.usuarios = item.usuarios;
                         c.rol = item.rol;

                         list2.Add(c);
                         list.Remove(c);

                    }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        public List<Empleado> listarMeseros()
        {
            try
            {
                var client = new HttpClient();
                List<Empleado> list = new List<Empleado>();
                List<Empleado> list2 = new List<Empleado>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/empleado/meseros").Result;

                var task = client.GetAsync("api/empleado/meseros")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Empleado>>(jsonString.Result);

                     var prueba = list.ToArray();


                     foreach (var item in prueba)
                     {
                         Empleado c = new Empleado();
                         c.idEmpleado = item.idEmpleado;
                         c.apMaternoEmpleado = item.apMaternoEmpleado;
                         c.apPaternoEmpleado = item.apPaternoEmpleado;
                         c.direccionEmpleado = item.direccionEmpleado;
                         c.nombreEmpleado = item.nombreEmpleado;
                         c.rutEmpleado = item.rutEmpleado;
                         c.telefonoEmpleado = item.telefonoEmpleado;
                         c.usuarios = item.usuarios;
                         c.rol = item.rol;

                         list2.Add(c);
                         list.Remove(c);

                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        public List<Empleado> listarAdminBodega()
        {
            try
            {
                var client = new HttpClient();
                List<Empleado> list = new List<Empleado>();
                List<Empleado> list2 = new List<Empleado>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/empleado/listarAdminBodega").Result;

                var task = client.GetAsync("api/empleado/listarAdminBodega")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Empleado>>(jsonString.Result);

                     var prueba = list.ToArray();


                     foreach (var item in prueba)
                     {
                         Empleado c = new Empleado();
                         c.idEmpleado = item.idEmpleado;
                         c.apMaternoEmpleado = item.apMaternoEmpleado;
                         c.apPaternoEmpleado = item.apPaternoEmpleado;
                         c.direccionEmpleado = item.direccionEmpleado;
                         c.nombreEmpleado = item.nombreEmpleado;
                         c.rutEmpleado = item.rutEmpleado;
                         c.telefonoEmpleado = item.telefonoEmpleado;
                         c.usuarios = item.usuarios;
                         c.rol = item.rol;

                         list2.Add(c);
                         list.Remove(c);

                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar
        #endregion


        #endregion

        #region Mesa

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        // Listar mesas disponibles
        public List<Mesa> listarMesas()
        {
            try
            {
                var client = new HttpClient();
                List<Mesa> list = new List<Mesa>();
                List<Mesa> list2 = new List<Mesa>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/mesa/listarMesas").Result;

                var task = client.GetAsync("api/mesa/listarMesas")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Mesa>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Mesa c = new Mesa();
                         c.idMesa = item.idMesa;
                         c.cantidadPersonas = item.cantidadPersonas;
                         c.nombreEmpleado = item.nombreEmpleado;
                         c.nombreEstado = item.nombreEstado;

                         list2.Add(c);
                         list.Remove(c);

                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar

        public Mesa buscarMesa(Mesa c)
        {
            try
            {
                var client = new HttpClient();
                Mesa list = new Mesa();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string url = BASE_URL + "api/mesa/" + c.idMesa;
                HttpResponseMessage response = client.GetAsync(url).Result;

                var task = client.GetAsync(url)
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<Mesa>(jsonString.Result);

                     c.idMesa = list.idMesa;
                     c.cantidadPersonas = list.cantidadPersonas;
                     c.nombreEmpleado = list.nombreEmpleado;
                     c.nombreEstado = list.nombreEstado;

                 });

                task.Wait();

                return c;
            }
            catch
            {
                return null;
            }
        }
        #endregion


        #endregion

        #region Orden

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        // Listar orden en estado lista

        public List<Orden> listarOrdenes()
        {
            try
            {
                var client = new HttpClient();
                List<Orden> list = new List<Orden>();
                List<Orden> list2 = new List<Orden>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/orden/listarOrdenes").Result;

                var task = client.GetAsync("api/orden/listarOrdenes")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();

                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Orden>>(jsonString.Result);


                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Orden c = new Orden();

                         c.idOrden = item.idOrden;
                         c.fechaEmisionOrden = item.fechaEmisionOrden;
                         c.idMesa = item.idMesa;
                         c.nombreCarta = item.nombreCarta;
                         c.nombreEstado = item.nombreEstado;

                         list2.Add(c);
                         list.Remove(c);

                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        public List<Orden> listarOrdenLista()
        {
            try
            {
                var client = new HttpClient();
                List<Orden> list = new List<Orden>();
                List<Orden> list2 = new List<Orden>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/orden/allOrdenLista").Result;

                var task = client.GetAsync("api/orden/allOrdenLista")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();

                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Orden>>(jsonString.Result);


                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Orden c = new Orden();
                         
                         c.idOrden = item.idOrden;
                         c.fechaEmisionOrden = item.fechaEmisionOrden;
                         c.idMesa = item.idMesa;
                         c.nombreCarta = item.nombreCarta;
                         c.nombreEstado = item.nombreEstado;
                         c.imagenCarta = "";

                         list2.Add(c);
                         list.Remove(c);

                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        // Listar orden en estado preparación
        public List<Orden> listarOrdenPreparacion()
        {
            try
            {
                var client = new HttpClient();
                List<Orden> list = new List<Orden>();
                List<Orden> list2 = new List<Orden>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/orden/allOrdenPreparacion").Result;

                var task = client.GetAsync("api/orden/allOrdenPreparacion")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();

                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Orden>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Orden c = new Orden();
                         c.idOrden = item.idOrden;
                         c.fechaEmisionOrden = item.fechaEmisionOrden;
                         c.idMesa = item.idMesa;
                         c.nombreCarta = item.nombreCarta;
                         c.nombreEstado = item.nombreEstado;

                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list;
            }
            catch
            {
                return null;
            }
        }

        // Listar orden en estado preparación
        public List<Orden> listarOrdenTerminada()
        {
            try
            {
                var client = new HttpClient();
                List<Orden> list = new List<Orden>();
                List<Orden> list2 = new List<Orden>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/orden/allOrdenTerminada").Result;

                var task = client.GetAsync("api/orden/allOrdenTerminada")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();

                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Orden>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Orden c = new Orden();
                         c.idOrden = item.idOrden;
                         c.fechaEmisionOrden = item.fechaEmisionOrden;
                         c.idMesa = item.idMesa;
                         c.nombreCarta = item.nombreCarta;
                         c.nombreEstado = item.nombreEstado;

                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }



        #endregion

        #region Eliminar
        #endregion

        #region Buscar

        public Orden buscarOrden(Orden c)
        {
            try
            {
                var client = new HttpClient();
                Orden list = new Orden();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string url = BASE_URL + "api/orden/" + c.idOrden; // o idMesa
                HttpResponseMessage response = client.GetAsync(url).Result;

                var task = client.GetAsync(url)
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<Orden>(jsonString.Result);

                     c.idOrden = list.idOrden;
                     c.idMesa = list.idMesa;
                     c.nombreCarta = list.nombreCarta;
                     c.nombreEstado = list.nombreEstado;

                 });

                task.Wait();

                return c;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region ListaPreparacion
        public void listaPreparacion(int c)
        {
           
            var client = new HttpClient();
            Orden list = new Orden();
            client.BaseAddress = new Uri(BASE_URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string url = BASE_URL + "api/orden/ordenEnPreparacion/" + c;
            var stringContent = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url, stringContent).Result;
                
        }
        #endregion

        #region PreparacionTerminacion
        public void preparacionTerminacion(int c)
        {

            var client = new HttpClient();
            Orden list = new Orden();
            client.BaseAddress = new Uri(BASE_URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string url = BASE_URL + "api/orden/ordenTerminada/" + c;
            var stringContent = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url, stringContent).Result;

        }
        #endregion


        #endregion

        #region Producto

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<Producto> listarProductos()
        {
            try
            {
                var client = new HttpClient();
                List<Producto> list = new List<Producto>();
                List<Producto> list2 = new List<Producto>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/producto/listarProductos").Result;

                var task = client.GetAsync("api/producto/listarProductos")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Producto>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Producto c = new Producto();
                         c.idProducto = item.idProducto;
                         c.nombreProducto = item.nombreProducto;
                         c.nombreCategoria = item.nombreCategoria;

                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar
        #endregion


        #endregion

        #region Usuario

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar
        /*public List<Usuario> listarUsuarios(Usuario c)
        {
            try
            {
                var client = new HttpClient();
                List<Usuario> list = null;
                BASE_URL = BASE_URL + c.username + "/" + c.password;
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/usuario/").Result;

                var task = client.GetAsync("api/categoria/all")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Categoria>>(jsonString.Result);
                     foreach (var item in list)
                     {
                         Categoria c = new Categoria();
                         c.idCategoria = item.idCategoria;
                         c.nombreCategoria = item.nombreCategoria;
                         list2.Add(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }*/
        #endregion

        #region Eliminar
        #endregion

        #region Buscar

        public static async Task<Usuario> getUsuario(Usuario c)
        {
            Usuario u = null;
            var url = "http://localhost:8034/api/usuario/{0}/{1}/" + c.username + c.password;
            HttpResponseMessage response = await client.GetAsync(url);
            if(response.IsSuccessStatusCode)
            {
                u = await response.Content.ReadAsAsync<Usuario>();
            }
            return u;
        }

        /*public bool buscarUsuario(Usuario c)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/usuario/{0}/{1}/").Result;

                var task = client.GetAsync("api/categoria/all")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     
                 });

                task.Wait();

                return true;
            }
            catch
            {
                return false;
            }
        }*/


        #endregion


        #endregion

        #region Cliente

        #region Listar
        public List<Cliente> listarClientes()
        {
            try
            {
                var client = new HttpClient();
                List<Cliente> list = new List<Cliente>();
                List<Cliente> list2 = new List<Cliente>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/cliente/listarClientes").Result;

                
                var task = client.GetAsync("api/cliente/listarClientes")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Cliente>>(jsonString.Result);
                     var prueba = list.ToArray();

                     foreach (var item in list)
                     {
                         Cliente c = new Cliente();
                         c.rutCliente = item.rutCliente;
                         c.apMaternoCliente = item.apMaternoCliente;
                         c.apPaternoCliente = item.apPaternoCliente;
                         c.nombreCliente = item.nombreCliente;
                         c.telefonoCliente = item.telefonoCliente;
                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #endregion

        #region Comprobante

        #region Listar
        public List<Comprobante> listarComprobantes()
        {
            try
            {
                var client = new HttpClient();
                List<Comprobante> list = new List<Comprobante>();
                List<Comprobante> list2 = new List<Comprobante>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/comprobante/listarComprobantes").Result;

                var task = client.GetAsync("api/comprobante/listarComprobantes")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Comprobante>>(jsonString.Result);
                     var prueba = list.ToArray();
                     foreach (var item in prueba)
                     {
                         Comprobante c = new Comprobante();
                         c.idComprobante = item.idComprobante;
                         c.fechaEmisionComprobante = item.fechaEmisionComprobante;
                         c.idMesa = item.idMesa;
                         c.totalComprobante = item.totalComprobante;
                         c.nombreTipoPago = item.nombreTipoPago;
                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Buscar

        public Comprobante buscarComprobante(ComprobanteViewModel c)
        {
            try
            {
                var client = new HttpClient();
                Comprobante list = new Comprobante();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string url = BASE_URL + "api/comprobante/" + c.idComprobante;
                HttpResponseMessage response = client.GetAsync(url).Result;
                Comprobante d = new Comprobante();

                var task = client.GetAsync(url)
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<Comprobante>(jsonString.Result);
                     

                     d.idComprobante = list.idComprobante;
                     d.descripcionTipoPago = list.descripcionTipoPago;
                     d.fechaEmisionComprobante = list.fechaEmisionComprobante;
                     d.totalComprobante = list.totalComprobante;
                     d.idOrden = list.idOrden;
                     d.nombreTipoPago = list.nombreTipoPago;

                 });

                task.Wait();

                return d;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #endregion

        #region DetalleCarta

        #region Agregar

        #endregion

        #region Listar
        public List<DetalleCarta> listarDetalleCarta()
        {
            try
            {
                var client = new HttpClient();
                List<DetalleCarta> list = new List<DetalleCarta>();
                List<DetalleCarta> list2 = new List<DetalleCarta>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/detalleCarta/listarDetalleCartas").Result;

                var task = client.GetAsync("api/detalleCarta/listarDetalleCartas")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<DetalleCarta>>(jsonString.Result);
                     var prueba = list.ToArray();
                     foreach (var item in prueba)
                     {
                         DetalleCarta c = new DetalleCarta();
                         c.idDetalleCarta = item.idDetalleCarta;
                         c.cantidadProducto = item.cantidadProducto;
                         c.nombreCartas = item.nombreCartas;
                         c.nombreProducto = item.nombreProducto;

                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #endregion

        #region Estado

        #region Listar
        public List<Estado> listarEstados()
        {
            try
            {
                var client = new HttpClient();
                List<Estado> list = new List<Estado>();
                List<Estado> list2 = new List<Estado>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/estado/listarEstados").Result;

                var task = client.GetAsync("api/estado/listarEstados")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Estado>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Estado c = new Estado();
                         c.idEstado = item.idEstado;
                         c.nombreEstado = item.nombreEstado;
                         
                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #endregion

        #region Log

        #region Listar
        public List<Log> listarLogs()
        {
            try
            {
                var client = new HttpClient();
                List<Log> list = new List<Log>();
                List<Log> list2 = new List<Log>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/logs/listarLogs").Result;

                var task = client.GetAsync("api/logs/listarLogs")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Log>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Log c = new Log();
                         c.idLog = item.idLog;
                         c.descripcionLog = item.descripcionLog;
                         c.tipoLog = item.tipoLog;

                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #endregion

        #region PedidoProveedor

        #region Agregar
        
        #endregion

        #region Listar
        public List<PedidoProveedor> listarPedidosProveedores()
        {
            try
            {
                var client = new HttpClient();
                List<PedidoProveedor> list = new List<PedidoProveedor>();
                List<PedidoProveedor> list2 = new List<PedidoProveedor>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/pedidoProveedor/listarPedidoProveedor").Result;

                var task = client.GetAsync("api/pedidoProveedor/listarPedidoProveedor")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<PedidoProveedor>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         PedidoProveedor c = new PedidoProveedor();
                         c.idPedidoProveedor = item.idPedidoProveedor;
                         c.fechaEmisionSolicitud = item.fechaEmisionSolicitud;
                         c.fechaEntregaSolicitud = item.fechaEntregaSolicitud;
                         c.ordenCompra = item.ordenCompra;
                         c.nombreEstado = item.nombreEstado;
                         c.totalPedidoProveedor = item.totalPedidoProveedor;
                         c.nombreEmpleado = item.nombreEmpleado;
                         c.nombreProveedor = item.nombreProveedor;
                         c.nombreTipoPago = item.nombreTipoPago;

                         list2.Add(c);
                         list.Remove(c);

                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Ultima Orden Compra
        public PedidoProveedor ultimaOrdenCompra()
        {
            try
            {
                var client = new HttpClient();
                PedidoProveedor list = new PedidoProveedor();
                PedidoProveedor p = new PedidoProveedor();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/solicitudProveedor/ultimaOrdenCompra").Result;

                var task = client.GetAsync("api/solicitudProveedor/ultimaOrdenCompra")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     int ordenCompra = JsonConvert.DeserializeObject<int>(jsonString.Result);
                     p.ordenCompra = Convert.ToInt32(ordenCompra); 
                     
                 });

                task.Wait();

                return p;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Buscar

        public PedidoProveedor buscarPedProvPorOrdenCompra(PedidoProveedor c)
        {
            try
            {
                var client = new HttpClient();
                PedidoProveedor list = new PedidoProveedor();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string url = BASE_URL + "api/pedidoProveedor/" + c.ordenCompra;
                HttpResponseMessage response = client.GetAsync(url).Result;

                var task = client.GetAsync(url)
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<PedidoProveedor>(jsonString.Result);

                     c.idPedidoProveedor = list.idPedidoProveedor;
                     c.nombreEmpleado = list.nombreEmpleado;
                     c.nombreTipoPago = list.nombreTipoPago;
                     c.fechaEmisionSolicitud = list.fechaEntregaSolicitud;
                     c.fechaEntregaSolicitud = list.fechaEntregaSolicitud;
                     c.totalPedidoProveedor = list.totalPedidoProveedor;
                     c.nombreProveedor = list.nombreProveedor;
                     c.ordenCompra = list.ordenCompra;

                 });

                task.Wait();

                return c;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Recibir Pedido
        public void recibirPedido(int c)
        {

            var client = new HttpClient();
            Orden list = new Orden();
            client.BaseAddress = new Uri(BASE_URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string url = BASE_URL + "api/pedidoProveedor/" + c;
            var stringContent = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url, stringContent).Result;

        }
        #endregion

        #endregion

        #region Proveedor

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<Proveedor> listarProveedores()
        {
            try
            {
                var client = new HttpClient();
                List<Proveedor> list = new List<Proveedor>();
                List<Proveedor> list2 = new List<Proveedor>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/proveedor/listarProveedor").Result;

                var task = client.GetAsync("api/proveedor/listarProveedor")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Proveedor>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Proveedor c = new Proveedor();
                         c.idProveedor = item.idProveedor;
                         c.direccionProveedor = item.direccionProveedor;
                         c.nombreProveedor = item.nombreProveedor;
                         c.rutProveedor = item.rutProveedor;
                         c.telefonoProveedor = item.telefonoProveedor;

                         list2.Add(c);
                         list.Remove(c);
                     }

                });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar

        public Proveedor buscarProveedor(Proveedor c)
        {
            try
            {
                var client = new HttpClient();
                Proveedor list = new Proveedor();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string url = BASE_URL + "api/proveedor/" + c.idProveedor;
                HttpResponseMessage response = client.GetAsync(url).Result;

                var task = client.GetAsync(url)
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<Proveedor>(jsonString.Result);

                     c.idProveedor = list.idProveedor;
                     c.nombreProveedor = list.nombreProveedor;
                     c.rutProveedor = list.rutProveedor;
                     c.telefonoProveedor = list.telefonoProveedor;
                     c.direccionProveedor = list.direccionProveedor;
                 });

                task.Wait();

                return c;
            }
            catch
            {
                return null;
            }
        }
        #endregion


        #endregion

        #region Reservas

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<Reservas> listarReservas()
        {
            try
            {
                var client = new HttpClient();
                List<Reservas> list = new List<Reservas>();
                List<Reservas> list2 = new List<Reservas>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/reserva/listarReservas").Result;

                var task = client.GetAsync("api/reserva/listarReservas")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Reservas>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Reservas c = new Reservas();
                         c.idReserva = item.idReserva;
                         c.apMaternoCliente = item.apMaternoCliente;
                         c.apPaternoCliente = item.apPaternoCliente;
                         c.fechaEmisionReserva = item.fechaEmisionReserva;
                         c.fechaReserva = item.fechaReserva;
                         c.nombreCliente = item.nombreCliente;
                         c.cantidadPersonas = item.cantidadPersonas;
                         c.rutCliente = item.rutCliente;
                         c.telefonoCliente = item.telefonoCliente;
                         c.nombreEstado = item.nombreEstado;
                         c.idMesa = item.idMesa;

                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar
        #endregion


        #endregion

        #region Rol

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<Rol> listarRoles()
        {
            try
            {
                var client = new HttpClient();
                List<Rol> list = new List<Rol>();
                List<Rol> list2 = new List<Rol>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/rol/listarRoles").Result;

                var task = client.GetAsync("api/rol/listarRoles")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Rol>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Rol c = new Rol();

                         c.idRol = item.idRol;
                         c.nombreRol = item.nombreRol;
                         
                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar
        #endregion


        #endregion

        #region Solicitud Proveedor

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<SolicitudProveedor> listarSolicitudProveedores()
        {
            try
            {
                var client = new HttpClient();
                List<SolicitudProveedor> list = new List<SolicitudProveedor>();
                List<SolicitudProveedor> list2 = new List<SolicitudProveedor>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/solicitudProveedor/listarReservas").Result;

                var task = client.GetAsync("api/solicitudProveedor/listarReservas")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<SolicitudProveedor>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         SolicitudProveedor c = new SolicitudProveedor();

                         c.idSolicitudProveedor = item.idSolicitudProveedor;
                         c.cantidadSolicitud = item.cantidadSolicitud;
                         c.ordenCompra = item.ordenCompra;
                         c.valorDetalleSolicitud = item.valorDetalleSolicitud;
                         c.nombreEmpleado = item.nombreEmpleado;
                         c.nombreProducto = item.nombreProducto;
                         c.nombreProveedor = item.nombreProveedor;

                         list2.Add(c);
                         list.Remove(c);

                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar

        public SolicitudProveedor buscarSolProv(SolicitudProveedor c)
        {
            try
            {
                var client = new HttpClient();
                SolicitudProveedor list = new SolicitudProveedor();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string url = BASE_URL + "api/solicitudProveedor/" + c.idSolicitudProveedor;
                HttpResponseMessage response = client.GetAsync(url).Result;

                var task = client.GetAsync(url)
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<SolicitudProveedor>(jsonString.Result);

                     c.idSolicitudProveedor = list.idSolicitudProveedor;
                     c.ordenCompra = list.ordenCompra;
                     c.cantidadSolicitud = list.cantidadSolicitud;
                     c.valorDetalleSolicitud = list.valorDetalleSolicitud;
                     c.nombreProducto = list.nombreProducto;
                     c.nombreProveedor = list.nombreProveedor;
                     c.nombreEmpleado = list.nombreEmpleado;
                 });

                task.Wait();

                return c;
            }
            catch
            {
                return null;
            }
        }
        #endregion


        #endregion

        #region Tipo Pago

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<TipoPago> listarTipoPagos()
        {
            try
            {
                var client = new HttpClient();
                List<TipoPago> list = new List<TipoPago>();
                List<TipoPago> list2 = new List<TipoPago>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/tipoPago/listarTipoPago").Result;

                var task = client.GetAsync("api/tipoPago/listarTipoPago")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<TipoPago>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         TipoPago c = new TipoPago();

                         c.idTipoPago = item.idTipoPago;
                         c.descripcionTipoPago = item.descripcionTipoPago;

                         list2.Add(c);
                         list.Remove(c);

                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar
        #endregion


        #endregion

        #region Inventario
        #region Listar

        public List<Inventario> listarInventarios()
        {
            try
            {
                var client = new HttpClient();
                List<Inventario> list = new List<Inventario>();
                List<Inventario> list2 = new List<Inventario>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/inventario/listarInventarios").Result;

                var task = client.GetAsync("api/inventario/listarInventarios")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Inventario>>(jsonString.Result);

                     var prueba = list.ToArray();

                     foreach (var item in prueba)
                     {
                         Inventario c = new Inventario();
                         c.idInventario = item.idInventario;
                         c.nombreBodega = item.nombreBodega;
                         c.nombreSucursal = item.nombreSucursal;
                         c.nombreComuna = item.nombreComuna;
                         c.nombreRegion = item.nombreRegion;
                         c.nombreCiudad = item.nombreCiudad;
                         c.nombreProducto = item.nombreProducto;
                         c.nombreCategoria = item.nombreCategoria;
                         c.stock = item.stock;

                         list2.Add(c);
                         list.Remove(c);
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }

        #endregion
        #endregion

        #region DetalleComprobante
        
        #region Listar
        public List<DetalleComprobante> listarDetComprobantes()
        {
            try
            {
                var client = new HttpClient();
                List<DetalleComprobante> list = new List<DetalleComprobante>();
                List<DetalleComprobante> list2 = new List<DetalleComprobante>();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/detalleComprobante/listarDetalleComprobante").Result;

                var task = client.GetAsync("api/detalleComprobante/listarDetalleComprobante")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<DetalleComprobante>>(jsonString.Result);
                     var prueba = list.ToArray();
                     foreach (var item in prueba)
                     {
                         /*Comprobante c = new Comprobante();
                         c.idComprobante = item.idComprobante;
                         c.fechaEmisionComprobante = item.fechaEmisionComprobante;
                         c.idMesa = item.idMesa;
                         c.totalComprobante = item.totalComprobante;
                         c.nombreTipoPago = item.nombreTipoPago;
                         list2.Add(c);
                         list.Remove(c);*/
                     }

                 });

                task.Wait();

                return list2;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #endregion


        // Por hacer
        #region Bodegas

        #region Agregar
        #endregion

        #region Modificar
        #endregion

        #region Listar

        public List<Bodega> listarBodegas()
        {
            try
            {
                var client = new HttpClient();
                List<Bodega> list = null;
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/categoria/all").Result;

                var task = client.GetAsync("api/categoria/all")
                 .ContinueWith((taskwithresponse) =>
                 {
                     var response2 = taskwithresponse.Result;
                     var jsonString = response.Content.ReadAsStringAsync();
                     jsonString.Wait();
                     list = JsonConvert.DeserializeObject<List<Bodega>>(jsonString.Result);
                     foreach (var item in list)
                     {
                         Bodega c = new Bodega();
                         c.idBodega = item.idBodega;
                         c.idEmpleado = item.idEmpleado;
                         c.nombreBodega = item.nombreBodega;
                         c.idSucursal = item.idSucursal;
                         list.Add(c);
                     }

                 });

                task.Wait();

                return list;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Eliminar
        #endregion

        #region Buscar
        #endregion


        #endregion
    }
}