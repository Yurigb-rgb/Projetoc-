using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml;


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
        while (opcao != 6)
        {

            
            Console.WriteLine($"Escolha uma opcao 1- cadastrar");
        Console.WriteLine($"Escolha uma opcao 2- Listar");
        Console.WriteLine($"Escolha uma opcao 3- buscar aluno ");
        Console.WriteLine($"Escolha uma opcao 4- Remover aluno ");
        Console.WriteLine($"Escolha uma opcao 5- Alterar média ");
        Console.WriteLine($"Escolha uma opcao 6- Sair ");

        
            string escolha = Console.ReadLine();
        int.TryParse(escolha, out opcao );

            switch
                (opcao)
            {

                case 1:
                    Console.WriteLine("Cadastrar aluno: ");
                    Console.Write("Nome: ");

                    string Nome = Console.ReadLine();
                    Console.Write($"Media de {Nome}:");
                    string aluno = Console.ReadLine();

                    double.TryParse(aluno, out double Media);
                    var aluno1 = new Aluno();
                    aluno1.Nome = Nome;
                    aluno1.Media = Media;
                    alunos.Add(aluno1);

                    break;
                case 2:
                    Console.WriteLine("Listar alunos: ");
                    foreach (var item in alunos)
                    {
                        Console.WriteLine("Nome:" + item.Nome);
                        Console.WriteLine("Media:" + item.Media);
                    }

                    break;
                case 3:
                    Console.WriteLine("Buscar aluno: ");
                    string buscarAluno = Console.ReadLine();

                    foreach (var item in alunos)
                    {
                        if (item.Nome == buscarAluno)
                        {
                            Console.WriteLine("Nome:" + item.Nome);
                            Console.WriteLine("Media:" + item.Media);
                        }  
                    }
                    break;

                case 4:
                    Console.Write("Remover aluno: ");
                    string removerAluno = Console.ReadLine();

                    Aluno alunoRemover = null;
                    foreach(var item in alunos) 
                    {
                        if (item.Nome == removerAluno)
                        {
                            alunoRemover = item;

                        }

                    }
                    if (alunoRemover != null)
                    {
                        alunos.Remove(alunoRemover);
                        Console.WriteLine("Aluno removido com sucesso!");

                    }
                    else 
                    {
                        Console.WriteLine("Aluno não encontrado.");
                    }
                    break;

                case 5:
                    Console.WriteLine($"Alterar média do aluno:");
                    Console.Write("Digite o nome:");
                    string alterarMedia = Console.ReadLine(); 
                    foreach (var item in alunos)
                    {
                        if (item.Nome == alterarMedia)
                        {
                            
                            Console.WriteLine("Nova media: ");
                            
                            string alterarMediaAluno = Console.ReadLine();
                         
                            double.TryParse(alterarMediaAluno, out double novaMedia);

                            item.Media = novaMedia;

                        }
                        
                    }
                    break;
                case 6:
                            Console.WriteLine("Encerrando programa");
                            break;

           }    }   
            
        }
    
}

    







        


