namespace BLL
{
    public static class ExtentionsDecimal
    {
        public static Fraction ToFraction(this decimal fraction)
        {
            return new Fraction(fraction);
        }
    }
}
