// Original Freach array for loop
//int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
//int total = 0;
//for (int index = 0; index < array.Length; index++)
//    total += array[index];
//float average = (float)total / array.Length;
//Console.WriteLine(average);


// New Freach foreach array loop
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int num in array)
    total += num;
float average = (float)total / array.Length;
Console.WriteLine(average);


