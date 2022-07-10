// See https://aka.ms/new-console-template for more information

/****************************************************************************
11) Elaborar um algoritmo que lê 2 valores a e b e os escreve com a mensagem: 
"São múltiplos" ou "Não são múltiplos".
****************************************************************************/

float numero1, numero2, maiorValor;

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

/*********************************************************************************************
DICA minha rsrs: Para obtermos o múltiplo de um número basta realizarmos a multiplicação desse 
número por qualquer número natural, por exemplo: 0, 1, 2, 3, 4, 5, 6, 8, 9, ... Vamos 
observar alguns números e seus múltiplos. 55 é divisível por 5 pois 55/5 = 11 e o resto e 0. 
*********************************************************************************************/
