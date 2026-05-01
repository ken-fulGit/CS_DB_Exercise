using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS_DB_Exercise.Infrastructures.Entitties;

[Table("item")]
public class ItemEntity
{
    [Key]
    public int Id { set; get; }
    public string? Name { set; get; }
    public int Price { set; get; }
    [Column("category_id")]
    public int CategoryId { set; get; }
    public ItemCategoryEntity? ItemCatogory { set; get; }
    public override string ToString()
    {
        return $"id = {Id},name = {Name},Price = {Price}, CategoryId = {CategoryId}";
    }
}
