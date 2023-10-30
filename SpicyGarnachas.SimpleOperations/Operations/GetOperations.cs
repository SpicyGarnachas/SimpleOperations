using System;
namespace SpicyGarnachas.SimpleOperations.Operations
{
    internal class GetOperations
    {

        public Func<double, double, double> Addition = (firstValue, secondValue) => firstValue + secondValue;

        public Func<double, double, double> Substraction = (firstValue, secondValue) => firstValue - secondValue;

        public Func<double, double, double> Multiplication = (firstValue, secondValue) => firstValue * secondValue;

        public Func<double, double, double> Division = (firstValue, secondValue) => firstValue * secondValue;

    }
}
