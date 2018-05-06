using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjGitNet.Model;
using ProjGitNet.BLL;

namespace ProjGitNet.Util
{
    public class TesteContato
    {
        public static void TesteCadastro()
        {
            var contato1 = new Contato
            {
                Nome = "Roberto",
                Email = "roberto@gmail.com",
                Fone = "11 4567-9845"
            };

            var contato2 = new Contato
            {
                Nome = "Pedro",
                Email = "pedro@hotmail.com",
                Fone = "28 6578-2413"
            };

            var contatos = new List<Contato>();
            contatos.Add(contato1);
            contatos.Add(contato2);

            var objBll = new ContatoBLL();

            try
            {
                foreach(var item in contatos)
                {
                    objBll.Cadastrar(item);
                }

                Console.WriteLine("Cadastro Efetuado com Sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
