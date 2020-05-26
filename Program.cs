using System;

namespace CadastroAluno
{
    class Program
    {
        static void Main(string[] args)
        {
           aluno hitoshi = new aluno();
           hitoshi.nome = "Hitoshi";
           hitoshi.idade = 16;
           hitoshi.bolsista = false;
           hitoshi.valorMensalidade = 2000f;
           hitoshi.mediaFinal = 9.7f;

           Console.WriteLine(hitoshi.verMediaFinal());
           Console.WriteLine(hitoshi.verMensalidade());

        }
    }
}
