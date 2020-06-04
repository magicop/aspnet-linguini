using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebLinguini
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            
            #region Login

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login" }
            );

            routes.MapRoute(
                name: "Index",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index"}
            );
            #endregion

            #region Categorias
            routes.MapRoute(
                name: "AgregarCategoria",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Categoria", action = "FormAgregar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ListarCategoria",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Categoria", action = "Listar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EditarCategoria",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Categoria", action = "FormEditar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EliminarCategoria",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Categoria", action = "FormEliminar", id = UrlParameter.Optional }
            );
            #endregion

            #region Carta
            routes.MapRoute(
                name: "AgregarCarta",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Carta", action = "FormAgregar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ListarCarta",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Carta", action = "Listar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EditarCartaa",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Carta", action = "FormEditar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EliminarCarta",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Carta", action = "FormEliminar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "BuscarCarta",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Carta", action = "FormBuscar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "BuscarCarta2",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Carta", action = "Buscar", id = UrlParameter.Optional }
            );
            #endregion

            #region Usuario
            routes.MapRoute(
                name: "BuscarUsuario",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Usuario", action = "Buscar" }
            );
            #endregion

            #region Empleado
            routes.MapRoute(
                name: "ListarEmpleados",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Empleado", action = "Listar", id = UrlParameter.Optional }
            );
            #endregion

            #region Estado
            routes.MapRoute(
                name: "ListarEstados",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Estado", action = "Listar", id = UrlParameter.Optional }
            );
            #endregion

            #region Logs
            routes.MapRoute(
                name: "ListarLogs",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Log", action = "Listar", id = UrlParameter.Optional }
            );
            #endregion

            #region Mesa
            routes.MapRoute(
                name: "ListarMesas",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Mesa", action = "Listar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "BuscarMesa",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Mesa", action = "Buscar", id = UrlParameter.Optional }
            );
            #endregion

            #region PedidoProveedor
            routes.MapRoute(
                name: "ListarPedidoProveedor",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "PedidoProveedor", action = "Listasr", id = UrlParameter.Optional }
            );
            #endregion

            #region Producto
            routes.MapRoute(
                name: "ListarProductos",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Producto", action = "Listar", id = UrlParameter.Optional }
            );
            #endregion

            #region Proovedor
            routes.MapRoute(
                name: "ListarProveedores",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Proveedor", action = "Listar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "BuscarProveedores",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Proveedor", action = "Buscar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "FormBuscarProveedores",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Proveedor", action = "FormBuscar", id = UrlParameter.Optional }
            );
            #endregion

            #region Reserva
            routes.MapRoute(
                name: "ListarReservas",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Reserva", action = "Listar", id = UrlParameter.Optional }
            );
            #endregion

            #region Rol
            routes.MapRoute(
                name: "ListarRoles",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Rol", action = "Listar", id = UrlParameter.Optional }
            );
            #endregion

            #region SolicitudProveedor
            routes.MapRoute(
                name: "ListarSolicitudProveedor",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SolicitudProveedor", action = "Listar", id = UrlParameter.Optional }
            );
            #endregion

            #region TipoPago
            routes.MapRoute(
                name: "ListarTipoPagos",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "TipoPago", action = "Listar", id = UrlParameter.Optional }
            );
            #endregion

            #region TipoPago
            routes.MapRoute(
                name: "FormBuscarComprobante",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Comprobante", action = "FormBuscar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "BuscarComprobante",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Comprobante", action = "Buscar", id = UrlParameter.Optional }
            );
            #endregion
        }
    }
}
