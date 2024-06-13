﻿using Microsoft.EntityFrameworkCore;
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
    }
}
