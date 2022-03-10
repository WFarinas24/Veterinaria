using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class DPersona
    {

        public void guardar(tbPersona persona)
        {
            try
            {
                using(DBContext bd = new DBContext())
                {
                    bd.tbPersonas.Add(persona);
                    bd.SaveChanges();

                    MessageBox.Show("Exito se guardó La persona"); 

                }
            }
            catch (Exception e )
            {
                MessageBox.Show("Error no se guardo" + e);

            }
        }

        public List<tbPersona> obtener()
        {

            try
            {
                using (DBContext bd = new DBContext())
                {

                    return bd.tbPersonas.ToList(); 

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se guardo" + e);

            }

            return null; 


        }
    }
}
