namespace Payroll_JSON
{
    public interface IRestResponse
    {
        string Content { get; }
        double StatusCode { get; }
    }
}