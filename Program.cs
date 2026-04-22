int num1, num2, mult;
int mmc, mdc=0;

Console.WriteLine("Insira o seu 1° numero: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o seu 2° numero: ");
num2 = int.Parse(Console.ReadLine());

mult = num1 * num2;

while(num2 != 0)
{
    mdc = num2;
    num2 = num1 % num2;
    num1 = mdc;
}

mmc = mult / mdc;

Console.WriteLine($"Mdc= {mdc} Mmc= {mmc}");