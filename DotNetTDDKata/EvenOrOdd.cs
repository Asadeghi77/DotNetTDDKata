namespace DotNetTDDKata
{
    public class EvenOrOdd
    {
        public EvenOdd GetEvenOddtype(IEnumerable<int> numbers)
        {
            return numbers.Sum() % 2 == 0 ? EvenOdd.Even : EvenOdd.Odd;
        }
    }
}
