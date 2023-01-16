
string[] array = {"miu","cat","hello","love","world"};
 
var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
 
Console.Write(string.Join(Environment.NewLine, result, 0, realSize));