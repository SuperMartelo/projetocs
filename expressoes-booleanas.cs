//unidade 4 renovação de assinaturas
Random random = new Random();
int diasateexpirar = random.Next(12);
//int diasateexpirar = 11;
int porcentagemdedesconto = 0;

if (diasateexpirar == 11)
{}

else if (diasateexpirar  >= 6)
{
    Console.WriteLine($"sua subscrição expira em {diasateexpirar} dias! Renove agora!");
}
else if (diasateexpirar >= 2)
{
    Console.WriteLine($"Você ainda tem {diasateexpirar} dias!");
        porcentagemdedesconto += 10;
    Console.WriteLine($"Renove agora e ganhe {porcentagemdedesconto}%!");
}
else if (diasateexpirar == 1)
{
    Console.WriteLine($"sua subscrição termina em {diasateexpirar} dia!");
    porcentagemdedesconto += 20;
    Console.WriteLine($"Renove agora e salve 20%");
}
else
{
        porcentagemdedesconto +=30;
    Console.WriteLine($"Sua subscrição acabou! renove agora e ganhe {porcentagemdedesconto}");
}