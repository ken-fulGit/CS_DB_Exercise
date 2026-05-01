using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS_DB_Exercise.Infrastructures.Entitties;

[Table("employee")]
public class EmployeeEntity
{
    [Key]
    [Column("id")]
    public int Id { set; get; }
    [Column("name")]
    public string? Name { set; get; }
    [Column("dept_id")]
    public int DeptId { set; get; }

    public DepartmentEntity? Department { set; get; }
    public override string ToString()
    {
        return $"Id = {Id}, Name = {Name} , DeptId = {DeptId}";
    }
}
