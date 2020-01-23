using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Olho;


namespace _Rosto
{
    public class Rosto
    {
        public Olho OlhoDireito { get; set; }
        public Olho OlhoEsquerdo { get; set; }

        public string Estado { get; set; }

        public void Sorrir()
        {
            OlhoDireito.AbrirOlho();
            OlhoEsquerdo.AbrirOlho();
            Estado = "(___)";
        }

        public void Chorar()
        {
            OlhoDireito.FecharOlho();
            OlhoEsquerdo.FecharOlho();
            Estado = "-----";
        }

        public void Desconfiar()
        {
            OlhoDireito.AbrirOlho();
            OlhoEsquerdo.FecharOlho();
            Estado = "(___";
        }

        public Rosto() 
        {
           OlhoDireito = new Olho();             
           OlhoEsquerdo = new Olho();

            Sorrir();
        }
    }
}
