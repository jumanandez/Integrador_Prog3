using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data.Interfaces;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
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

        public (List<Compra>, List<Venta>) ReturnVentasCompras(int userID)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                List<Compra> Compras = dbcontext.Compras.Where(p => p.UsuarioId == userID).ToList();
                List<Venta> Ventas = dbcontext.Ventas.Where(p => p.UsuarioId == userID).ToList();

                return (Compras, Ventas);  
            }
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
                                               .Include(p => p.Compras).ThenInclude(c => c.Usuario)
                                               .Include(p => p.Venta).ThenInclude(v => v.Usuario).ToList();
            }
            return productos;
        }
        public List<Producto> GetProductosWeb()
        {
            var productos = new List<Producto>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                productos = dbcontext.Productos.Where(c => c.Habilitado == true)
                                               .Include(p => p.Categoria)
                                               .Include(p => p.Compras).ThenInclude(c => c.Usuario)
                                               .Include(p => p.Venta).ThenInclude(v => v.Usuario)
                                               .ToList();
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

        public int GetStock(int productoId)
        {
            int stock = 0;
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                var compras = (from c in dbcontext.Compras
                               where c.ProductoId == productoId
                               select c.Cantidad).Sum();

                int ventas = (from v in dbcontext.Ventas
                              where v.ProductoId == productoId
                              select v.Cantidad).Sum();

                stock = compras - ventas;
            }
            return stock;
        }

        public List<Producto> GetProductosByCategoria(int categoriaId)
        {
            var productos = new List<Producto>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                productos = (from p in dbcontext.Productos
                             where p.CategoriaId == categoriaId
                             where p.Habilitado == true
                             select p).ToList();
            }
            return productos;
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
        public void ModifyProduct(Producto product, int categoriaId)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                var producto = dbcontext.Productos.Find(product.ProductoId);


                var newCategoria = dbcontext.Categoria.Find(categoriaId);

                producto.CategoriaId = categoriaId;
                producto.Nombre = product.Nombre;
                producto.Habilitado = product.Habilitado;

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

        #region Region Compras
        public List<Compra> GetCompras(int usuarioId)
        {
            var compras = new List<Compra>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                compras = dbcontext.Compras.Where(c => c.UsuarioId == usuarioId)
                                           .Include(c => c.Producto)
                                           .Include(c => c.Usuario)
                                           .OrderByDescending(c => c.Fecha).ToList();

                //Paginado 
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

        public void UpdateCompra(Compra compra)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Update(compra);
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

        public Compra GetCompraById(int id)
        {
            var compra = new Compra();
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                compra = dbcontext.Compras.Find(id);
            }

            return compra;
        }

        public List<Compra> FiltrarCompraFecha(string search, List<Compra> unfilteredCompras)
        {
            var compras = (from c in unfilteredCompras
                           where c.Fecha.Date == DateTime.Parse(search)
                           select c).ToList();
            return compras;
        }

        public List<Compra> FiltrarCompraMasComprado(int usuarioId, List<Compra> unfilteredCompras)
        {
            var compras = unfilteredCompras.GroupBy(c => c.ProductoId)
                                           .Select(g => new Compra
                                           {
                                               ProductoId = g.Key,
                                               Producto = g.First().Producto,
                                               UsuarioId = g.First().UsuarioId,
                                               Cantidad = g.Sum(c => c.Cantidad),
                                           })
                                           .OrderByDescending(c => c.Cantidad)
                                           .ToList();
            return compras;
        }
        #endregion

        #region Region Ventas
        public List<Venta> GetVentas(int userId)
        {
            var ventas = new List<Venta>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {

                ventas = dbcontext.Ventas.Where(v => v.UsuarioId == userId)
                                           .Include(v => v.Producto)
                                           .Include(v => v.Usuario)
                                           .OrderByDescending(v => v.Fecha).ToList();
            }
            return ventas;
        }

        public int GetVentaProducto(int userId, int productoId)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {

                int ventaproducto = (from v in dbcontext.Ventas
                                     where v.ProductoId == productoId && v.UsuarioId == userId
                                     select v.Cantidad).Sum();
                return ventaproducto;
            }
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

        public Venta GetVentaById(int id)
        {
            var venta = new Venta();
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                venta = dbcontext.Ventas.Find(id);
            }

            return venta;
        }
        public void UpdateVenta(Venta venta)
        {
            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                dbcontext.Update(venta);
                dbcontext.SaveChanges();

            }
        }

        public List<Venta> FiltrarVentaFecha(string search, List<Venta> unfilteredVentas)
        {
            var ventas = (from c in unfilteredVentas
                          where c.Fecha.Date == DateTime.Parse(search)
                          select c).ToList();

            return ventas;
        }

        #endregion

        #region Region Categoria
        public List<Categoria> GetCategorias()
        {
            var categorias = new List<Categoria>();

            using (var dbcontext = new IntegradorProg3Context(_config))
            {
                categorias = dbcontext.Categoria.
                                                 Include(p => p.Productos).ToList();
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
                var User = dbcontext.Usuarios
                    .Where(b => b.Nombre == Username)
                    .Include(c => c.Compras)
                        .ThenInclude(compra => compra.Producto)
                    .Include(c => c.Venta)
                    .ThenInclude(venta => venta.Producto)
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
        public List<Usuario> GetAllUsuarios()
        {
                using (var _dbContext = new IntegradorProg3Context(_config))
                {
                    return _dbContext.Usuarios.Include(u => u.Compras).
                                               ThenInclude(c => c.Producto).
                                               Include(u => u.Venta).
                                               ThenInclude(v => v.Producto).ToList();
                }
           
        }
        #endregion
    }
}
