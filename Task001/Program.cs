Console.WriteLine("Введи число: ");
int numberToCheck = Convert.ToInt32(Console.ReadLine());
if(numberToCheck==6||numberToCheck==7){
    Console.WriteLine("Номер дня недели выходной");
}
else Console.WriteLine("Номер дня недели не выходной");