using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TechStore.Models;
[Table("product")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("price")]
    public double Price { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("categoryId")]
    public int CategoryId { get; set; }
    [JsonIgnore]
    [ForeignKey("CategoryId")]
    public Categorie? Category { get; set; }

    public Product(string name, double price, string description, int categoryId){
        Name = name.ToLower().Trim();
        Price = price;
        Description = description;
        CategoryId = categoryId;
    }
}
