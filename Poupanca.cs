using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETOCONTAS
{
    public class Poupanca : Conta
    {
         // ATRIBUTO: Aniversario

         public int Aniversario {get; set;}

          public string ToString(){
            string texto;
            // texto = "A agencia é:" + base.Agencia;
            // texto += "\nO Número é:" + base.Numero; 
            // texto += "\nO saldo é:" + base.Saldo;
            texto = base.ToString();
            texto += "\nO aniversario é:" + this.Aniversario;

           return texto;
        }
    }
}