// See https://aka.ms/new-console-template for more information
/***************************************************************************************
* 06) Faça um algoritmo que leia o tempo de duração de um evento em uma fábrica expressa 
* em segundos e mostre-o expresso em horas, minutos e segundos.
****************************************************************************************/

int segundos, horas, minutos;

Console.WriteLine("Informe quantos segundos");
segundos = int.Parse(Console.ReadLine());

horas = segundos / 3600;
minutos = segundos / 60;
segundos = segundos % 60;

Console.WriteLine("A quantidade de segundos digitado tem: " +horas+ " horas " +minutos+ " minutos e " +segundos+ " segundos");


