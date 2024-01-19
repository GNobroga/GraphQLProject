using System.ComponentModel.DataAnnotations.Schema;
using GraphQL;

namespace GraphQLProject.Models;


[Table("menus")]
public class Menu 
{   
    [Id]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("price")]
    public decimal Price { get; set; }
}