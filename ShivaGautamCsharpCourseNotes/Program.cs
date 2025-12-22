internal class Program
{
    static int a, b;

    void input()
    {
        //cw is used to display the output
        Console.WriteLine("enter a value");

        //Console.Readline() by default it take string input but we want different then we need to convert it.
         a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter b value");
         b = Convert.ToInt32(Console.ReadLine());
    }
    static void add()
    {
        int c = a + b;
        Console.WriteLine("d is now :- {0}", c);
    }
    void sub()
    {
        int c = a - b;
        Console.WriteLine("d is now :- {0}", c);
    }
    void mul()
    {
        int c = a * b;
        Console.WriteLine("d is now :- {0}", c);
    }

    void div()
    {
        int c = a / b;
        Console.WriteLine("d is now :- {0}", c);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("hello world");

        //created object to access non-static or dynamic data.
        Program p = new Program();

        p.input();

        //this is static method we directly access it 
        add();

        //this is non- static method we need object to access it 
        p.sub();
    }
}
