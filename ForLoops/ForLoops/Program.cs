﻿int[] Numbers = new int[3];

Numbers[0] = 101;
Numbers[1] = 102;
Numbers[2] = 103;

for (int j = 0; j <Numbers.Length; j++)
{
    Console.WriteLine(Numbers[j]);
}

int i = 0;
while (1 < Numbers.Length)
{
    Console.WriteLine(Numbers[i]);
    i++;
}