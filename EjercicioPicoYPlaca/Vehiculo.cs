using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPicoYPlaca
{
    class Vehiculo
    {
        public string nPlaca { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }

        public Vehiculo()
        {
            
        }

        public Vehiculo(String NPlaca, String Fecha, String Hora)
        {
            this.nPlaca = NPlaca;
            this.fecha = Fecha;
            this.hora = Hora;
        }
        
        public int GetHoraSinPuntos()
        {
            return Convert.ToInt32(hora.Remove(2,1));
        }

        public Boolean ComprobarPlaca()
        {
            Boolean ok = false;
            if (nPlaca.Length >= 6 && nPlaca.Length <= 7)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (Char.IsLetter(nPlaca, i) == false)
                    {
                        ok = false;
                        break;
                    }
                    ok = true;
                }
                if (ok)
                {
                    for (int i = 3; i < nPlaca.Length; i++)
                    {
                        if (Char.IsDigit(nPlaca, i) == false)
                        {
                            ok = false;
                            break;
                        }
                        ok = true;
                    }
                   
                }

            }
            return ok;
        }

        public Boolean ComprobarHora()
        {
            Boolean ok = false;

            string[] tiempo = hora.Trim().Split(':');
            if (tiempo[0].Equals("") || tiempo[1].Equals(""))
            { ok = false; }
            else { 

                if (Convert.ToInt32(tiempo[0]) > 23 || Convert.ToInt32(tiempo[1]) > 59)
                    ok = false;
                else
                    ok = true;
            }
                return ok;
        } 
    }
}
