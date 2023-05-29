// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, alunosssss!!!");

using PROJETOCONTAS;

// Instanciando a classe corrente:

Corrente obj_cc = new Corrente();

obj_cc.Agencia = "777";
obj_cc.Limite = 10000;
obj_cc.Numero = "1234";
obj_cc.Saldo = 2;

Console.WriteLine(obj_cc.ToString());

Poupanca obj_pp = new Poupanca();

obj_pp.Agencia = "888";
obj_pp.Aniversario = 17;
obj_pp.Numero = "00000";
obj_pp.Saldo = 2000;

Console.WriteLine(obj_pp.ToString());

// // concatenação de infomações +
// Console.WriteLine("A agencia da sua conta corrente é: " + obj_cc.Agencia);
// Console.WriteLine("O limite da sua conta corrente é: " + obj_cc.Limite);
// Console.WriteLine("O saldo da sua conta corrente é: " + obj_cc.Saldo);

// Corrente obj2_cc = new Corrente();

// obj2_cc.Agencia = "888";
// obj2_cc.Limite = 20000;
// obj2_cc.Numero = "34567";
// obj2_cc.Saldo = 500;

// Console.WriteLine("A agendia da sua conta corrente 2 é:" + obj2_cc.Agencia);
// Console.WriteLine("Agora, seu saldo é de: " + obj2_cc.Saldo);