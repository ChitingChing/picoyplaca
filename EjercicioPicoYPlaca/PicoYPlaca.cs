using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPicoYPlaca
{
    class PicoYPlaca
    {
        private int[,] horarios = new int[2, 2] { { 0700, 0930 }, { 1600, 1930 } };
        private String[,] restricciones = new String[5, 2] { { "1", "1,2" }, { "2", "3,4" }, { "3", "5,6" }, { "4", "7,8" }, { "5", "9,0" } };

        public PicoYPlaca() { }
        public String PuedeCircular(Vehiculo m)
        {
            string msj="Si puedes circular en tu carro";
            if(VerificarHorario(m))
            {
                if (VerificarPlaca(m))
                    msj= "No puedes circular en tu carro!!";
            }
            

            return msj;
        }

        private Boolean VerificarHorario(Vehiculo m)
        {
            Boolean horaPP =false;
            if ((m.GetHoraSinPuntos() >= horarios[0, 0] && m.GetHoraSinPuntos() <= horarios[0, 1]) || ((m.GetHoraSinPuntos() >= horarios[1, 0] && m.GetHoraSinPuntos() <= horarios[1, 1])))
            {
                horaPP = true;                
            }
            
            return horaPP;
        }
        private Boolean VerificarPlaca(Vehiculo m)
        {
           DateTime f= Convert.ToDateTime(m.fecha);
            int i = 0;
            int dia = (int)f.DayOfWeek;
            while (dia!= Convert.ToInt32( restricciones[i,0])){
                i++;
            }
            string[] ultimosDig = restricciones[i, 1].ToString().Split(',');
            if (m.nPlaca.Substring(m.nPlaca.Length - 1).Equals(ultimosDig[0]) || m.nPlaca.Substring(m.nPlaca.Length - 1).Equals(ultimosDig[1]))
                return true;
            else
                return false;
        }
    }
}
