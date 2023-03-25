using System;
using System.Collections.Generic;
using System.Text;

namespace RationalNumbers
{
    class RationalNum
    {
        private int M { get; set; }
        private int N { get; set; }

        public RationalNum(int m, int n)
        {
            M = m;
            N = n;
        }
        public string PrintRN()
        {
            return $"{M}/{N}";
        }
        public static RationalNum operator *(RationalNum Num1, RationalNum Num2)
        {
            int n, m;
            n = Num1.N * Num2.N;
            m = Num1.M * Num2.M;
            return new RationalNum(m, n);
        }
        public static RationalNum operator /(RationalNum Num1, RationalNum Num2)
        {
            int n, m;
            n = Num1.N * Num2.M;
            m = Num1.M * Num2.N;
            return new RationalNum(m, n);
        }
        public static RationalNum operator +(RationalNum Num1, RationalNum Num2)
        {
            int n, m;
            n = Num1.N * Num2.N;
            m = Num1.M * Num2.N + Num2.M * Num1.N;
            return new RationalNum(m, n);
        }
        public static RationalNum operator -(RationalNum Num1, RationalNum Num2)
        {
            int n, m;
            n = Num1.N * Num2.N;
            m = Num1.M * Num2.N - Num2.M * Num1.N;
            return new RationalNum(m, n);
        }
        public static bool operator ==(RationalNum Num1, RationalNum Num2)
        {
            return Num1.N * Num2.M == Num1.M * Num2.N;
        }
        public static bool operator !=(RationalNum Num1, RationalNum Num2)
        {
            return Num1.N * Num2.M != Num1.M * Num2.N;
        }
        public static bool operator > (RationalNum Num1, RationalNum Num2)
        {
            return Num1.N * Num2.M > Num1.M * Num2.N;
        }
        public static bool operator < (RationalNum Num1, RationalNum Num2)
        {
            return Num1.N * Num2.M < Num1.M * Num2.N;
        }
    }
}
