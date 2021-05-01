/*https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/get
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/using-properties*/

exemplo a seguir implementa Nome como uma propriedade autoimplementada.

class Pessoa
{
    public string Nome { get; set; }//isto é uma propriedade autoimplementada
    //note que a propriedade inicia seu nome com UpperCase, e tambem desse modo nao é possivel atribuir limitacoes para as atribuicoes ou leitura;
     
     
     
     private int _anoNascimento;//isto é um campo
     public double AnoNascimento//isto é uma propriedade
     {
         get { return _anoNascimento; }
         set { _anoNascimento = value; }
     }
     
     
    private int _month = 1;  // Backing store

    public int Mes
    {
        get => _mes;
        set
        {
            if ((value > 0) && (value < 13))
            {
                _mes = value;/*value é o valor passado atraves da atribuicao 
                            EX: 
                             Pessoa leo=new Pessoa();
                             leo.Mes=5;
                             value teria o valor 5 guardado;*/
            }
        }
    }
}
}
