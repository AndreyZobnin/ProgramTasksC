int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int [N];

int i = 0;
int square = 0;
while ( i < N)
{
    array[i] = (i + 1) * (i + 1);
    square = array[i] * array[i];
    Console.Write(square + "");

    //array[i] = (i + 1) * (i + 1);
 
    i++;    
}

