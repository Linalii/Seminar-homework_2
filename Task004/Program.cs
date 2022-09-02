double findDistance (double x1,double y1,double z1 ,double x2 ,double y2 ,double z2){
    return Math. Sqrt(Math.Pow(x2 - x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
}
Random random = new Random();
double x1 = random.Next(1,9);
double x2 = random.Next(1,9);
double y1 = random.Next(1,9);
double y2 = random.Next(1,9);
double z1 = random.Next(1,9);
double z2 = random.Next(1,9);
Console.WriteLine("Заданные координаты: A("+x1+", "+y1+", "+z1+") и B("+x2+", "+y2+", "+z2+")");
Console.WriteLine("Расстояние между точками A и B = "+findDistance(x1,y1,z1,x2,y2,z2));