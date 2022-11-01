//1.Ədədlərdən ibarət arrayın ən kiçik elementini tapın

int[] num = { 40, 30, 56, 10, 5 };
int min = num[0];
for (int i = 0; i < num.Length; i++)
{
    if (num[i] < min)
    {
        min = num[i];
    }

}
Console.WriteLine(min);
Console.ReadLine();




//2.Ədədlərdən ibarət arrayda neçə rəqəm olduğunu ekrana çap edin (Məs: { 1,77,6,14} arrayında 2 rəqəm var )

int[] num = { 16, 7, 34, 6, 5, 9, 13, 23 };
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    num[i] = num[i] / 10;
    if (num[i] < 1)
    {
        count++;
    }
}
Console.WriteLine(count);
Console.ReadLine();


