// See https://aka.ms/new-console-template for more information

/*********************************************************************************************************************
28) Escrever um algoritmo que lê a hora de início e hora de término de um jogo, ambas subdivididas em dois 
valores distintos : horas e minutos. Calcular e escrever a duração do jogo, também em horas e minutos, considerando 
que o tempo máximo de duração de um jogo é de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte.
**********************************************************************************************************************/

int horaInicio = 0, horaFim = 0, minutoInicial =0, minutoTermino=0, minutos, duracao = 0;

Console.WriteLine("+------------------------+");
Console.WriteLine("+--    DURAÇÃO JOGO    --+");
Console.WriteLine("+                        +");
Console.WriteLine("+------------------------+");

Console.Write("Digite a hora do inicio do jogo: ");
horaInicio = int.Parse(Console.ReadLine());

Console.Write("Além da hora, digite agora os minutos do inicio do jogo: ");
minutoInicial = int.Parse(Console.ReadLine());

Console.Write("Digite a hora do fim do jogo: ");
horaFim = int.Parse(Console.ReadLine());

Console.Write("Além da hora, digite agora os minutos do fim do jogo: ");
minutoTermino = int.Parse(Console.ReadLine());


if (horaInicio > horaFim)

{
    duracao = (24 - horaInicio) + horaFim;
    minutos = minutoInicial + minutoTermino;
    Console.WriteLine("----------------------");
    Console.WriteLine("Duração do jogo é de: " + duracao + "h"+minutos+"m");
    Console.WriteLine("----------------------");
}
else
{
    duracao = (horaFim - horaInicio);
    minutos = minutoInicial + minutoTermino;
    Console.WriteLine("----------------------");
    Console.WriteLine("Duração do jogo é de: " + duracao + "h"+minutos+"m");
    Console.WriteLine("----------------------");
}
