using DTO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BLL
{
	public class Fraction : IEquatable<Fraction>, IComparable
	{
		#region Properties
		public bool Sign { get; private set; }
		public int Numerator { get; private set; }
		public int Denominator { get; private set; }
		#endregion

		#region Constructors
		public Fraction(int numerator = 0, int denominator = 1, int number = 0)
		{
			Sign = false;
			if (denominator == 0) throw new ArgumentException();
			if ((numerator < 0 && denominator > 0) || (numerator > 0 && denominator < 0))
            {
				Sign = true;			
				if (numerator < 0 && denominator > 0)
				{
					Numerator = numerator * -1;
					Denominator = denominator;
				}
				else
				{
					Denominator = denominator * -1;
					Numerator = numerator;
				}
            }
			else
			{
				Numerator = numerator;
				Denominator = denominator;
			}
			Numerator += number * denominator;
			ReduceFraction();
		}

		public Fraction(int numerator, int denominator, bool sign)
		{
			Sign = sign;
			if (denominator == 0) throw new ArgumentException();
			if ((numerator < 0 && denominator > 0) || (numerator > 0 && denominator < 0))
			{
				if (numerator < 0 && denominator > 0)
				{
					Numerator = numerator * -1;
					Denominator = denominator;
				}
				else
				{
					Denominator = denominator * -1;
					Numerator = numerator;
				}
			}
			else
			{
				Numerator = numerator;
				Denominator = denominator;
			}

			ReduceFraction();
		}

		public Fraction(decimal inDecimal)
        {
			decimal numerator = inDecimal;
			int denominator = 1;
			while(numerator != (int)numerator)
            {
				numerator *= 10;
				denominator *= 10;
            }
			Numerator = (int)numerator;
			Denominator = denominator;
			ReduceFraction();
        }
		#endregion

		#region Operators
		public static explicit operator decimal(Fraction fraction)
		{
			return fraction.ToDecimal();
		}

		public static explicit operator string(Fraction fraction)
		{
			return fraction.ToString();
		}

		public static bool operator <(Fraction fraction1, Fraction fraction2)
        {
			return fraction1.ToDecimal() < fraction2.ToDecimal();
        }
		public static bool operator >(Fraction fraction1, Fraction fraction2)
		{
			return fraction1.ToDecimal() > fraction2.ToDecimal();
		}

		public static bool operator ==(Fraction fraction1, Fraction fraction2)
        {
			return fraction1.ToDecimal() == fraction2.ToDecimal();
		}

		public static bool operator !=(Fraction fraction1, Fraction fraction2)
        {
			return fraction1.ToDecimal() != fraction2.ToDecimal();
		}

		public static bool operator >=(Fraction fraction1, Fraction fraction2)
        {
			if (fraction1 > fraction2) return true;
			if (fraction1 == fraction2) return true;
			return false;
        }

		public static bool operator <=(Fraction fraction1, Fraction fraction2)
        {
			if (fraction1 < fraction2) return true;
			if (fraction1 == fraction2) return true;
			return false;
		}

		public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
			int num1 = fraction1.Numerator * fraction2.Denominator;
			int num2 = fraction2.Numerator * fraction1.Denominator;
			int denom = fraction1.Denominator * fraction2.Denominator;

			if (fraction1.Sign) num1 *= -1;
			if (fraction2.Sign) num2 *= -1;

			return new Fraction(num1 + num2, denom);
		}

		public static Fraction operator -(Fraction fraction1, Fraction fraction2)
		{
			int num1 = fraction1.Numerator * fraction2.Denominator;
			int num2 = fraction2.Numerator * fraction1.Denominator;
			int denom = fraction1.Denominator * fraction2.Denominator;

			if (fraction1.Sign) num1 *= -1;
			if (fraction2.Sign) num2 *= -1;

			return new Fraction(num1 - num2, denom);
		}

		public static Fraction operator *(Fraction fraction1, Fraction fraction2)
		{
			int resultNum;
			int resultDen;
			bool resultSign;

			resultNum = fraction1.Numerator * fraction2.Numerator;
			resultDen = fraction1.Denominator * fraction2.Denominator;
			resultSign = fraction1.Sign ^ fraction2.Sign;

			return new Fraction(resultNum, resultDen, resultSign);
		}

		public static Fraction operator /(Fraction fraction1, Fraction fraction2)
		{
			Fraction newFrac = new Fraction(fraction2.Denominator, fraction2.Numerator);
			return fraction1 * newFrac;
		}
		#endregion

		#region Methodes
		private static int GCD(int a, int b)
		{
			while (a != 0 && b != 0)
			{
				if (a > b)
					a %= b;
				else
					b %= a;
			}

			return a | b;
		}

		private void ReduceFraction()
		{
			int k = GCD(Numerator, Denominator);
			Numerator /= k;
			Denominator /= k;
		}

		public int CompareTo(object obj)
		{
			if (this < (Fraction)obj) return -1;
			else if (this > (Fraction)obj) return 1;
			else return 0;
		}

		public bool Equals([AllowNull] Fraction other)
        {
			if (other == null) return false;

			return ToDecimal() == other.ToDecimal();
		}

		public override bool Equals(Object o)
		{
            try
            {
				return Equals((Fraction)o);
            }
            catch (Exception)
            {
				return false;
            }
		}

        public override int GetHashCode()
        {
            return Convert.ToInt32((Numerator ^ Denominator) & 0xFFFFFFFF);
        }

		public static bool SaveToFile(Fraction frac1, string op, Fraction frac2, string result, SaveType saveType)
        {
			string[] movesToSave = new string[4];

			movesToSave[0] = frac1.ToString();
			movesToSave[1] = op;
			movesToSave[2] = frac2.ToString();
			movesToSave[3] = result;

			return DAL.Fraction.SaveToFile(movesToSave, saveType);
		}
		#endregion

		#region Casters
		public override string ToString()
		{
			StringBuilder returnedString = new StringBuilder();

			if (Sign) returnedString.Append("-");
			if (Numerator > Denominator) returnedString.Append($"{Numerator / Denominator} ");
			returnedString.Append($"{Numerator % Denominator}/{Denominator}");

			return returnedString.ToString();
		}

		public decimal ToDecimal()
        {
			decimal returnedFloat = (decimal)Numerator / Denominator;

			if (Sign) returnedFloat *= -1;

			return returnedFloat;
        }
        #endregion
    }
}
