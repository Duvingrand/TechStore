using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models;

[Table("user")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("lastname")]
    public string LastName { get; set; }
    [Column("role")]
    public bool Role { get; set; }
    [Column("email")]
    public string Email { get; set; }
    [Column("password")]
    public string Password { get; set; }


    public User(string name, string lastName, bool role, string email, string password)
    {
        Name = name.ToLower().Trim();
        LastName = lastName.ToLower().Trim();
        Role = role;
        Email = email.ToLower().Trim();
        Password = password;
    }


}
