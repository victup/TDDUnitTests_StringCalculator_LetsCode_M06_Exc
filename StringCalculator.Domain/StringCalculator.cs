namespace StringCalculator.Domain
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
                return 0;

            var parts = numbers.Split(",");

            var exceedsCount = parts.Length >2 ;
            var consecultiveCommads = parts.Any(x => x == "");
            var nonNumbers = parts.Any(x => !int.TryParse(x, out _));


            if (exceedsCount || consecultiveCommads || nonNumbers)
                throw new ArgumentException(nameof(numbers));


            var sum = parts.Sum(x => Convert.ToInt32(x));

            return sum;
        }
    }
}