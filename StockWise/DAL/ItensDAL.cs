using DAL.Model;
using System.Data.SqlClient; //Biblioteca de acesso ao SQL SERVER

namespace DAL.Persistence
{
    public class ItensDAL : AcessBD
    {
        Itens itens = null;
        List<Itens> listItens = new List<Itens>();

        //Métodos para gravar dados: INSERT:
        public void saveItem(Itens obj)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("INSERT INTO Itens (Nome, Descricao, DataAquisicao, NumSerie, VidaUtil, IdadeItem, ValorCompra, Categoria, Setor, Inativo) VALUE (@Nome, @Descricao, @DataAquisicao, @NumSerie, @VidaUtil, @IdadeItem, @ValorCompra, @Categoria, @Setor, @Inativo)");

                Cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                Cmd.Parameters.AddWithValue("@Descricao", obj.Descricao);
                Cmd.Parameters.AddWithValue("@DataAquisicao", obj.DataAquisicao);
                Cmd.Parameters.AddWithValue("@NumSerie", obj.NumeroDeSerie);
                Cmd.Parameters.AddWithValue("@VidaUtil", obj.VidaUtil);
                Cmd.Parameters.AddWithValue("@IdadeItem", obj.IdadeItem);
                Cmd.Parameters.AddWithValue("@ValorCompra", obj.ValorDeCompra);
                Cmd.Parameters.AddWithValue("@Categoria", obj.Categoria);
                Cmd.Parameters.AddWithValue("@Setor", obj.Setores);
                Cmd.Parameters.AddWithValue("@Inativo", obj.Inativo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para atualizar dados: UPDATE:
        public void updateItem(Itens obj)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("UPDATE Itens set Nome =@Nome, Descricao =@Descricao, DataAquisicao =@DataAquisicao, NumSerie =@NumSerie, VidaUtil =@VidaUtil, IdadeItem =@Idade, ValorCompra =@ValorCompra, Categoria =@Categoria, Setor =@Setor, Inativo =@Setor WHERE Codigo =@Codigo");

                Cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                Cmd.Parameters.AddWithValue("@Descricao", obj.Descricao);
                Cmd.Parameters.AddWithValue("@DataAquisicao", obj.DataAquisicao);
                Cmd.Parameters.AddWithValue("@NumSerie", obj.NumeroDeSerie);
                Cmd.Parameters.AddWithValue("@VidaUtil", obj.VidaUtil);
                Cmd.Parameters.AddWithValue("@IdadeItem", obj.IdadeItem);
                Cmd.Parameters.AddWithValue("@ValorCompra", obj.ValorDeCompra);
                Cmd.Parameters.AddWithValue("@Categoria", obj.Categoria);
                Cmd.Parameters.AddWithValue("@Setor", obj.Setores);
                Cmd.Parameters.AddWithValue("@Inativo", obj.Inativo);
                Cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para deletar dados: Delete:
        public void deleteItem(int codigo)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("DELETE FROM Itens WHERE Codigo =@Codigo", Con);


                Cmd.Parameters.AddWithValue("@Codigo", codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para obter dados pelo Código (Primary Key)
        public Itens getByCodigo(int codigo)
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("SELECT * FROM Itens WHERE Codigo =@Codigo");

                Cmd.Parameters.AddWithValue("@Codigo", codigo);

                if (Dr.Read())
                    itens = new Itens();

                itens.Codigo = Convert.ToInt32(Dr["Codigo"]);
                itens.Nome = Convert.ToString(Dr["Nome"]);
                itens.Descricao = Convert.ToString(Dr["Descricao"]);
                itens.DataAquisicao = Convert.ToDateTime(Dr["DataAquisicao"]);
                itens.NumeroDeSerie = Convert.ToString(Dr["NumSerie"]);
                itens.VidaUtil = Convert.ToString(Dr["VidaUtil"]);
                itens.IdadeItem = Convert.ToInt32(Dr["IdadeItem"]);
                itens.ValorDeCompra = Convert.ToDouble(Dr["ValorCompra"]);
                itens.Categoria = Convert.ToString(Dr["Categoria"]);
                itens.Setores = Convert.ToString(Dr["Setor"]);
                itens.Inativo = Convert.ToBoolean(Dr["Inativo"]);

                return itens;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar buscar item: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Itens> list()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Itens", Con);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    itens = new Itens();

                    itens.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    itens.Nome = Convert.ToString(Dr["Nome"]);
                    itens.Descricao = Convert.ToString(Dr["Descricao"]);
                    itens.DataAquisicao = Convert.ToDateTime(Dr["DataAquisicao"]);
                    itens.NumeroDeSerie = Convert.ToString(Dr["NumSerie"]);
                    itens.VidaUtil = Convert.ToString(Dr["VidaUtil"]);
                    itens.IdadeItem = Convert.ToInt32(Dr["IdadeItem"]);
                    itens.ValorDeCompra = Convert.ToDouble(Dr["ValorCompra"]);
                    itens.Categoria = Convert.ToString(Dr["Categoria"]);
                    itens.Setores = Convert.ToString(Dr["Setor"]);
                    itens.Inativo = Convert.ToBoolean(Dr["Inativo"]);

                    listItens.Add(itens);
                }
                return listItens;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os itens: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}

//regras de negócio  da nossa aplicação - consultas ! SELECT, UPDATE, INSERT, OBTERPORID  