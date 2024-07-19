namespace CalculatorApp.Commands
{
    internal class Commands
    {
        public static AddCommand AddCommand => new AddCommand();

        public static SubtractCommand SubtractCommand => new SubtractCommand();

        public static MultiplyCommand MultiplyCommand => new MultiplyCommand();

        public static DivideCommand DivideCommand => new DivideCommand();

        public static PowerCommand PowerCommand => new PowerCommand();

        public static RootCommand RootCommand => new RootCommand();
    }
}
