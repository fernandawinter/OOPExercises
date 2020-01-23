using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Olho                        // a ideia é criar um programa que controla as emoções do robô
{
   public class Olho  
    {
        public string Cor { get; set; }
        public string Estado { get; set; }

        public void AbrirOlho()
        {
            Estado = "O";
        }

        public void FecharOlho()
        {
            Estado = "___";
        }

        public void PiscarOlhos()
        {
            FecharOlho();
            AbrirOlho();
        }

        public Olho() 
        {
            Estado = "___";
            Cor = "Castanho";
        }

    }
}
