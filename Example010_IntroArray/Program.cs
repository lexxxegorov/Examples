int[] array = {1, 2, 13, 47, 55, 65, 71, 18};

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}