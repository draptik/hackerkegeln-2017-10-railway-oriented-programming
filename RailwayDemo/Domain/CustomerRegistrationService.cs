using System;
using CSharpFunctionalExtensions;
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

        public CustomerCreatedResponse RegisterCustomer(CreateCustomerRequest request)
        {
            return ImplementationTwo(request);
        }

        private CustomerCreatedResponse ImplementationTwo(CreateCustomerRequest request)
        {
            return _repository.RegisterCustomerTwo("name")
            .OnSuccess(customer => _gateway.SendMailTwo(customer.Name))
            .OnBoth(x => x.IsSuccess
                ? new CustomerCreatedResponse { CustomerId = x.Value.Id }
                : new CustomerCreatedResponse { IsSuccess = false, ErrorMessage = x.Error });
        }

        private CustomerCreatedResponse ImplementationOne(CreateCustomerRequest request)
        {
            try
            {
                int id = _repository.RegisterCustomer("name");
            }
            catch (Exception e)
            {
                return new CustomerCreatedResponse { IsSuccess = false };
            }
            try
            {
                _gateway.SendMail("GOOD MORNING vietnam");
            }
            catch (Exception e)
            {
                return new CustomerCreatedResponse { IsSuccess = false };
            }

            return new CustomerCreatedResponse();
        }

        private Customer Map(CreateCustomerRequest request)
        {
            return new Customer { Name = request.Name };
        }
    }
}