public class Program
{
    public static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());                                              // 3

        int[] num = new int[n];

        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());                                         // 1 2 1
        }
        Console.WriteLine($"O maior é: {MajorityElement(num)}");
    }


    public static int MajorityElement(int[] nums)
    {
        List<int> numerosJaTestados = new();
        int maior = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int numero = nums[i];

            if (numerosJaTestados.Contains(numero))
                continue;

            int countNumero = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == numero)
                    countNumero++;
            }

            if (count < countNumero)
            {
                maior = numero;
                count = countNumero;
            }

            numerosJaTestados.Add(numero);
        }
        return maior;
    }
}