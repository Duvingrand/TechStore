using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TechStore.Models;

[Table("order")]
public class Order
{
    [Column("id")]
    public Guid Id { get; set; }
    [Column("clientId")]
    public int ClientId { get; set; }
    [Column("date")]
    public DateTime Date { get; set; }
    [Column("statusId")]
    public int StatusId { get; set; }

    [JsonIgnore]
    [ForeignKey("ClientId")]
    public Client? Client { get; set; }

    [JsonIgnore]
    [ForeignKey("StatusId")]
    public OrderStatus? OrderStatus { get; set; }

    public Order(int clientId, int statusId){
        Id=Guid.NewGuid();
        ClientId = clientId;
        Date = DateTime.Now;
        StatusId = statusId;
    }

}
