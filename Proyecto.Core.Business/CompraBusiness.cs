using Microsoft.EntityFrameworkCore;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Data;
using Proyecto.Core.Data.Interfaces;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business
{
    public class CompraBusiness : ICompraBusiness
    {
        private readonly IProjectRepository _projectRepository;

        public CompraBusiness(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void AddCompra(Compra compra)
        {
            _projectRepository.AddCompra(compra);
        }

        public List<Compra> GetCompras(int usuarioId)
        {
            return _projectRepository.GetCompras(usuarioId);
        }

        public void DeleteCompra(int id)
        {
            _projectRepository.DeleteCompra(id);
        }

        public bool VerificarFecha(DateTime fecha)
        {
            var fechaActual = DateTime.Now;
            var fechaLimitePasada = fechaActual.AddDays(-7);
            var fechaLimiteFutura = fechaActual;

            if (fecha < fechaLimitePasada || fecha > fechaLimiteFutura)
            {
                return true;
            }

            return false;
        }

        public Paginado<Compra> GetComprasPaginadas(int pagina, int itemsPorPagina, int usuarioId, List<Compra>? compras)
        {
            List<Compra> comprasList = compras ?? _projectRepository.GetCompras(usuarioId);

            int totalCompras = comprasList.Count;

            List<Compra> comprasPaginadas = comprasList
                .Skip((pagina - 1) * itemsPorPagina)
                .Take(itemsPorPagina)
                .ToList();

            return new Paginado<Compra>()
            {
                Items = comprasPaginadas,
                PaginaActual = pagina,
                ItemsPorPagina = itemsPorPagina,
                TotalPaginas = (int)Math.Ceiling(totalCompras / (double)itemsPorPagina),
                HasPreviousPage = pagina > 1,
                HasNextPage = pagina < (int)Math.Ceiling(totalCompras / (double)itemsPorPagina),
            };
        }

        public Compra GetCompraById(int id)
        {
            return _projectRepository.GetCompraById(id);
        }

        public void UpdateCompra(Compra compra)
        {
            _projectRepository.UpdateCompra(compra);
        }

        public List<Compra> OptionSelectFilter(string search, int selectOption, int userId, List<Compra>? comprasList)
        {
            List<Compra> comprasFiltradas = comprasList ?? _projectRepository.GetCompras(userId);

            switch (selectOption)
            {
                case 1:
                    { 
                        comprasFiltradas = _projectRepository.FiltrarCompraFecha(search, comprasFiltradas);
                        break;
                    }
                case 2:
                    {
                        comprasFiltradas = _projectRepository.FiltrarCompraMasComprado(userId, comprasFiltradas);
                        break;
                    }
            }
            return comprasFiltradas;
        }

    }
}
