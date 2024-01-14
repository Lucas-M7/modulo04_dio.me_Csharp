using classe_abstrata.Models;




// Classe Object

List<object> listaDeObjeto = new List<object>();
listaDeObjeto.Add("Hello, World! My Name is Michael Jordan");
listaDeObjeto.Add(23);


//Boxing and Unboxing

int numero = 23;
object objeto = numero; //Boxing
int novoNumero = (int)objeto; //Unboxing

object qualquerCoisa = "It's a string";
qualquerCoisa = 23; //Now is a number

string texto1 = "Hello";
string texto2 = "Hello";
bool saoIguais = texto1 == texto2; //true (equal content, referências diferentes)















//  Corrente conta = new Corrente();
//  conta.Creditar(500);
//  conta.ExibirSaldo();


// ClasseSelada classeSelada = new ClasseSelada();
// classeSelada.MetodoNormal();
// classeSelada.MetodoSelado();