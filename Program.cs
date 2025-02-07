Random dados = new Random();
int jogo2 = dados.Next(1,7);
int jogo3 = dados.Next(1,7);
int jogo  = dados.Next(1,7);

int total = jogo + jogo2 + jogo3;
Console.WriteLine("Esse é o jogo, são três dados e três valores, se esses valores atngirem 15 ou mais você ganha.\nE se você tirar dois dados iguais você ganha 2 pontos adicionais. E se você tirar incríveis 3 dados iguais receberá +6 pontos bonus!");
Console.WriteLine("Quer jogar? y ou n");
var resposta = Console.ReadLine();
    //bonus
    if ((jogo == jogo2) || (jogo2 == jogo3) || (jogo == jogo3))
    {
        if((jogo == jogo2) && (jogo2 == jogo3))
        {
            Console.WriteLine("Dados triplos! +6 pontos bonus!");
            total += 6;
        }
        else   
        {   
            Console.WriteLine("Dois dados iguais! que sorte! tome +2 pontos.");
            total += 2;
        }
    }
    //resposta da partida
    if (resposta == "y")
    {
        Console.WriteLine($"E o resultado do primeiro dado é {jogo}, do segundo {jogo2} e do terceiro {jogo3} e o total incluindo o bonus é: {total}");
    }
    if (total >=16)
    {
        Console.WriteLine("Parabéns, você venceu ganhou um carro novo!");
    }
    else if (total >= 10)
    {
        Console.WriteLine("Você ganhou um laptop!");
    }
    else if (total == 7)
    {
        Console.WriteLine("7! número da sorte! Uma viagem para duas pessoas.");
    }
    else 
    {
        Console.WriteLine("o seu prêmio de consolação, um gatinho, melhor que todos os outros btw");
    }