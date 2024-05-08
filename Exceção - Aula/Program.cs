/*
 * 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;

        Console.WriteLine("Insira um número inteiro: ");
        try
        {
            num = int.Parse(Console.ReadLine());
        }
        catch (Exception e) // O "e" é o objeto que será retornado como tratamento da exceção
        {
            Console.WriteLine("Simpatia, informe um número inteiro!");
            Console.WriteLine("Mensagem retornada da exceção: " + e.ToString());
            Console.WriteLine("\nDados da exceção" + e.Source.GetType());

        }
        finally
        {
            /* 
             * Se deu erro ou não, o "finally" é executado
             * Ele é de uso opcional
             * É mais para saber que "você chegou no final do bloco"
             * A principal funcão dele é controlar todo o bloco
             */
            Console.WriteLine("\nFinal do tratamento da exceção");
        }
        Console.WriteLine($"O valor obtido foi {num}");

        /*
         * O try é usado como controle para que o usuário não faça algo ruim à execução do código
         * 
         * A ideia do log é o registro de cada processo ocorrido, inclusive os erros
         * 
         * 
         */
    }
}