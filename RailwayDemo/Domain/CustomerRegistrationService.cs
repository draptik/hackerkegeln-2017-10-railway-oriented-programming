using RailwayDemo.Dtos;
using RailwayDemo.NonDomain;

namespace RailwayDemo.Domain
{
    public class CustomerRegistrationService
    {
        private readonly ICustomerRepository _repository;
        private readonly IGateway _gateway;

        public CustomerRegistrationService(
            ICustomerRepository repository,
            IGateway gateway)
        {
            _repository = repository;
            _gateway = gateway;
        }

        public CustomerCreatedResponse CreateCustomer(CreateCustomerRequest request)
        {
            return null;
        }

        private Customer Map(CreateCustomerRequest request)
        {
            return new Customer { Name = request.Name };
        }
    }
}