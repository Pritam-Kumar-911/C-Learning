

int[] arr = new int[5];

for (int i = 0; i < arr.Length; i++)
{   
    Console.WriteLine($"Enter value for index {i}:");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(arr);
foreach (int i in arr)
{
    Console.WriteLine(i);
}

//list

List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);

foreach (int i in list)
{
    Console.WriteLine(i);
} 