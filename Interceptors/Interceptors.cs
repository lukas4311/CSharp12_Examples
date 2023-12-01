using System.Runtime.CompilerServices;

namespace InterceptorsTest
{
    public static class CodeGenerator
    {
        [InterceptsLocation("""C:\Users\lukas.salficky\Documents\VS\CSharp12_Examples\Interceptors\Program.cs""", line: 7, character: 16)]
        public static void EnrollInterceptor(this Student studentExample, string StudentName)
        {
            Console.WriteLine($"This is a new way of Student {StudentName} registration");
        }
    }
}