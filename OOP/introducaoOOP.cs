/*Introducao à OOP em C# */
using System;

namespace IntroducaoOO{
	class Pessoa
	{
		public string nome;
		public string sobrenome;
		public int anoNascimento;
		public string NomeCompleto(){
		return this.nome+" "+this.sobrenome;
		}
		public void Cumprimentar(){
			Console.WriteLine($"Olá meu nome é {NomeCompleto()}");	
		}
		
	}
    public class Program
    {
	    public static void Main()
	    {
        	/*Primeira forma de declarar e atribuir valores aos atributos
            OBS: OS ATRIBUTOS ESTAO PUBLICOS NO MOMENTO*/
            Pessoa p1=new Pessoa();
            p1.nome="Leo";
            p1.sobrenome="Mateus";
            p1.anoNascimento=1999;
            p1.Cumprimentar();
	    	/*Segunda forma de declarar e atribuir valores aos atributos*/
            Pessoa p2 = new Pessoa(){
            nome="James",
            sobrenome="Bond",
            anoNascimento=1990
            };
            p2.Cumprimentar();
	    
        } 
        
}
}

