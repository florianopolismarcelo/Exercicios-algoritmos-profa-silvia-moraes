// See https://aka.ms/new-console-template for more information

/**************************************************************************************************************
24) Escrever um algoritmo que lê a hora de início de um jogo e a hora do final do jogo (considerando apenas 
horas inteiras) e calcula a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 
horas e que o jogo pode iniciar em um dia e terminar no dia seguinte.
**************************************************************************************************************/

int horaInicio, horaFim, duracao = 0;

Console.WriteLine("+------------------------+");
Console.WriteLine("+--    DURAÇÃO JOGO    --+");
Console.WriteLine("+                        +");
Console.WriteLine("+------------------------+");

Console.Write(" Digite a hora de inicio do jogo: ");
horaInicio = int.Parse(Console.ReadLine());

Console.Write("Digite a hora do fim do jogo: ");
horaFim = int.Parse(Console.ReadLine());


if (horaInicio > horaFim)

{
    duracao = (24 - horaInicio) + horaFim;
    Console.WriteLine("----------------------");
    Console.WriteLine("Duração do jogo é de: "+duracao+ "hs");
    Console.WriteLine("----------------------");
}
else
{
    duracao = (horaFim - horaInicio);
    Console.WriteLine("----------------------");
    Console.WriteLine("Duração do jogo é de: " + duracao + "hs");
    Console.WriteLine("----------------------");
}
