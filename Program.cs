int Base; 
int expoente;

int res = 1;

Console.Write("Insira a sua base: ");
Base = int.Parse(Console.ReadLine());

Console.Write("Insira o seu expoente: ");
expoente = int.Parse(Console.ReadLine());

for(int i = 0; i < expoente; i++)
{
    res = res * Base;
}

Console.WriteLine($"{Base} ^ {expoente} = {res}");