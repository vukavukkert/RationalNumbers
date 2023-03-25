using System;
using RationalNumbers;

//создать класс RationalNumbers
RationalNum Num1 = new RationalNum(2, 3);
RationalNum Num2 = new RationalNum(3, 4);
RationalNum Num3 = Num1 * Num2;
RationalNum Num4 = Num1 + Num2;
RationalNum Num5 = Num1 - Num2;
RationalNum Num6 = Num1 / Num2;
Console.WriteLine(Num1.PrintRN());
Console.WriteLine(Num2.PrintRN());
Console.WriteLine(Num3.PrintRN());
Console.WriteLine(Num4.PrintRN());
Console.WriteLine(Num5.PrintRN());
Console.WriteLine(Num6.PrintRN());
Console.WriteLine(Num1 > Num2);