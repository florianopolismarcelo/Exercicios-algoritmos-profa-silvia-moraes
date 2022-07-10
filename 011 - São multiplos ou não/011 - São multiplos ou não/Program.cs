// See https://aka.ms/new-console-template for more information

/*********************************************************************************************
11) Elaborar um algoritmo que lê 2 valores a e b e os escreve com a mensagem: 
"São múltiplos" ou "Não são múltiplos".
*********************************************************************************************/

float numero1, numero2;

Console.WriteLine("Informe o primeiro numero:");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero:");
numero2 = float.Parse(Console.ReadLine());

if (numero1 % numero2 == 0)
{
    Console.WriteLine("São Multiplos");
}
else
{
    Console.WriteLine("Não são multiplos");
}