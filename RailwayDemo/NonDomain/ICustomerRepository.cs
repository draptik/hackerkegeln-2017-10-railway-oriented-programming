using CSharpFunctionalExtensions;
using RailwayDemo.Domain;
using RailwayDemo.Dtos;

namespace RailwayDemo.NonDomain
{
    public interface ICustomerRepository
    {
        int RegisterCustomer(string name);
        Result<Customer> RegisterCustomerTwo(string name);
    }

    // public class CustomerRepository : ICustomerRepository
    // {
    //     public int RegisterCustomer(string name)
    //     {
    //         return 42;            
    //     }

    //     public Result<Customer> RegisterCustomerTwo(string name)
    //     {
    //         if(true) 
    //         {
    //             return Result.Ok(new Customer());
    //         }
    //         else
    //         {
    //             return Result.Fail<Customer>("IamFailed");
    //         }
    //     }
    // }

}