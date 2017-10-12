using CSharpFunctionalExtensions;
using RailwayDemo.Domain;

namespace RailwayDemo.NonDomain
{
    public interface IGateway
    {
        bool SendMail(string v);
        Result<Customer> SendMailTwo(string eMail);
    }
}