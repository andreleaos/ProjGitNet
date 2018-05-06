using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjGitNet.Util;

namespace ProjGitNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto Git Iniciado");

            TesteContato.TesteCadastro();

            Console.WriteLine("Teste de Agenda Concluido com Sucesso!");
        }
    }
}
