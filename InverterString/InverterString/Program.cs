class Program
{
    static void Main()
    {
        string exemplo = "Teste desenvolvedor.";        
        Console.WriteLine("String de exemplo para ser invertida: " + exemplo);
        Console.WriteLine("String invertida: " + inverterString(exemplo));

        Console.WriteLine("Digite uma string para ser invertida: ");
        string input = Console.ReadLine();
        Console.WriteLine("String invertida: " + inverterString(input));


        
    }

    private static string inverterString(string normal)
    {
        string inversa = normal;

        if (normal.Length > 1)
        {
            inversa = String.Empty;            
            for(int i = normal.Length - 1; i >= 0; i--)
            {
                inversa += normal[i];
            }
        }

        return inversa;
    }
}
