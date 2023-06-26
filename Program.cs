Console.Clear();
Console.Write(@"       --- $haronBank ---   

Olá, qual seu nome? ");
string nome = Console.ReadLine()!;

Console.Clear();
Console.WriteLine(@$"                  --- $haronBank --- 

Bem Vinde {nome}! 
Digite entre 0 e 9 para selecionar um dos nossos serviços");

Console.WriteLine();
Console.Write(@"0 - Sair do $haronBank
1 - Aprovação de Crédido
2 - Aprovação de Emprestimo
3 - Aprovação de $hequeSpecial
4 - Aplicativo $haronBank
5 - Consulta de Saldo Bancário
6 - Cancelamento de conta
7 - $hequeSpecial
8 - Problemas com Pix
9 - SAC $heron

"); 
int servicos = Convert.ToInt32(Console.ReadLine()!);

if(servicos == 0)
{
    Console.WriteLine();
    Console.Write($"Ok, obrigado {nome} por ultilizar os serviços $haronBank, Volte sempre!");
}

if (servicos == 1 || servicos == 2 || servicos == 3)
{
    Console.WriteLine();
    Console.Write("Infelizmente sua solicitação não foi aprovada");
}

if (servicos == 4)
{
    Console.WriteLine();
    Console.Write("Você pode encontrar o aplicativo na PlayStore ou AppStore, se preferir acesse o site www.sharonbank.com");
}

if (servicos == 5)
{
    Console.WriteLine();
    Console.Write("Seu saldo bancário é de");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("R$0,00");    
}

if (servicos == 6 || servicos == 9)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Serviço indisponível temporariamente. Tente novamente mais tarde");
    Console.ResetColor();
}

if (servicos == 7)
{
    Console.WriteLine();
    Console.Write("Seu $hequeSpecial");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("não");
    Console.ResetColor();
    Console.Write("foi aprovado ainda");
}

if (servicos == 8)
{
    Console.WriteLine();
    Console.Write("Siga o tutorial pelo site www.sharonbank.com/socorrovey");
}

do
{
Console.Clear();
Console.WriteLine(@$"                  --- $haronBank --- 

Digite entre 0 e 9 para selecionar um dos nossos serviços");

Console.WriteLine();
Console.Write(@"0 - Sair do $haronBank
1 - Aprovação de Crédido
2 - Aprovação de Emprestimo
3 - Aprovação de $hequeSpecial
4 - Aplicativo $haronBank
5 - Consulta de Saldo Bancário
6 - Cancelamento de conta
7 - $hequeSpecial
8 - Problemas com Pix
9 - SAC $heron

"); 
Convert.ToInt32(Console.ReadLine()!);
}
while (servicos < 0 || servicos > 9);
