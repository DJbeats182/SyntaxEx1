namespace SyntaxEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inferred typing
            var answer = 4;
            // string interpolation and ternary operator
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);


            // int answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}
        }
    }
}