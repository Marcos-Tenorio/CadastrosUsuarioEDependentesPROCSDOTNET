using FI.AtividadeEntrevista.DML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FI.AtividadeEntrevista.DML;

namespace FI.AtividadeEntrevista.DAL.Beneficiarios
{
    internal class DaoBeneficiarioCliente : AcessoDados
    {
        internal void Incluir(BeneficiarioCliente beneficiario)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

            parametros.Add(new System.Data.SqlClient.SqlParameter("Nome", beneficiario.Nome));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CPF", beneficiario.CPF));
            parametros.Add(new System.Data.SqlClient.SqlParameter("IDCLIENTE", beneficiario.IDCLIENTE));

            base.Executar("FI_SP_IncBeneficiario", parametros);
        }

        internal List<BeneficiarioCliente> Consultar (long idCliente)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("ID", idCliente));

            DataSet benefDataSet = base.Consultar("FI_SP_ConsultaClienteID", parametros);
            List<BeneficiarioCliente> lista = new List<BeneficiarioCliente>();

            lista = Converter(benefDataSet);
           

            return lista;
        }

        private List<DML.BeneficiarioCliente> Converter(DataSet ds)
        {
            List<DML.BeneficiarioCliente> lista = new List<DML.BeneficiarioCliente>();
            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DML.BeneficiarioCliente benef = new DML.BeneficiarioCliente();
                    benef.Id = row.Field<long>("Id");
                    benef.CPF = row.Field<string>("CPF");
                    benef.Nome = row.Field<string>("Nome");
                    benef.IDCLIENTE = row.Field<int>("IDCLIENTE");
                   
                    lista.Add(benef);
                }
            }

            return lista;
        }

        internal void Excluir(int idCliente)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();           
            parametros.Add(new System.Data.SqlClient.SqlParameter("ID", idCliente));

            base.Executar("FI_SP_ExcluirBeneficiarios", parametros);
        }

    }

}
/*
    foreach (var cliente in listaClientes)
    {
        dataTable.Rows.Add(cliente.ClienteId, cliente.Nome);
    }

using (var command = new SqlCommand("InserirClientes", connection))
{
    command.CommandType = CommandType.StoredProcedure;
    var parameter = new SqlParameter("@Clientes", SqlDbType.Structured);
    parameter.Value = dataTable;
    command.Parameters.Add(parameter);

    command.ExecuteNonQuery();
}
}
*/
/// <summary>
/// Inclui um novo cliente
/// </summary>
/// <param name="cliente">Objeto de cliente</param>
/*      internal DML.BeneficiarioCliente Consultar(long Id)
      {
          List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

          parametros.Add(new System.Data.SqlClient.SqlParameter("Id", Id));

          DataSet ds = base.Consultar("FI_SP_ConsClienteV2", parametros);
          List<DML.Cliente> cli = Converter(ds);

          return cli.FirstOrDefault();
      }

*/

      

// TODO: Criar e implementar PROC para alteracao de Beneficiario
/// <summary>
/// Altera beneficiario
/// </summary>
/// <param name="beneficiarioCliente">Objeto de BeneficiarioCliente</param>
/*      internal void Alterar(DML.BeneficiarioCliente beneficiarioCliente)
      {
          List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

          parametros.Add(new System.Data.SqlClient.SqlParameter("CPF", beneficiarioCliente.CPF));
          parametros.Add(new System.Data.SqlClient.SqlParameter("Nome", beneficiarioCliente.Nome));
          parametros.Add(new System.Data.SqlClient.SqlParameter("IDCLIENTE", beneficiarioCliente.IDCLIENTE));

          base.Executar("FI_SP_AltClienteV2", parametros);
      }


      /// <summary>
      /// Excluir Cliente
      /// </summary>
      /// <param name="beneficiarioCliente">Objeto de cliente</param>
      internal void Excluir(long Id)
      {
          List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();

          parametros.Add(new System.Data.SqlClient.SqlParameter("Id", Id));

          base.Executar("FI_SP_DelCliente", parametros);
      }

      private List<DML.BeneficiarioCliente> Converter(DataSet ds)
      {
          List<DML.BeneficiarioCliente> lista = new List<DML.BeneficiarioCliente>();
          if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
          {
              foreach (DataRow row in ds.Tables[0].Rows)
              {
                  DML.BeneficiarioCliente benef = new DML.BeneficiarioCliente();
                  benef.Id = row.Field<long>("Id");
                  benef.CPF = row.Field<string>("CPF");
                  benef.Nome = row.Field<string>("Nome");
                  benef.IDCLIENTE = row.Field<int>("IDCLIENTE");
                  lista.Add(benef);
              }
          }

          return lista;
      }
  }
*/
