using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADO.NET - > SQL SERVER

namespace DAL.Persistence
{
    public class Conexao
    {
        //Atributos:
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Método - Abrir Conexao
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=DESKTOP-OR6O5RV\\SQL2014;Initial Catalog=StockWise;Integrated Security=True"); //Conection String
                Con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 

        //Método - Fechar Conexao
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
