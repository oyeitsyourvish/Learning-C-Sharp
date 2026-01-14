using ShivaGautamCsharpCourseNotes._9_1AccessModifiers; // Project reference
public class program : AccessModifier
{
    public static void Main(string[] args)
    {
        Console.WriteLine("This is Ex Of Public Access Modifier");
        Example e = new Example();  
        e.Public(); // now we can access public method in different project(assembly)


        // If  we Inherits then also can we can access protected accModifier.
        program p  = new program();
        p.Public();
        p.Protected();
        p.ProtectedInternal();

    }

}

