﻿using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business.Interfaces
{
    public interface IVentaBusiness
    {
        public void AddVenta(Venta venta);

        public void DeleteVenta(int id);

        public List<Venta> GetVentas();
  
    }
}