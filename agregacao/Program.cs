﻿namespace agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com agregação!");

        //instanciando os objetos de cada classe
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        //adicionando um nome para um cliente
        cli.Nome = "Anderson Vanin";

        //adicionando número e validade do Cartão de Crédito
        cdc.Numero = "123456789";
        cdc.DataValidade = "05/2025";

        //associando o cliente ao atributo  de agregação em Cartão de Crédito
        cdc.Cliente = cli;

        //visualizando as informações
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);
    }
}
