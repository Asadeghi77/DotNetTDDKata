namespace DotNetTDDKata
{
    public class FizzBuzz
    {
        public static string Fizz = "Fizz";
        public static string Buzz = "Buzz";


        public List<string> Play(int number)
        {
            if (number <= 0 ) 
                throw new ArgumentOutOfRangeException($"{number} is less than or equal to zero.");

            var result = new List<string>();

            Enumerable.Range(1, number).ToList().ForEach(i =>
             {
                 var item = i % 3 == 0 ? Fizz : null;
                 item += i % 5 == 0 ? Buzz : null;
                 result.Add(string.IsNullOrEmpty(item) ? i.ToString() : item);
             });

            return result;
        }
    }
}
