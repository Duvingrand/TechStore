using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models;

[Table("client")]
public class Client
{
    [Key]
    [Column("nationalIdentityCard")]
    public required string Id { get; set; }

    [Column("name")]
    public required string Name { get; set; }

    [Column("address")]
    public required string Address { get; set; }

    [Column("phone")]
    public required string PhoneNumber { get; set; }

    [Column("email")]
    public required string Email { get; set; }

}
