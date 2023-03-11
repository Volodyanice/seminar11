int[] array = new int[8];
for ( int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(1, 99);
    System.Console.Write($"{array[i]}" + ',' );
}