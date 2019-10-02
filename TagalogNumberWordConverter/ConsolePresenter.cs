using System;

namespace TagalogNumberWordConverter
{
    public class ConsolePresenter : IPresenter
    {
        public void Output(string message)
        {
            Console.WriteLine(message);
        }

        public int GetIntInput(string message)
        {
            bool valid = false;
            int inputConverted = int.MinValue;

            do
            {
                Console.Write(message + ": ");
                string input = Console.ReadLine();
                valid = int.TryParse(input, out inputConverted);
            } while (!valid);

            return inputConverted;
        }

        public void WaitForKeyPress()
        {
            Console.ReadKey();
        }
    }


}
