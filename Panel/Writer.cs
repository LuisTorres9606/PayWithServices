using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;

namespace Presentation.Panel
{
    public class Writer
    {
        public void Escribir() {

            try
            {
                List<string> Usuario = new List<string>() { "Nombre: " + UserLoginCache.Nombre, "Apellidos"+UserLoginCache.Apellidos,"Cedula"+UserLoginCache.Cedula, "Hora de Inicio Sesión "+ DateTime.Now.ToLongDateString()};
                using (StreamWriter Write = new StreamWriter("Registro " + UserLoginCache.UserId + ".txt"))
                {
                    foreach(string read in Usuario)
                    {
                        Write.WriteLine(read);
                    }

                    Write.Close();
                } 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing Finally Block");

            }
        }
    }
}
