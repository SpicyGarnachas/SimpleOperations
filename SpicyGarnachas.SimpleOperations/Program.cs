using SpicyGarnachas.SimpleOperations.MessageValues.GetMessage;
using SpicyGarnachas.SimpleOperations.MessageValues.GetMessageException;
using SpicyGarnachas.SimpleOperations.Operations;
using SpicyGarnachas.SimpleOperations.Operations.Values;
using System;

namespace SpicyGarnachas.SimpleOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            bool programIsActive = true;
            Values Value = new Values();
            GetMessage Message = new GetMessage();
            GetOperations Operation = new GetOperations();
            GetMessageException MessageException = new GetMessageException();
            while (programIsActive)
            {
                try
                {
                    Console.WriteLine(Message.MessageSeparator);
                    Console.WriteLine(Message.InsertFirstValue);
                    Console.WriteLine(Message.MessageSeparator);
                    Value.FirstValue = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Message.MessageSeparator);
                    Console.WriteLine(Message.InsertSecondValue);
                    Console.WriteLine(Message.MessageSeparator);
                    Value.SecondValue = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Message.MessageSeparator);
                    Console.WriteLine("The result is :");
                    Console.WriteLine($"{Value.FirstValue} +  {Value.SecondValue} = {Operation.Addition(Value.FirstValue, Value.SecondValue)}");
                    Console.WriteLine($"{Value.FirstValue} -  {Value.SecondValue} = {Operation.Substraction(Value.FirstValue, Value.SecondValue)}");
                    Console.WriteLine($"{Value.FirstValue} *  {Value.SecondValue} = {Operation.Multiplication(Value.FirstValue, Value.SecondValue)}");
                    Console.WriteLine($"{Value.FirstValue} /  {Value.SecondValue} = {Operation.Division(Value.FirstValue, Value.SecondValue)}");
                    Console.WriteLine(Message.MessageSeparator);
                    Console.ReadKey();
                    Console.WriteLine(Message.DoTheOperationAgain);
                    //System.Formatexeption
                    selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "n":
                            programIsActive = false;
                            break;
                        case "y":
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine(Message.InvalidSelection);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(Message.MessageSeparator);
                    Console.WriteLine(MessageException.FormatExceptionMessage);
                    Console.WriteLine(Message.MessageSeparator);
                }
            }
        }
    }
}
