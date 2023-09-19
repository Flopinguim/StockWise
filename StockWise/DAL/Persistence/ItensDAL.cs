using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Biblioteca de acesso ao SQL SERVER
using DAL.Model;

namespace DAL.Persistence
{
    public class ItensDAL : Conexao
    {
        //Métodos para gravar  dados: INSERT:
        public void Gravar(Itens obj)
        {
            try 
            {
                //Abrir a Conexao:
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Itens (Nome, Descricao, DataAquisicao, NumSerie, VidaUtil, IdadeItem, ValorCompra, Categoria, Setor, Inativo) values()")
            } 
            catch (Exception ex) 
            {
                throw;
            }
            finally 
            {
                FecharConexao();
            }
        }
    }
}

//regras de negócio  da nossa aplicação - consultas ! SELECT, UPDATE, INSERT, OBTERPORID  