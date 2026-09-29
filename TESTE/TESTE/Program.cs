using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        public static class variaveis
        {

            public static string nome, CPF, TipoSaguineo, ContatoEmergencia, NumeroQuarto, tipo, alergias, CRM, Especialidade,
                Telefone, DiagnosticoEntrada, Status, nomeMedico, idMedico, idLeito, MedicoResponsavelId, codigoPaciente, resposta, observacao,
                altaRealizada, dataInternacao, idade, Nascimento, DataAlta, DataEntrada;
            public static int PacienteId;

            public static DateTime? dataalta { get; set; }
            public static DateTime dataentrada { get; set; }
            public static bool estaOcupado;
            


        }
        static void Main(string[] args)
        {
            int opcao = 0;


            while (opcao != 7)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░

██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░░█████╗░██████╗░
██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░███████║██████╔╝
██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══██╗
██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗██║░░██║██║░░██║
╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝ 
═════════════ ═════════════ ═════════════ ═════════════ ═════════════");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("1 - Cadastrar paciente: ");
                Console.WriteLine("2 - Cadastrar Médico: ");
                Console.WriteLine("3 - Cadastrar Leito: ");
                Console.WriteLine("4 - Registrar Internação (Admissão): ");
                Console.WriteLine("5 - Dar alta hospitalar: ");
                Console.WriteLine("6 - Listar pacientes internados: ");
                Console.WriteLine("7- Exibir relatório geral do hospital: ");
                Console.WriteLine("0 - Sair ");
                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        cadastrar_Paciente();

                        break;

                    case 2:
                        cadastrar_medico();
                        break;

                    case 3:
                        cadastrar_leito();
                        break;
                    case 4:
                        Registrar_Internação();

                        break;

                    case 5:
                        Alta_Hospitalar();
                        break;
                    case 6:
                        listar_pacientes();
                        break;

                    case 7:
                        relatorio_geral();
                        break;


                    case 0:
                        Console.WriteLine(" Saindo do Programa!!! Tchau Tchau !!");
                        break;


                }

            }
        }


        static void cadastrar_Paciente()
        {



            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ ▄▀█ █▀█   █▀█ ▄▀█ █▀▀ █ █▀▀ █▄░█ ▀█▀ █▀▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▀█ █▀▄   █▀▀ █▀█ █▄▄ █ ██▄ █░▀█ ░█░ ██▄");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("ID: ");
            variaveis.PacienteId = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome completo do paciente: ");
            variaveis.nome = Console.ReadLine();

            Console.WriteLine("Registro do paciente: ");
            variaveis.CPF = Console.ReadLine();

            Console.WriteLine("Data de Nascimento:");
            variaveis.Nascimento = Console.ReadLine();


            Console.WriteLine("Tipo sanguineo (A+, O-, AB+, etc: )");
            variaveis.TipoSaguineo = Console.ReadLine();

            Console.WriteLine("Descricação de alergias medicamentos/alimentares: ");
            variaveis.alergias = Console.ReadLine();

            Console.WriteLine("Nome e telfone de um familiar/responsável: ");
            variaveis.ContatoEmergencia = Console.ReadLine();

            Console.WriteLine("\nid:" + variaveis.PacienteId);
            Console.WriteLine("Paciente: " + variaveis.nome);
            Console.WriteLine("CPF: " + variaveis.CPF);
            Console.WriteLine("Data de Nasc:" + variaveis.Nascimento);
            Console.WriteLine("Tipo Sanguineo: " + variaveis.TipoSaguineo);
            Console.WriteLine("Alergias: " + variaveis.alergias);
            Console.WriteLine("Contato de Emergencia: " + variaveis.ContatoEmergencia);


            Thread.Sleep(5000);






        }

        static void cadastrar_medico()
        {



            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"»» CADASTRO MEDICO «« ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Id:");
            variaveis.idMedico = (Console.ReadLine());

            Console.WriteLine("Nome do profissional: ");
            variaveis.nomeMedico = Console.ReadLine();

            Console.WriteLine("CRM: ");
            variaveis.CRM = Console.ReadLine();

            Console.WriteLine("Especialidade: ");
            variaveis.Especialidade = Console.ReadLine();

            Console.WriteLine("Telefone para contato: ");
            variaveis.Telefone = Console.ReadLine();


            Console.WriteLine("\nId" + variaveis.idMedico);
            Console.WriteLine("\nNome do Profissional: " + variaveis.nomeMedico);
            Console.WriteLine("\nRegistro do conselho regional de medicina: " + variaveis.CRM);
            Console.WriteLine("\nEspecialidade: " + variaveis.Especialidade);
            Console.WriteLine("\nTelefone: " + variaveis.Telefone);


            Thread.Sleep(5000);

        }


        static void cadastrar_leito()
        {




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@" ╬╬ CADASTRAR LEITO ╬╬");
            Console.ResetColor();
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.White;

            Console.WriteLine("ID: ");
            variaveis.idLeito = (Console.ReadLine());

            Console.WriteLine("Nº ou Codigo do quarto/ala: ");
            variaveis.NumeroQuarto = Console.ReadLine();

            Console.WriteLine("Enfermaria, AP, UTI: ");
            variaveis.tipo = Console.ReadLine();

            Console.Write("O leito está ocupado? (S/N): ");
            variaveis.resposta = Console.ReadLine().ToUpper();

            if (variaveis.resposta == "S")
            {
                variaveis.estaOcupado = true;
            }
            else
            {
                variaveis.estaOcupado = false;
            }

            Console.WriteLine("\nId" + variaveis.idLeito);
            Console.WriteLine("\nQuarto/Ala:  " + variaveis.NumeroQuarto);
            Console.WriteLine("\nEnfermaria/AP,UTI:  " + variaveis.tipo);
            Console.WriteLine("\n LEITO DISPONIVEL:  " + variaveis.estaOcupado);



            Thread.Sleep(5000);

        }


        static void Registrar_Internação()
        {


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@" »»»» Registrar Internação (Admissão) «««« ");
            Console.ResetColor();
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.DarkCyan;

            Console.WriteLine("Registro de internação: ");
            variaveis.PacienteId = int.Parse(Console.ReadLine());

            Console.WriteLine("ID do paciente: ");
            variaveis.codigoPaciente = (Console.ReadLine());

            Console.WriteLine("ID  médico responsável: ");
            variaveis.idMedico = (Console.ReadLine());

            Console.WriteLine("Leito alocado: ");
            variaveis.idLeito = (Console.ReadLine());

            Console.WriteLine("Data e hora da admissão: ");
            variaveis.DataEntrada = Console.ReadLine();

            Console.WriteLine("Data e hora da alta(nulo enqaunto internado:)");
            variaveis.DataAlta = Console.ReadLine();

            Console.WriteLine("Motivo/quadro na admissão: ");
            variaveis.DiagnosticoEntrada = Console.ReadLine();

            Console.WriteLine("Em internação/Alta concluida/ Transferido:");
            variaveis.Status = Console.ReadLine();


            Console.WriteLine("\nId " + variaveis.PacienteId);
            Console.WriteLine("\nCodigo do paciente: " + variaveis.codigoPaciente);
            Console.WriteLine("\nMedico Responsável:" + variaveis.MedicoResponsavelId);
            Console.WriteLine("\nLeito alocado " + variaveis.idLeito);
            Console.WriteLine("\nData e hora da admissão: " + variaveis.dataentrada);
            Console.WriteLine("\nData e hora da alta: " + variaveis.dataalta);
            Console.WriteLine("Motivo: " + variaveis.DiagnosticoEntrada);
            Console.WriteLine("Status: " + variaveis.Status);


            Thread.Sleep(5000);





        }
        // Public static class variaveis 
        static void Alta_Hospitalar()
        {

            Console.WriteLine("\nId " + variaveis.codigoPaciente);
            Console.WriteLine("\nNome do paciente " + variaveis.PacienteId);
            Console.WriteLine("\nQuarto/Leito:" + variaveis.idLeito);
            Console.WriteLine("\nData da alta: " + variaveis.dataalta);
            Console.WriteLine("\nObservação: " + variaveis.observacao);
            Console.WriteLine("\nAlta realizada  " + variaveis.altaRealizada);

            Thread.Sleep(5000);
        }

        static void listar_pacientes()
        {


            Console.WriteLine("\nId " + variaveis.PacienteId);
            Console.WriteLine("\n Nome do Paciente: " + variaveis.nome);
            Console.WriteLine("\nIdade " + variaveis.Nascimento);
            Console.WriteLine("\nCPF: " + variaveis.CPF);
            Console.WriteLine("\nQuarto/Leito: " + variaveis.idLeito);
            Console.WriteLine("Data da internação: " + variaveis.dataInternacao);

            Thread.Sleep(5000);

        }

        static void relatorio_geral()
        {

            Console.WriteLine("\nId: " + variaveis.idMedico);
            Console.WriteLine("\nId: " + variaveis.PacienteId);
            Console.WriteLine("\nNome do paciente: " + variaveis.nome);
            Console.WriteLine("\nNome do Medico: " + variaveis.nomeMedico);
            Console.WriteLine("\nTelefone para contato: " + variaveis.Telefone);
            Console.WriteLine("\nStatus: " + variaveis.resposta);


            Thread.Sleep(5000);


        }
    }
}



