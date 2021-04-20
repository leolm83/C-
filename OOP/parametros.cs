using System;
namespace IntroducaoOO{
/*passagem de parametros por VALOR e por REFERENCIA*/
	public class Metodos
    {
   	 	public void exibeVariavel(string v){
			Console.WriteLine($"Valor da Atual da Variavel :{v}");	
            }
    	public void PassagemPorValor(int valor){
			valor+=10;
            exibeVariavel(Convert.ToString(valor));	
        }
    	public void PassagemPorReferencia(ref int valor){
			valor+=10;
            exibeVariavel(Convert.ToString(valor));	
        }	
    
    }
    public class Program
    {
        	
	    public static void Main()
	    {
	    	/*Introducao à OOP em C# */
            int valor1=0;
            int valor2=0;
            Metodos m= new Metodos();
            m.PassagemPorValor(valor1);
            m.PassagemPorReferencia(ref valor2);
	    	Console.WriteLine("Hello World");
	    } 
}
}
