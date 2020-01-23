using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO                        // a ideia é criar um programa que controlaria um robô humanóide
{
    class Olho   // primeiro, criar a classe
    {
        public string Cor { get; set; }
        public string Estado { get; set; }

        public void AbrirOlho()
        {
            Estado = "Aberto";
        }

        public void FecharOlho()
        {
            Estado = "Fechado";
        }

        public void PiscarOlhos()
        {
            FecharOlho();
            AbrirOlho();
        }

        public Olho()
        {
            Estado = "Fechado";
            Cor = "Castanho";
        }

    }
}
