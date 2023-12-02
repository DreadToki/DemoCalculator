namespace CalculatorApp.Interface
{
    internal interface ICommand : IBufferItem
    {
        sbyte Weight { get; }
        decimal Execute(decimal arg1, decimal arg2);
    }
}
