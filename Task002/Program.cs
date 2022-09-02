Console.WriteLine("Введи первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == numberB*numberB){
    Console.WriteLine(numberA+" является квадратом "+numberB);
}
else if (numberB == numberA*numberA){
    Console.WriteLine(numberB+" является квадратом "+numberA);
}
else{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
    }