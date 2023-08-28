using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FI.AtividadeEntrevista.DAL.Beneficiarios;
using FI.AtividadeEntrevista.DML;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiarioCliente 
    {

        public void Incluir(BeneficiarioCliente benef)
        {
            DaoBeneficiarioCliente benefCliente = new DaoBeneficiarioCliente();

            benefCliente.Incluir(benef);

        }

        public List<BeneficiarioCliente> Consultar(long idCliente)
        {
            DaoBeneficiarioCliente benefCliente = new DaoBeneficiarioCliente();

            return benefCliente.Consultar(idCliente);
        }

        public void Excluir(int idCliente)
        {
            DaoBeneficiarioCliente benefCliente = new DaoBeneficiarioCliente();
            benefCliente.Excluir(idCliente);
        }

        /*        public DML.BeneficiarioCliente Consultar(string CPF)
                {
                    DAL.Beneficiarios.DaoBeneficiarioCliente benef = new DAL.Beneficiarios.DaoBeneficiarioCliente();
                    return benef.Consultar(CPF);
                }

                public List<DML.BeneficiarioCliente> Pesquisa(int ID)
                {
                    DAL.Beneficiarios.DaoBeneficiarioCliente benef = new DAL.Beneficiarios.DaoBeneficiarioCliente();
                    return benef.Pesquisa(ID);
                }

                public void Exclui(int IDCliente)
                {
                    DAL.Beneficiarios.DaoBeneficiarioCliente benef = new DAL.Beneficiarios.DaoBeneficiarioCliente();
                    benef.Exclui(IDCliente);
                }
        */
    }
}

