int[,] multiDimentional = new int[4, 4]
{
    {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12},
    {13,14,15,16}
};

var rows = multiDimentional.GetLength(0);
var columns = multiDimentional.GetLength(1);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(multiDimentional[i, j] + " ");
    }
Console.WriteLine();
}