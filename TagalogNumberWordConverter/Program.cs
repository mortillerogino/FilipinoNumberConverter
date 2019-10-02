using System;

namespace TagalogNumberWordConverter
{
    class Program
    {
        private static IPresenter _presenter = new ConsolePresenter();

        static void Main(string[] args)
        {
            _presenter.Output("*** Filipino Number Converter ***");
            int toConvert = _presenter.GetIntInput("Enter number to convert");

            _presenter.Output(FilipinoNumberConverter.ConvertAll(toConvert));
            _presenter.WaitForKeyPress();
        }


    }


}
