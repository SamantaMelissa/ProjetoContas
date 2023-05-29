using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETOCONTAS
{
    public class Corrente : Conta
    {
         // ATRIBUTOS: Limite

         public double Limite {get; set;}

        //  Criando um método ToString()

        public string ToString(){
            string texto;
            // texto = "A agencia é:" + base.Agencia;
            // texto += "\nO Número é:" + base.Numero; 
            // texto += "\nO saldo é:" + base.Saldo;
            texto = base.ToString();
            texto += "\nO limite é:" + this.Limite;

           return texto;
        }
    }
}