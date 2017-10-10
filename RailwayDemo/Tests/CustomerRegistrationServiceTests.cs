using NSubstitute;
using RailwayDemo.NonDomain;
using Xunit;

namespace RailwayDemo.Tests
{
    public class CustomerRegistrationServiceTests
    {
        private readonly ICustomerRepository _repo;
        private readonly IGateway _gateway;

        public CustomerRegistrationServiceTests()
        {
            _repo = Substitute.For<ICustomerRepository>();
            _gateway = Substitute.For<IGateway>();
        }

        [Fact]
        public void RegisterCustomer_happycase_returns_successfull_response()
        {
        }

        [Fact]
        public void RegisterCustomer_with_failing_repository_returns_failure_response()
        {
        }

        [Fact]
        public void RegisterCustomer_with_failing_gateway_returns_failure_response()
        {
        }
    }
}