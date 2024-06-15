using Microsoft.EntityFrameworkCore;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data.Interfaces;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Data
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly Config _config;

        public ProjectRepository(Config config)
        {
            _config = config;
        }

        #region Region Producto
        public void AddProducto(Producto product)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Add(product);
                dbcontext.SaveChanges();
            }
        }

        public Producto GetProducto(int id)
        {
            var producto = new Producto();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                producto = dbcontext.Productos.Find(id);
            }
            return producto;
        }

        public List<Producto> GetProductos()
        {
            var productos = new List<Producto>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                productos = dbcontext.Productos.Include(p => p.Categoria)
                                               .Include(p => p.Compras)
                                               .Include(p => p.Venta).ToList();
            }
            return productos;
        }
        public int GetStock(int usuarioId, int productoId)
        {
            int stock = 0;
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                var compras = (from c in dbcontext.Compras
                               where c.ProductoId == productoId && c.UsuarioId == usuarioId
                               select c.Cantidad).Sum();

                int ventas = (from v in dbcontext.Ventas
                              where v.ProductoId == productoId && v.UsuarioId == usuarioId
                              select v.Cantidad).Sum();

                stock = compras - ventas;
            }
            return stock;
        }

        public void DeleteProducto(int id)
        {
            var producto = new Producto();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                producto = dbcontext.Productos.Find(id);
                dbcontext.Remove(producto);
                dbcontext.SaveChanges();
            }
        }
        public void DeleteProducto(Producto producto)
        {

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Remove(producto);
                dbcontext.SaveChanges();
            }
        }
        public void ModifyProduct(Producto product)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Update(product);
                dbcontext.SaveChanges();
            }
        }

        #endregion

        #region Region Compras
        public List<Compra> GetCompras()
        {
            var compras = new List<Compra>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                compras = dbcontext.Compras.Include(c => c.Producto).Include(c => c.Usuario).ToList();
            }
            return compras;
        }


        public void AddCompra(Compra compra)
        {

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Add(compra);

                dbcontext.SaveChanges();
            }

        }

        public void DeleteCompra(int id)
        {
            var compra = new Compra();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                compra = dbcontext.Compras.Find(id);
                dbcontext.Remove(compra);
                dbcontext.SaveChanges();
            }
        }
        #endregion

        #region Region Ventas
        public List<Venta> GetVentas()
        {
            var ventas = new List<Venta>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                ventas = dbcontext.Ventas.Include(v => v.Producto).Include(v => v.Usuario).ToList();
            }
            return ventas;
        }

        public void AddVenta(Venta venta)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Add(venta);
                dbcontext.SaveChanges();
            }
        }
        public void DeleteVenta(int id)
        {
            var venta = new Venta();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                venta = dbcontext.Ventas.Find(id);
                dbcontext.Remove(venta);
                dbcontext.SaveChanges();
            }
        }

        public List<string> GetAllNames()
        {
            var productos = new List<Producto>();
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                List<string> names = dbcontext.Productos
                                                        .Select(p => p.Nombre)
                                                        .ToList();
                return names;
            }
        }
        #endregion

        #region Region Categoria
        public List<Categoria> GetCategorias()
        {
            var categorias = new List<Categoria>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                categorias = dbcontext.Categoria.ToList();
            }

            return categorias;
        }

        public bool AddCategoria(Categoria categoria)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Categoria.Add(categoria);
                dbcontext.SaveChanges();
            }
            return true;
        }

        #endregion

        #region Region Usuario
        public bool CompareUserToDB(string Username)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                var UserExist = dbcontext.Usuarios.Any(b => b.Nombre == Username);
                return UserExist;
            }
        }
        public byte[] GetUsuarioHash(string Username)
        {
            byte[] hash;
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                var User = dbcontext.Usuarios.Where(b => b.Nombre == Username).FirstOrDefault();
                hash = User.HashPassword;
            }
            return hash;
        }
        public byte[] GetUsuarioSalt(string Username)
        {
            byte[] salt;
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                var User = dbcontext.Usuarios.Where(b => b.Nombre == Username).FirstOrDefault();
                salt = User.Salt;
            }
            return salt;
        }

        public bool ChangePass(Usuario usuario) 
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Update(usuario);
                dbcontext.SaveChanges();
                 return true;
            }
        }
        public Usuario ObtainUsuario(string Username)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                //var User = dbcontext.Usuarios.Where(b => b.Nombre == Username).FirstOrDefault();
                var User = dbcontext.Usuarios
                    .Where(b => b.Nombre == Username)
                    .Include(c => c.Compras)
                        .ThenInclude(compra => compra.Producto)
                    .Include(c => c.Venta)
                    .FirstOrDefault();

                return User;
            }
        }
        public bool CreateUser(string Username, byte[] hashedPassword, byte[] saltBytes)
        {
            var user = new Usuario
            {
                Nombre = Username,
                HashPassword = hashedPassword,
                Salt = saltBytes
            };

            using (var _dbContext = new IntegradorProg3Context(_config))
            {
                _dbContext.Usuarios.Add(user);
                _dbContext.SaveChanges();
            }
            return true;
        }
		#endregion
	}
}
