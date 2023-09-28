// Task1

//Ədədlərdən ibarət arrayın elementleri cemini tapan alqoritm

//int[] arr = { 1, 3, 4, 5, 3, 2, 3, 4, 3 };
//int sum = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine($"Sum:{sum}");






//Task2 

//Sozlerden ibaret arrayde uzunlugu 4-den boyuk olan sozleri ekrana çap edin

string[] arr = { "salam", "sagol", "yox" };

for (int i = 0;i< arr.Length; i++)
{
    if (arr[i].Length>4) Console.WriteLine(arr[i]);
}
