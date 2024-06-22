using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Data.Interfaces
{
    public interface IProjectRepository
    {
        public void AddProducto(Producto product); 
        public void UpdateCompra(Compra compra);
        public void UpdateVenta(Venta venta);
        public void DeleteProducto(Producto product);
        public List<Producto> GetProductos();
        public List<string> GetAllNames();
        public List<Categoria> GetCategorias();
        public void ModifyProduct(Producto product);
        public bool AddCategoria(Categoria categoria);
        public List<Compra> GetCompras(int usuarioId);
        public List<Compra> FiltrarCompraFecha(string search, List<Compra> unfilteredCompras);
        public List<Compra> FiltrarCompraMasComprado(int usuarioId, List<Compra> unfilteredCompras);
        public List<Venta> GetVentas(int userId);
        public int GetVentaProducto(int userId, int productoId);
        public Producto GetProducto(int id);
        public void DeleteProducto(int id);
        public int GetStock(int usuarioId, int productoId);
        public int GetStock(int productoId);
        public void AddCompra(Compra compra);
        public void DeleteCompra(int id);
        public void AddVenta(Venta venta);
        public void DeleteVenta(int id);
        public List<Producto> GetProductosByCategoria(int categoriaId);
        public bool CompareUserToDB(string Username);
        public byte[] GetUsuarioHash(string Username);
        public byte[] GetUsuarioSalt(string Username);
        public bool ChangePass(Usuario usuario);
        public Usuario ObtainUsuario(string Username);
        public bool CreateUser(string Username, byte[] hashPassword, byte[] salt);
        public Compra GetCompraById(int id);
        public Venta GetVentaById(int id);


    }
}
