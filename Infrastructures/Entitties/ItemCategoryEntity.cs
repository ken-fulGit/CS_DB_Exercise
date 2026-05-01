using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS_DB_Exercise.Infrastructures.Entitties;

[Table("item_category")]
public class ItemCategoryEntity
{
    [Key]
    public int Id { set; get; }
    public String? Name { set; get; }
    public List<ItemEntity>? Items { set; get; }
}
