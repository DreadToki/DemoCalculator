namespace CalculatorApp.Interface
{
    internal interface ICommand : IBufferItem
    {
        decimal Execute(decimal arg1, decimal arg2);
    }
}
