Random random = new Random();
int number = random.Next(10,100);
int b = number/10;
int c = number % 10;
Console.WriteLine(number);

if(b > c){
    Console.WriteLine($"Первая цифра больше второй. Её значение {b}");
}

else if (c > b)
{
    Console.WriteLine($"Вторая цифра больше первой. Её значение {c}");
}
else{
    Console.WriteLine("Первая цифра равна второй");
}

//Варианты вывода в консоль//
// 1.Console.WriteLine("Первая цифра больше второй. Её значение:");
//Console.WriteLine(b);
// 2. Console.WriteLine("Первая цифра больше второй" + b);
// 3. Console.WriteLine($"Первая цифра больше второй {b}");