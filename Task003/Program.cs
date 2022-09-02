int returnQuarterNumber(int x, int y){
    int result;
    if(x<0){
        if(y<0){
            return 3;
        }
        else return 2;
    }
    else{
        if(y>0){
            return 1;
        }
        else return 4;
    }
    return result;
}


Console.WriteLine("Введи x: ");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи y: ");
int numberY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(returnQuarterNumber(numberX,numberY));


