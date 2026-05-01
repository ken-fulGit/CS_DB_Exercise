using System.Reflection;
using CS_DB_Exercise.Infrastructures.Queries;
using CS_DB_Exercise.Infrastructures;
namespace CS_DB_Exercise;

class Program
{
    static void Main(string[] args)
    {

        DepartementAccessor departementAccessor = new(new AppDbContext());
        departementAccessor.FindAll()?.ForEach(e => Console.WriteLine(e));
        var dept = departementAccessor.FindById(1);
        Console.WriteLine(dept);
    }
}
