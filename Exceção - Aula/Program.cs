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
        }
        Console.WriteLine($"O valor obtido foi {num}");
    }
}