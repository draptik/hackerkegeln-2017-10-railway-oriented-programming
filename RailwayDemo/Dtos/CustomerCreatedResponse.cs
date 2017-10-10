namespace RailwayDemo.Dtos
{
    public class CustomerCreatedResponse
    {
        public bool IsSuccess { get; set; } = true;

        public bool Failed => !IsSuccess;

        public string ErrorMessage { get; set; }

        public int? CustomerId { get; set; }
    }
}