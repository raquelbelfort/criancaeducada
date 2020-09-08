using System;

namespace criancaeducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a lição de casa:");
            string frase = Console.ReadLine();
            Console.WriteLine("Eu sou uma criança educada. No seu lugar eu diria:");
            Console.WriteLine(frase.Replace("chato", "#@$%*!&.") .Replace("chata", "#@$%*!&.") .Replace("bobo", "#@$%*!&.") 
            .Replace("boba", "#@$%*!&.") .Replace("feio", "#@$%*!&.") .Replace("feia", "#@$%*!&.") .Replace("boboca", "#@$%*!&.") 
            .Replace("bocó", "#@$%*!&.") .Replace("palerma", "#@$%*!&.") .Replace("paspalho", "#@$%*!&.") 
            .Replace("paspalha", "#@$%*!&.") .Replace("tantã", "#@$%*!&.") .Replace("panaca", "#@$%*!&.") .Replace("pentelho", "#@$%*!&.") 
            .Replace("burro", "#@$%*!&.") .Replace("burra", "#@$%*!&.") .Replace("besta", "#@$%*!&."));
        }
    }
}
