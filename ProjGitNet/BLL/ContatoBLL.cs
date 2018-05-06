using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjGitNet.Model;
using ProjGitNet.DAL;

namespace ProjGitNet.BLL
{
    public class ContatoBLL
    {
        private ContatoDAL dal = null;

        public ContatoBLL()
        {
            dal = new ContatoDAL();
        }

        public void Cadastrar(Contato contato)
        {
            try
            {
                dal.Cadastrar(contato);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}