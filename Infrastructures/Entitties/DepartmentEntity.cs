using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS_DB_Exercise.Infrastructures.Entitties;

[Table("department")]
public class DepartmentEntity
{
    [Key]
    [Column("id")]
    public int Id { set; get; }
    [Column("name")]
    public string? Name { set; get; }
    public override string ToString()
    {
        return $"Name = {Name}, Id = {Id}";
    }
}
