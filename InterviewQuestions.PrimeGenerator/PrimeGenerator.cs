using System;

namespace InterviewQuestions.PrimeGenerator
{
    public class PrimeGenerator
    {
        private static bool[] _crossedOut;
        private static int[] _result;

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue < 2)
                return new int[0];
            else
            {
                UncrossIntegersUpTo(maxValue);
                CrossOutMultiples();
                PutUncrossedIntegersIntoResult();
                return _result;
            }
        }

        private static void UncrossIntegersUpTo(int maxValue)
        {
            _crossedOut = new bool[maxValue + 1];
            for (int i = 2; i < _crossedOut.Length; i++)
                _crossedOut[i] = false;
        }

        private static void PutUncrossedIntegersIntoResult()
        {
            _result = new int[NumberOfUncrossedIntegers()];
            for (int j = 0, i = 2; i < _crossedOut.Length; i++)
            {
                if (NotCrossed(i))
                    _result[j++] = i;
            }
        }

        private static int NumberOfUncrossedIntegers()
        {
            int count = 0;
            for (int i = 2; i < _crossedOut.Length; i++)
            {
                if (NotCrossed(i))
                    count++; // увеличить счетчик
            }
            return count;
        }

        private static void CrossOutMultiples()
        {
            int limit = DetermineIterationLimit();
            for (int i = 2; i <= limit; i++)
            {
                if (NotCrossed(i))
                    CrossOutputMultiplesOf(i);
            }
        }

        private static int DetermineIterationLimit()
        {
            // У каждого составного числа в этом массиве есть простой
            // множитель, меньший или равный квадратному корню из размера
            // массива, поэтому необязательно вычеркивать кратные, большие
            // корня.
            double iterationLimit = Math.Sqrt(_crossedOut.Length);
            return (int) iterationLimit;
        }

        private static void CrossOutputMultiplesOf(int i)
        {
            for (int multiple = 2*i;
                multiple < _crossedOut.Length;
                multiple += i)
                _crossedOut[multiple] = true;
        }

        private static bool NotCrossed(int i)
        {
            return _crossedOut[i] == false;
        }
    }
}