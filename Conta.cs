using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETOCONTAS
{
    public class Conta
    {
        // ATRIBUTOS: agencia, numero e saldo

        public string Agencia {set; get;}
        public string Numero {get; set;}
        public double Saldo {get; set;}

        // Metodo:
        public string ToString(){
            string texto;
            texto = "A agencia é:" + this.Agencia;
            texto += "\nO número é:" + this.Numero;
            texto += "\nO Saldo é:" + this.Saldo;

            return texto;
        }
    }
}