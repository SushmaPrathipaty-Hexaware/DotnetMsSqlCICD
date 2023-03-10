using System.Collections.Generic;

namespace DotnetMsSqlCICD.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
