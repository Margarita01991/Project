//определяем метод, принимающий аргумент, и возвращающий факториал этого числа
double Factorial (int n) //тип double позволяет хранить большие числа, 
{
    // 1! = 1
    // 0! = 1 
    if(n == 1) return 1;               //НЕ ЗАБЫВАТЬ RETURN
    else return n * Factorial (n - 1);
}
//Console.WriteLine(Factorial(5)); //  1*2*3 = 6
for (int i = 1; i < 40; i++) // FOR (инициализация счетчика I; проверка условия I<COUNT; инкремент i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
    //Console.WriteLine(Factorial(i));
}
