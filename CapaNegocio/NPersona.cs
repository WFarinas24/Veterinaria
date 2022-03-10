using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NPersona
    {

        public void guardar(tbPersona persona)
        {
            new DPersona().guardar(persona);

        }

        public List<tbPersona> obtener()
        {
            return new DPersona().obtener();


        }
    }

}
