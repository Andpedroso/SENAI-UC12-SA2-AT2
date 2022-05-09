// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SenaiBack7.Classes;

//ARQUIVO TXT PARA PESSOA FÍSICA

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "André";

Console.WriteLine( $"Nome Pessoa Física : {novaPf.nome}" );

StreamWriter sw = new StreamWriter( $"{novaPf.nome}.txt" );

sw.Write( novaPf.nome );

sw.Close();

using ( StreamWriter sw2 = new StreamWriter( $"{novaPf.nome}.txt" ) )
{
    sw2.WriteLine( $"Pessoa Física : {novaPf.nome}" );
}

//ARQUIVO TXT PARA PESSOA JURÍDICA

PessoaJuridica novaPj = new PessoaJuridica();

novaPj.nome = "André Pedroso";

Console.WriteLine( $"Nome Pessoa Jurídica : {novaPj.nome}" );

StreamWriter sr = new StreamWriter( $"{novaPj.nome}.txt" );

sr.Write( novaPj.nome );

sr.Close();

using ( StreamWriter sr2 = new StreamWriter( $"{novaPj.nome}.txt" ) )
{
    sr2.WriteLine( $"Pessoa Jurídica : {novaPj.nome}" );
}