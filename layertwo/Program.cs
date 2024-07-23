using Layer3;
namespace Layer2
{
    public class BusinessLogicLayer
    {
        private OperationStore _operationStore;

        public BusinessLogicLayer(OperationStore operationStore)
        {
            _operationStore = operationStore;
        }

        public static void Main(string[] args) { }

        public int BinaryOpp(string operation, int num1, int num2)
        {
            switch (operation)
            {
                case "Addition":
                    return num1 + num2;
                case "Subtraction":
                    return num1 - num2;
                case "Multiply":
                    return num1 * num2;
                case "Division":
                    return num1 / num2;
                default:
                    throw new NotImplementedException();
            }
        }

        public void GeometryCal(int radius, out float area, out float volume)
        {
            var circle = new Circle();
            area = circle.pi * radius * radius;
            volume = circle.VolumeConstant * circle.pi * radius * radius * radius;
        }

        public void StoreOperation(string name, string operation)
        {
            _operationStore.Name = name;
            _operationStore.Operation = operation;
            _operationStore.PrintStoredOperation();
        }
    }
}
