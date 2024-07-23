using Layer2;
using Layer3;
namespace depen
{
    public class DependencyInjector

    {

        private static BusinessLogicLayer _businessLogicLayer;

        private static OperationStore _operationStore;

        public static BusinessLogicLayer GetBusinessLogicLayer()

        {

            if (_businessLogicLayer == null)

            {

                _operationStore = new OperationStore();

                _businessLogicLayer = new BusinessLogicLayer(_operationStore);

            }

            return _businessLogicLayer;

        }

        public static OperationStore GetOperationStore()

        {

            if (_operationStore == null)

            {

                _operationStore = new OperationStore();

            }

            return _operationStore;

        }

        public static void Main(string[] args) { }

    }

}