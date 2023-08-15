int [] array = {1, 15, 6, 46, 4, 9616, 64, 6, 46, 46, 1};

int n = array.Length;

int index = 0;
int find = 6;

while (index < n)
{
   if(array[index]==find)
   {
    Console.WriteLine(index);
    break;
   }
   index++;
}


