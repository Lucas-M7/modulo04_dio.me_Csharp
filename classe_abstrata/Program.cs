using classe_abstrata.Models;
using classe_abstrata.Interfaces;

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 3));



























// object objeto = "It's a object";

// //Métodos da Classe Object
// Console.WriteLine("ToString(): " + objeto.ToString());
// Console.WriteLine("GetHasCode(): " + objeto.GetHashCode());

// //Comparação de Referência
// object outroObjeto = "It's other object";
// Console.WriteLine("Comparação de referência: " + (objeto == outroObjeto));

// //Pode ser usado como tipo genérico
// var listaDeObjetos = new System.Collections.Generic.List<object>();
// listaDeObjetos.Add(23);
// listaDeObjetos.Add("Hello");

// //Unboxing
// int numero = (int)listaDeObjetos[0];




























// Classe Object

// List<object> listaDeObjeto = new List<object>();
// listaDeObjeto.Add("Hello, World! My Name is Michael Jordan");
// listaDeObjeto.Add(23);


// //Boxing and Unboxing

// int numero = 23;
// object objeto = numero; //Boxing
// int novoNumero = (int)objeto; //Unboxing

// object qualquerCoisa = "It's a string";
// qualquerCoisa = 23; //Now is a number

// string texto1 = "Hello";
// string texto2 = "Hello";
// bool saoIguais = texto1 == texto2; //true (equal content, referências diferentes)
















//  Corrente conta = new Corrente();
//  conta.Creditar(500);
//  conta.ExibirSaldo();


// ClasseSelada classeSelada = new ClasseSelada();
// classeSelada.MetodoNormal();
// classeSelada.MetodoSelado();