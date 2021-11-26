using System;
using System.Collections.Generic;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
for (int i = 0; i < 10; i++) //tvariável, teste lógico e incremento.
        Console.WriteLine($"O valor de i é:{i} ");
        //i++ de um em um i+=2 de 2 em 2.

//while (true)
//Console.WriteLine($"Mensagem de lup infinito. ");

int contador = 0;
  while (contador < 30)
  {
Console.WriteLine($"O contador do while é: {contador}");
contador+=3;
  }
do 
{
Console.WriteLine($"O contador do  DoWhile é: {contador}");
contador++;
}
while (contador <10);


 List<string> listaNomes = new();
 listaNomes.Add("Luciane Molina");
 listaNomes.Add("Paulo Ponciano");
        listaNomes.Add("Pedro Dias");
        listaNomes.Add("Suzana Portal");
        foreach(string nome in listaNomes)
        Console.WriteLine($"O nome da lista é: {nome}");
        
 
 
        }
    }
}