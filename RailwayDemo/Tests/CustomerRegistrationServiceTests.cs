using System;
using CSharpFunctionalExtensions;
using FluentAssertions;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using RailwayDemo.Domain;
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

            _repo.RegisterCustomerTwo(Arg.Any<string>()).Returns(Result.Ok(new Customer()));
            _gateway.SendMailTwo(Arg.Any<string>()).Returns(Result.Ok(new Customer()));
        }

        [Fact]
        public void RegisterCustomer_happycase_returns_successfull_response()
        {
            var sut = new CustomerRegistrationService(_repo, _gateway);
            Dtos.CreateCustomerRequest request = new Dtos.CreateCustomerRequest {Name="Foo"};

            var response = sut.RegisterCustomer(request);

            response.IsSuccess.Should().BeTrue("because we are in the happy case");
        }

        [Fact]
        public void RegisterCustomer_with_failing_repository_returns_failure_response()
        {
            var sut = new CustomerRegistrationService(_repo, _gateway);
            Dtos.CreateCustomerRequest request = new Dtos.CreateCustomerRequest {Name="Foo"};

            _repo.RegisterCustomerTwo(Arg.Any<string>()).Returns(Result.Fail<Customer>("new Customer()"));
            var response = sut.RegisterCustomer(request);
            response.IsSuccess.Should().BeFalse("because we are NOT in the happy case");
        }

        [Fact]
        public void RegisterCustomer_with_failing_gateway_returns_failure_response()
        {
            var sut = new CustomerRegistrationService(_repo, _gateway);
            Dtos.CreateCustomerRequest request = new Dtos.CreateCustomerRequest {Name="Foo"};

            _gateway.SendMailTwo(Arg.Any<string>()).Returns(Result.Fail<Customer>("send mail new Customer()"));

            var response = sut.RegisterCustomer(request);
            response.IsSuccess.Should().BeFalse("because we are NOT in the happy case");
        }
    }
}