int soma = 0;

for(int i = 0; i <= 500; i++)
{
    if(i % 2 != 0 && i % 3 == 0)
    {
        soma += i;
    }
}

Console.WriteLine($"A soma dos nnumeros impares do 1 ao 500 é: {soma}");