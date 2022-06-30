Console.WriteLine ("Введите  число");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.Write ($" Все четные числа от 1 до {numberN}: ");
while (count <= numberN)
{
   
    Console.Write (count + ", ");
    count = count + 2;
}