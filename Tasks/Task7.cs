using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task7
    {

        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         *
        public static List<string> GetProductsOutOfStock()
        {

        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock(int[] stock)
        {
            int resSum = 0;
            for(int i=0; i<stock.Length; i++)
            {
                resSum += stock[i]; 
            }
            return resSum;
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity)
        {
           
        }
    }
}
