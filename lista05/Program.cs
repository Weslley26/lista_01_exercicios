﻿/*
 . Verificação de Idade
o Objetivo: Aplicar condições para classificar dados.

o Descrição: Desenvolva um programa que solicite a idade de uma pessoa e 
determine se ela é maior de idade (18 anos ou mais) ou menor de idade. 
Utilize if e else para mostrar a mensagem apropriada.
o Exemplo de Saída: "Você é maior de idade." ou "Você é menor de idade
*/

Console.WriteLine("sua idade");

int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{

    Console.WriteLine("voce e maior de idade.");

}
else
{
    Console.WriteLine("voce e menor de iade.");
}