﻿/*
o Descrição: Crie um programa que peça ao usuário para digitar um número 
inteiro. O programa deve verificar se o número é par ou ímpar. Utilize a 
condição if para determinar o resultado e exiba uma mensagem apropriada.
o Exemplo de Saída: "O nú 1. Verificação de Paridade
o Objetivo: Praticar o uso do operador % (módulo) e estruturas condicionais 
simples.
mero é par." ou "O número é ímpar
*/

Console.WriteLine("Digite um número");

int numero = int.Parse(Console.ReadLine());

if ( numero % 0 == 1)
{
    Console.WriteLine("numero par");
}
else
{
    Console.WriteLine("numero impar");
}