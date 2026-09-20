using System;

namespace DotnetLists
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 23, 45, 32, 55, 92 };
            //Assimilacao
            meuArray[0] = 12;

            Console.WriteLine(meuArray.Length);

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 3457, Nome = "Lucas" };

            Console.WriteLine("Iterando Listas");
            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }
            Console.WriteLine("Iterando Funcuonários");
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }
        }
    }
    
    public struct Funcionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
