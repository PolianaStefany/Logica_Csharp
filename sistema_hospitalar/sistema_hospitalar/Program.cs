using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sistema_hospitalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 8)
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
                        listar_pacientes();
                        Alta_Hospitalar();
                        break;


                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                }

            }
        }


        static void cadastrar_Paciente()
        {
            int id;
            string nome, CPF, TipoSaguineo, alergias, ContatoEmergencia;
            DateTime dataNascimento;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ ▄▀█ █▀█   █▀█ ▄▀█ █▀▀ █ █▀▀ █▄░█ ▀█▀ █▀▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▀█ █▀▄   █▀▀ █▀█ █▄▄ █ ██▄ █░▀█ ░█░ ██▄");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("ID: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome completo do paciente: ");
            nome = Console.ReadLine();

            Console.WriteLine("Registro do paciente: ");
            CPF = Console.ReadLine();

            Console.WriteLine("Data de Nascimento:");
            dataNascimento = DateTime.Now;


            Console.WriteLine("Tipo sanguineo (A+, O-, AB+, etc.)");
            TipoSaguineo = Console.ReadLine();

            Console.WriteLine("Descricação de alergias medicamentos/alimentares: ");
            alergias = Console.ReadLine();

            Console.WriteLine("Nome e telfone de um familiar/responsável: ");
            ContatoEmergencia = Console.ReadLine();

            Console.WriteLine("\nid:" + id);
            Console.WriteLine("Paciente: " + nome);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Data de Nasc:" + dataNascimento);
            Console.WriteLine("Tipo Sanguineo: " + TipoSaguineo);
            Console.WriteLine("Alergias: " + alergias);
            Console.WriteLine("Contato de Emergencia: " + ContatoEmergencia);


            Thread.Sleep(5000);






        }

        static void cadastrar_medico()
        {

            int id;
            string nome, CRM, especialidade, telefone;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"»» CADASTRO MEDICO «« ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Id:");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do profissional: ");
            nome = Console.ReadLine();

            Console.WriteLine("CRM: ");
            CRM = Console.ReadLine();

            Console.WriteLine("Especialidade: ");
            especialidade = Console.ReadLine();

            Console.WriteLine("Telefone para contato: ");
            telefone = Console.ReadLine();


            Console.WriteLine("\nId" + id);
            Console.WriteLine("\nNome do Profissional: " + nome);
            Console.WriteLine("\nRegistro do conselho regional de medicina: " + CRM);
            Console.WriteLine("\nEspecialidade: " + especialidade);
            Console.WriteLine("\nTelefone: " + telefone);


            Thread.Sleep(5000);

        }


        static void cadastrar_leito()
        {


            int id;
            string NumeroQuarto, tipo;
            bool estaOcupado = true;


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@" ╬╬ CADASTRAR LEITO ╬╬");
            Console.ResetColor();
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.White;

            Console.WriteLine("ID: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nº ou Codigo do quarto/ala: ");
            NumeroQuarto = Console.ReadLine();

            Console.WriteLine("Enfermaria, AP, UTI: ");
            tipo = Console.ReadLine();

            Console.Write("O leito está ocupado? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                estaOcupado = true;
            }
            else
            {
                estaOcupado = false;
            }

            Console.WriteLine("\nId" + id);
            Console.WriteLine("\nQuarto/Ala:  " + NumeroQuarto);
            Console.WriteLine("\nEnfermaria/AP,UTI:  " + tipo);
            Console.WriteLine("\n LEITO DISPONIVEL:  " + estaOcupado);



            Thread.Sleep(5000);

        }


        static void Registrar_Internação()
        {
            int id, MedicoResponsavelid, LeitoId, PacienteId;
            DateTime Dataentrada, Dataalta;
            string DiagnosticoEntrada, status;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@" »»»» Registrar Internação (Admissão) «««« ");
            Console.ResetColor();
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.DarkCyan;

            Console.WriteLine("Registro de internação: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Codigo do paciente: ");
            PacienteId = int.Parse(Console.ReadLine());

            Console.WriteLine("Código do médico responsável: ");
            MedicoResponsavelid = int.Parse(Console.ReadLine());

            Console.WriteLine("Código do leito alocado: ");
            LeitoId = int.Parse(Console.ReadLine());

            Console.WriteLine("Data e hora da admissão: ");
            Dataentrada = DateTime.Now;

            Console.WriteLine("Data e hora da alta(nulo enqaunto internado:)");
            Dataalta = DateTime.Now;

            Console.WriteLine("Motivo/quadro na admissão: ");
            DiagnosticoEntrada = Console.ReadLine();

            Console.WriteLine("Em internação/Alta concluida/ Transferido:");
            status = Console.ReadLine();


            Console.WriteLine("\nId " + id);
            Console.WriteLine("\nCodigo do paciente: " + PacienteId);
            Console.WriteLine("\nMedico Responsável:" + MedicoResponsavelid);
            Console.WriteLine("\nLeito alocado " + LeitoId);
            Console.WriteLine("\nData e hora da admissão: " + Dataentrada);
            Console.WriteLine("\nData e hora da alta: " + Dataalta);
            Console.WriteLine("Motivo: " + DiagnosticoEntrada);
            Console.WriteLine("Status: " + status);


            Thread.Sleep(9000);





        }
        // Public static class variaveis 
        static void Alta_Hospitalar()
        {
            int idPaciente;
            int idLeito;
            int id;
            DateTime dataAlta;
            string observacaoAlta;
            bool altaRealizada;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@" »»»» Alta Hospitalar «««« ");
            Console.ResetColor();
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.DarkCyan;

            Console.WriteLine("ID: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do paciente: ");
            idPaciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Quarto/Leito alocado: ");
            idLeito = int.Parse(Console.ReadLine());

            Console.WriteLine("Data da alta: ");
            dataAlta = DateTime.Now;

            Console.WriteLine("Observação: ");
            observacaoAlta = Console.ReadLine();

            Console.WriteLine("Alta Realizada");
            altaRealizada = true;

            Console.WriteLine("\nId " + id);
            Console.WriteLine("\nNome do paciente " + idPaciente);
            Console.WriteLine("\nQuarto/Leito:" + idLeito);
            Console.WriteLine("\nData da alta: " + dataAlta);
            Console.WriteLine("\nObservação: " + observacaoAlta);
            Console.WriteLine("\nAlta realizada  " + altaRealizada);

            Thread.Sleep(9000);
        }

        static void listar_pacientes()
        {
            int idPaciente;
            int id;
            string nomePaciente;
            int idade;
            string cpf;
            int idLeito;
           
            DateTime dataInternacao;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@" »»»» Listar Pacientes Internados «««« ");
            Console.ResetColor();
            Console.ForegroundColor = (ConsoleColor)ConsoleColor.DarkCyan;

            Console.WriteLine("ID: ");
            id= int.Parse(Console.ReadLine());

            Console.WriteLine("Codigo do registro de internaçao: ");
            idPaciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do paciente: ");
            nomePaciente= Console.ReadLine();

            Console.WriteLine("Idade: ");
            idade=int.Parse(Console.ReadLine());

            Console.WriteLine("CPF: ");
            cpf= Console.ReadLine();

            Console.WriteLine("Leito:");
            idLeito= int.Parse(Console.ReadLine());

            Console.WriteLine("Data da internação: ");
            dataInternacao = DateTime.Now;


            Console.WriteLine("\nId " + id);
            Console.WriteLine("\nCodigo do paciente: " + idPaciente);
            Console.WriteLine("\n Nome do Paciente: " + nomePaciente);
            Console.WriteLine("\nIdade " +idade);
            Console.WriteLine("\nCPF: " + cpf);
            Console.WriteLine("\nQuarto/Leito: " + idLeito);
            Console.WriteLine("Data da internação: " + dataInternacao);

            Thread.Sleep(9000);

        }
    }
}
