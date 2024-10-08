using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TechStore.Models;
[Table("productsInOrder")]
public class ProductsInOrder
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("productQuantity")]
    public int ProductQuantity { get; set; }

    [Column("productId")]
    public int ProductId { get; set; }
    [JsonIgnore]
    [ForeignKey("ProductId")]
    public Product? Product { get; set; }

    [Column("orderId")]
    public Guid OrderId { get; set; }
    [JsonIgnore]
    [ForeignKey("OrderId")]
    public Order? Order { get; set; }

    public ProductsInOrder(int productQuantity, int productId, Guid orderId){
        ProductQuantity = productQuantity;
        ProductId = productId;
        OrderId = orderId;
    }

}
