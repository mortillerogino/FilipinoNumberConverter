namespace TagalogNumberWordConverter
{
    public interface IPresenter
    {
        int GetIntInput(string message);
        void Output(string message);
        void WaitForKeyPress();
    }
}