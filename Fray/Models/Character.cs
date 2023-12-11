using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Fray.Models;

public class Character
{
    public long Id { get; set; }
    public DateTimeOffset CreatedDtm { get; set; }
    public string OwnerId { get; set; }
    [ForeignKey("OwnerId")]
    public IdentityUser User { get; set; }
    public string Name { get; set; }
 
}