using DotnetMsSqlCICD.Entities.Entities;


namespace DotnetMsSqlCICD.Data.Interfaces
{
    public interface ITeacherRepository : IGetById<Teacher>, IGetAll<Teacher>, ISave<Teacher>, IUpdate<Teacher>, IDelete<int>
    {
    }
}
