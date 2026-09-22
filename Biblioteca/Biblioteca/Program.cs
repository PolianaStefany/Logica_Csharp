using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            while (opcao != 6)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

░██████╗░███████╗░██████╗████████╗░█████╗░░█████╗░  ██████╗░███████╗
██╔════╝░██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░██╗░█████╗░░╚█████╗░░░░██║░░░███████║██║░░██║  ██║░░██║█████╗░░
██║░░╚██╗██╔══╝░░░╚═══██╗░░░██║░░░██╔══██║██║░░██║  ██║░░██║██╔══╝░░
╚██████╔╝███████╗██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░██╗██████╗░██╗░░░░░██╗░█████╗░████████╗███████╗░█████╗░░█████╗░
██╔══██╗██║██╔══██╗██║░░░░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██╔══██╗
██████╦╝██║██████╦╝██║░░░░░██║██║░░██║░░░██║░░░█████╗░░██║░░╚═╝███████║
██╔══██╗██║██╔══██╗██║░░░░░██║██║░░██║░░░██║░░░██╔══╝░░██║░░██╗██╔══██║
██████╦╝██║██████╦╝███████╗██║╚█████╔╝░░░██║░░░███████╗╚█████╔╝██║░░██║
╚═════╝░╚═╝╚═════╝░╚══════╝╚═╝░╚════╝░░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1 - Cadastrar Livro");
                Console.WriteLine("2 - Cadastrar Jogo");
                Console.WriteLine("3 - Cadastrar Cliente");
                Console.WriteLine("4 - Cadastrar Fornecedor");
                Console.WriteLine("5 - Registrar Empréstimo");
                Console.WriteLine("0 - Sair");
                Console.WriteLine(" ----> ");
                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        cadastro_livro();

                        break; // encerra o programa 
                    case 2:
                        cadastro_jogo();

                        break;
                    case 3:
                        cadastrar_cliente();

                        break;
                    case 4:
                        cadastrar_fornecedor();
                        break;
                    case 5:
                        Registrar_Emprestimo();
                        break;
                    case 6: 
                        Console.WriteLine(" Saindo do Programa!!! Tchau Tchau !!    :)");
                        break;
                }



            }


        }
        static void cadastro_livro()
        {

            int id, AnoPublicacao, QuantidadeExemplares;
            string Titulo, Autor, ISBN, Genero;
            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░  ██╗░░░░░██╗██╗░░░██╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗  ██║░░░░░██║██║░░░██║██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝  ██║░░░░░██║╚██╗░██╔╝██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗  ██║░░░░░██║░╚████╔╝░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║  ███████╗██║░░╚██╔╝░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Digite o Identificador único: ");
            id= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da obra: ");
            Titulo= Console.ReadLine();

            Console.WriteLine("Digite o nome do autor: ");
            Autor= Console.ReadLine();

            Console.WriteLine("Digite o código de identificação internacional: ");
            ISBN= Console.ReadLine();

            Console.WriteLine("Ano de lancamento: ");
            AnoPublicacao= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o genero: ");
            Genero= Console.ReadLine();

            Console.WriteLine("Total de cópias na biblioteca: ");
            QuantidadeExemplares= int.Parse(Console.ReadLine());

            Console.WriteLine("\nCadastro realizado com Sucesso !!! ");
            Console.WriteLine("\nid " + id );
            Console.WriteLine("\nTitulo "  + Titulo );
            Console.WriteLine("\nAutor "  + Autor );
            Console.WriteLine("\nISBN "  + ISBN );
            Console.WriteLine("\nAno Publicacao "  + AnoPublicacao );
            Console.WriteLine("\nGenero " + Genero);
            Console.WriteLine("\nQuantidade Exemplares " + QuantidadeExemplares );


            Thread.Sleep(8000);




        }
        static void cadastro_jogo()
        {
            int id, FaixaEtaria, NumMinJogadores, NumMaxJogadores, qtdExemplares;
            string nome, categoria;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   ░░█ █▀█ █▀▀ █▀█
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▄█ █▄█ █▄█");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Digite o Identificador: ");
            id= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do jogo: ");
            nome= Console.ReadLine();

            Console.WriteLine("Digite a categoria (ex: Estratégia, RPG, Tabuleiro): ");
            categoria= Console.ReadLine();

            Console.WriteLine("Idade mínima recomendada: ");
            FaixaEtaria= int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade mínima de participantes: ");
            NumMinJogadores= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade máxima de participantes: ");
            NumMaxJogadores = int.Parse(Console.ReadLine());

            Console.WriteLine("Total de caixas disponíveis: ");
            qtdExemplares= int.Parse(Console.ReadLine());

            Console.WriteLine("\nid: " + id);
            Console.WriteLine("\nnome: " + nome);
            Console.WriteLine("\ncategoria: " + categoria);
            Console.WriteLine("\nFaixa Etaria: " + FaixaEtaria);
            Console.WriteLine("\nNumero Min Jogadores: " + NumMinJogadores);
            Console.WriteLine("\nNumero Máxima de participantes: " + NumMaxJogadores);
            Console.WriteLine("\nTotal de caixas disponiveis: " + qtdExemplares);
            Console.WriteLine("\nJogo cadastrado com sucesso!");
        




        Thread.Sleep(9000);






        }
        static void cadastrar_cliente ()
        {
            int id;
           string nome, CPF, telefone, email;
            DateTime DataNascimento;
            bool ativo;
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(@"
█
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ ▄▀█ █▀█   █▀▀ █░░ █ █▀▀ █▄░█ ▀█▀ █▀▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▀█ █▀▄   █▄▄ █▄▄ █ ██▄ █░▀█ ░█░ ██▄");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Digite o identificador: ");
            id= int.Parse(Console.ReadLine());

            Console.WriteLine("Nome completo do usuário: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o Documento de identificação: ");
            CPF = Console.ReadLine();

            Console.WriteLine("Digite o número de contato: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Digite o endereço de e-mail: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento: ");
            DataNascimento = DateTime.Now;

            Console.WriteLine("Situação do cadastro (True/False) ");
            ativo = bool.Parse(Console.ReadLine());

            if (ativo == true && ativo == true)
            {
                Console.WriteLine("Ambos são VERDADEIROS.");
            }
            else if (ativo == false && ativo == false)
            {
                Console.WriteLine("Ambos são FALSOS.");
            }
            else
            {
                Console.WriteLine("Um é VERDADEIRO e o outro é FALSO.");
            }
        

        Thread.Sleep(9000);

        }

        static void cadastrar_fornecedor()
        {
            int id;
            string RazaoSocial, CNPJ, telefone, email, endereco;

            Console.Clear();    
            Console.ForegroundColor=(ConsoleColor) ConsoleColor.Green;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ResetColor ();  
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("ID: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome jurídico da empresa/editora: ");
            RazaoSocial = Console.ReadLine();

            Console.WriteLine("Registro nacional: ");
            CNPJ = Console.ReadLine();

            Console.WriteLine("Telefone corporativo: ");
            telefone= Console.ReadLine();

            Console.WriteLine("Email de contato comercial: ");
            email= Console.ReadLine();

            Console.WriteLine("Digite o Logradouro e cidade: ");
            endereco= Console.ReadLine();

            Console.WriteLine("\nID "+ id);
            Console.WriteLine("Empresa/editora: " + RazaoSocial);
            Console.WriteLine("Registro Nacional: " + CNPJ);
            Console.WriteLine("Telefone corporativo: " + telefone);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Endereço: " + endereco);

            Thread.Sleep(9000);






        }
        static void Registrar_Emprestimo()
        {
            int id, clienteId, ItemId;
            string TipoItem;
            DateTime DataEmprestimo, DataDevolucaoPrevista;
            bool devolvido;

            Console.Clear ();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ █▀█   █▀▀ █▀▄▀█ █▀█ █▀█ █▀▀ █▀ ▀█▀ █ █▀▄▀█ █▀█
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ █▀▄   ██▄ █░▀░█ █▀▀ █▀▄ ██▄ ▄█ ░█░ █ █░▀░█ █▄█");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("ID: ");
            id= int.Parse(Console.ReadLine());

            Console.WriteLine("Codigo do cliente associado: ");
            clienteId= int.Parse(Console.ReadLine());

            Console.WriteLine("Define se é Livro ou Jogo: ");
            TipoItem= Console.ReadLine();

            Console.WriteLine("Código do livro ou jogo emprestado: ");
            ItemId = int.Parse(Console.ReadLine());

            Console.WriteLine("Data/Hora da retirada: ");
            DataEmprestimo= DateTime.Now;

            Console.WriteLine("Data limite para entrega: ");
            DataDevolucaoPrevista= DateTime.Now;

            Console.WriteLine("Status de devoluçao");
            devolvido = true;

            Console.WriteLine("\nID " + id);
            Console.WriteLine("Cliente associado: " + clienteId);
            Console.WriteLine("Livro/Jogo: " + TipoItem);
            Console.WriteLine("Codigo: " + ItemId);
            Console.WriteLine("Data/Hora da retirada: " + DataEmprestimo);
            Console.WriteLine("Data limite para entrega: " + DataDevolucaoPrevista);
            Console.WriteLine("Status de devoluçao" + devolvido);
            devolvido = true;


            Thread.Sleep(120000);

        }
    }
}

