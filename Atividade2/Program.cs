using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;


class Aluno
{
    public string Nome;
    public double Media;
}


class Menuselecao
{
    public static void Main()
    {
      List<Aluno> alunos = new List<Aluno>();
        
        

        int opcao = 1;
        while (opcao != 3)
        {

            
            Console.WriteLine($"Escolha uma opcao 1- cadastrar");
        Console.WriteLine($"Escolha uma opcao 2- Listar");
        Console.WriteLine($"Escolha uma opcao 3- Sair ");

        
            string escolha = Console.ReadLine();
        int.TryParse(escolha, out opcao );

            switch 
                (opcao)
            {

                case 1:
                    Console.WriteLine("Cadastrar aluno: ");

                    string Nome = Console.ReadLine();
                    Console.WriteLine($"Media de {Nome}:");
                    string aluno = Console.ReadLine();

                    double.TryParse(aluno, out double Media);
                    var aluno1 = new Aluno();
                    aluno1.Nome = Nome;
                    aluno1.Media = Media;

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

    







        


