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
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("address")]
    public string Address { get; set; }

    [Column("phone")]
    public string PhoneNumber { get; set; }

    [Column("email")]
    public string Email { get; set; }

    public Client(string name, string address,  string phoneNumber, string email){
        Name = name.ToLower().Trim();
        Address = address.ToLower().Trim();
        PhoneNumber = phoneNumber;
        Email = email.ToLower().Trim();
    }

}
