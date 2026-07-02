using System.ComponentModel;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

class Menuselecao
{
    public static void Main()
    {

        int opcao = 1;
        while (opcao != 3)
        {

            
            Console.WriteLine($"Escolha uma opcao 1- cadastrar");
        Console.WriteLine($"Escolha uma opcao 2- Listar");
        Console.WriteLine($"Escolha uma opcao 3- Sair ");

        
            string escolha = Console.ReadLine();
        int.TryParse(escolha, out opcao );
        

        
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastrar aluno: ");
                        break;
                    case 2:
                        Console.WriteLine("Listar alunos: ");
                        break;
                    case 3:
                        Console.WriteLine("Encerrando programa");
                        break;

                }
            
        }
    }

}

    







        


