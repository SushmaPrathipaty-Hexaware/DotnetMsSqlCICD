using DotnetMsSqlCICD.Entities.Entities;


namespace DotnetMsSqlCICD.Data.Interfaces
{
    public interface IEmployeeRepository : IGetById<Employee>, IGetAll<Employee>, ISave<Employee>, IUpdate<Employee>, IDelete<int>
    {
    }
}
