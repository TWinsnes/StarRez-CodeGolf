#if false
class p 
{
    static void Main() 
    {
        // this string contains the whole program and a placeholder for itself that will be added in by the Console.Write call
        var s = "class p{{static int Main(){{var s={1}{0}{1};System.Console.Write(s,s,'{1}');}}}}"; 
        System.Console.Write(s, s, '"'); // Console.Write allows for a format + vars as input, like string.format
    } 
}
#endif