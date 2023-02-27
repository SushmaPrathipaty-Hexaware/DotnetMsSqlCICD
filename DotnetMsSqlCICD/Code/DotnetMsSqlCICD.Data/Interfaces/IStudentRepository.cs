using DotnetMsSqlCICD.Entities.Entities;


namespace DotnetMsSqlCICD.Data.Interfaces
{
    public interface IStudentRepository : IGetById<Student>, IGetAll<Student>, ISave<Student>, IUpdate<Student>, IDelete<int>
    {
    }
}
