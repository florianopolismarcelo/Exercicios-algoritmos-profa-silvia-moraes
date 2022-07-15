// See https://aka.ms/new-console-template for more information

/********************************************************************************************************
22. Uma empresa concederá um aumento de salário aos seus funcionários, variável de acordo com o cargo, 
conforme a tabela abaixo. Faça um algoritmo que leia o salário e o cargo de um funcionário e calcule o 
novo salário. Se o cargo do funcionário não estiver na tabela, ele deverá, então, receber 40% de aumento. 
Mostre o salário antigo, o novo salário e a diferença. 

Código	        Cargo	         Percentual
101	            Gerente	            10%
102         	Engenheiro	        20%
103	            Técnico         	30%
*******************************************************************************************************/

string codigo, cargo;
double salario = 0, novoSalario = 0;

Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +  Tabela aumento de salário aos funcionários variável acordo o cargo  +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +                                                                      +");
Console.WriteLine("    +                           ATENÇÃO!!!                                 +");
Console.WriteLine("    +                                                                      +");
Console.WriteLine("    + Se o funcionário não estiver na tabela digite o código e cargo dele. +");
Console.WriteLine("    +             Esse funcionário irá ter um aumento de 40%               +");
Console.WriteLine("    +                                                                      +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +              Código              Cargo            Percentual+        +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +              [101]      ==>      Gerente       ==>   10%             +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +              [102]      ==>      Engenheiro    ==>   20%             +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +              [103]      ==>      Tecnico       ==>   30%+            +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

Console.WriteLine("                           ");
Console.Write("Digite o cargo do funcionário: ");
cargo = (Console.ReadLine());

Console.Write("Digite o sálario atual do funcionário: ");
salario = double.Parse(Console.ReadLine());

if (cargo != "Gerente" && cargo != "Engenheiro" && cargo != "Técnico")
{
    Console.WriteLine("+--------------------------------------------------------------------+");
    Console.WriteLine("+ O Funcionário do cargo: " + cargo + " receberá um aumento de 40%    ");

    novoSalario = ((salario * 40) / 100) + salario;

    Console.WriteLine("+------------------------------------------------------------------------+");
    Console.WriteLine(" Seu antigo salário era R$" + salario + " agora seu novo salário será: R$" + novoSalario);
    Console.WriteLine("+------------------------------------------------------------------------+");
}

switch (cargo)
{
    case "Gerente":

        Console.WriteLine("+--------------------------------------------------------------------+");
        Console.WriteLine("+ O Funcionário do cargo: " + cargo + " receberá um aumento de 10%    ");

        novoSalario = ((salario * 10) / 100) + salario;

        Console.WriteLine("+------------------------------------------------------------------------+");
        Console.WriteLine(" Seu antigo salário era R$" + salario + " agora seu novo salário será: R$" + novoSalario);
        Console.WriteLine("+------------------------------------------------------------------------+");
        break;

    case "Engenheiro":

        Console.WriteLine("+--------------------------------------------------------------------+");
        Console.WriteLine("+ O Funcionário do cargo: " + cargo + " receberá um aumento de 20%    ");

        novoSalario = ((salario * 20) / 100) + salario;

        Console.WriteLine("+------------------------------------------------------------------------+");
        Console.WriteLine(" Seu antigo salário era R$" + salario + " agora seu novo salário será: R$" + novoSalario);
        Console.WriteLine("+------------------------------------------------------------------------+");
        break;

    case "Técnico":

        Console.WriteLine("+--------------------------------------------------------------------+");
        Console.WriteLine("+ O Funcionário do cargo: " + cargo + " receberá um aumento de 30%    ");

        novoSalario = ((salario * 30) / 100) + salario;

        Console.WriteLine("+------------------------------------------------------------------------+");
        Console.WriteLine(" Seu antigo salário era R$" + salario + " agora seu novo salário será: R$" + novoSalario);
        Console.WriteLine("+------------------------------------------------------------------------+");
        break;
}
