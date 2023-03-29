using static System.Console;
using static System.String;

public static class Infrastr
{

public static int[] CreateArray(this int size, int min = 0, int max = 100)
{
return Enumerable.Range(1, size)
            .Select(item => Random.Shared.Next(min, max))
            .ToArray();
}
public static int[] Show(this int[] array, string separator = ","){
string output = Join(separator, array);
WriteLine($"[{output}]");
return array;

}

 
}