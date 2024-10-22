namespace StockWise.CrossCutting.Utils
{
    public class EstoqueUtils
    {
        /// <summary>
        /// Verifica se o estoque de um item está abaixo do nível mínimo.
        /// </summary>
        /// <param name="quantidadeAtual">Quantidade atual do item em estoque.</param>
        /// <param name="nivelMinimoEstoque">Nível mínimo de estoque para o item.</param>
        /// <returns>True se o estoque estiver abaixo do nível mínimo, caso contrário false.</returns>
        public static bool EstoqueBaixo(int quantidadeAtual, int nivelMinimoEstoque)
        {
            return quantidadeAtual < nivelMinimoEstoque;
        }

        /// <summary>
        /// Calcula o valor total do estoque de um item.
        /// </summary>
        /// <param name="precoUnitario">Preço unitário do item.</param>
        /// <param name="quantidade">Quantidade em estoque.</param>
        /// <returns>Valor total do estoque do item.</returns>
        public static decimal CalcularValorEstoque(decimal precoUnitario, int quantidade)
        {
            return precoUnitario * quantidade;
        }

        /// <summary>
        /// Calcula a quantidade necessária para atingir o estoque máximo de um item.
        /// </summary>
        /// <param name="quantidadeAtual">Quantidade atual do item em estoque.</param>
        /// <param name="nivelMaximoEstoque">Nível máximo de estoque para o item.</param>
        /// <returns>Quantidade que precisa ser reabastecida.</returns>
        public static int CalcularQuantidadeReabastecimento(int quantidadeAtual, int nivelMaximoEstoque)
        {
            if (quantidadeAtual >= nivelMaximoEstoque)
            {
                return 0;
            }
            return nivelMaximoEstoque - quantidadeAtual;
        }

        /// <summary>
        /// Gera um relatório simples de itens no estoque com seu valor total.
        /// </summary>
        /// <param name="itensEstoque">Lista de itens no estoque.</param>
        /// <returns>String formatada com os detalhes do estoque e valor total de cada item.</returns>
        public static string GerarRelatorioEstoque(List<Item> itensEstoque)
        {
            string relatorio = "Relatório de Estoque:\n";
            decimal valorTotal = 0;

            foreach (var item in itensEstoque)
            {
                var valorEstoque = CalcularValorEstoque(item.PrecoUnitario, item.Quantidade);
                relatorio += $"Item: {item.Nome}, Quantidade: {item.Quantidade}, Valor Total: {valorEstoque:C}\n";
                valorTotal += valorEstoque;
            }

            relatorio += $"Valor Total do Estoque: {valorTotal:C}";
            return relatorio;
        }

    }
}
