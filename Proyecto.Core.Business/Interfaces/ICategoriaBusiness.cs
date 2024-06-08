using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business.Interfaces
{
    public interface ICatergoriaBusiness
    {
        public List<Categoria> GetAll();
        public bool Add(Categoria categoriaNueva);
    }
}
