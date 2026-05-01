using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_DB_Exercise.Infrastructures.Entitties;

namespace CS_DB_Exercise.Infrastructures.Queries;

public class DepartementAccessor
{
    private readonly AppDbContext _context;
    public DepartementAccessor(AppDbContext context)
    {
        _context = context;
    }
    public DepartmentEntity? FindById(int departmentId)
    {
        return _context.Departments?.Find(departmentId);
    }
    public List<DepartmentEntity>? FindAll()
    {
        return _context.Departments?.ToList();
    }
}
