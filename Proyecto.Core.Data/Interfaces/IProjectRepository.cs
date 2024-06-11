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
        public void DeleteProducto(Producto product);
        public List<Producto> GetProductos();
        public List<string> GetAllNames();
        public List<Categoria> GetCategorias();
        public void ModifyProduct(Producto product);
        public bool AddCategoria(Categoria categoria);
        public List<Compra> GetCompras();
        public List<Venta> GetVentas();
        public Producto GetProducto(int id);
        public void DeleteProducto(int id);
        public int GetStock(int usuarioId, int productoId);
		public void AddCompra(Compra compra);
		public void DeleteCompra(int id);
		public void AddVenta(Venta venta);
		public void DeleteVenta(int id);
        public bool ComparteUserToDB(string Username);
        public byte[] GetUsuarioHash(string Username);
        public byte[] GetUsuarioSalt(string Username);
        public bool ChangePass(string Username, byte[] Password, byte[] salt);
        public Usuario ObtainUsuario(string Username);
        public bool VerifyPassword(string Username, string Password);
        public bool CreateUser(string Username, string password);

	}
}
