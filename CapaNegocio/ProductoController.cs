using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{

    public class ProductoController
    {
        ProductoDataAccess data = new ProductoDataAccess();

        public DataTable ObtenerProductos()
        {
            DataTable dt = new DataTable();
            dt = data.ObtnerProductos();
            return dt;
        }

        public bool InsertarProductos(Producto producto)
        {
            bool succes = true;
            succes = data.InsertarProducto(producto);
            return succes;
        }

        public bool ActualizarProductos(Producto producto)
        {
            bool succes = true;
            data.ActualizarProducto(producto);
            return succes;
        }

        public DataTable ObtnerProductosByCategoria(int ProductoCategoriaId, string nombre)
        {
            DataTable dt = new DataTable();
            dt = data.ObtnerProductosByCategoria(ProductoCategoriaId, nombre);
            return dt;
        }

        public bool EliminarProducto(Guid productoId)
        {
            bool succes = true;
            data.EliminarProducto(productoId);
            return succes;
        }

        public DataTable ObtnerCategoria()
        {
            DataTable dt = new DataTable();
            dt = data.ObtnerCategoria();
            return dt;
        }

        public DataTable ObtenerProveedor()
        {
            DataTable dt = new DataTable();
            dt = data.ObtenerProveedor();
            return dt;
        }

        public bool InsertarProveedor(ProveedorModel proveedorModel)
        {
            bool succes = true;
            succes = data.InsertarProveedor(proveedorModel);
            return succes;
        }

        public bool ActualizarProveedor(ProveedorModel proveedorModel)
        {
            bool succes = true;
            data.ActualizarProveedor(proveedorModel);
            return succes;
        }
    }
}
