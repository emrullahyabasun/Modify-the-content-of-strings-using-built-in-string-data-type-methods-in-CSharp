namespace Modify_the_content_of_strings_using_built_in_string_data_type_methods_in_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');
            openingPosition += 1;
            // Console.WriteLine(openingPosition);
            // Console.WriteLine(closingPosition);

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}
