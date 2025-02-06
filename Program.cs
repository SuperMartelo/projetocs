Random dados = new Random();
int jogo = dados.Next(1, 7);
int jogo2 = dados.Next(1, 7);
int jogo3 = dados.Next(1, 7);

int total = jogo + jogo2 + jogo3;

Console.WriteLine("Quer jogar? y ou n");
var resposta = Console.ReadLine();
{
    if (resposta == "y")
    Console.WriteLine("Beleza! São três dados e tres valores, se esses valores atngirem 15 voce ganha.");
    Console.WriteLine($"E o resultado do primeiro dado é {jogo}, do segundo {jogo2} e do terceiro {jogo3} e o total é: {total}");
}
{
    if (total >14)
    Console.WriteLine("Parabéns, você venceu desta vez!");


    else if(total < 15)
    Console.WriteLine("ha! hoje não Cowboy.");
}