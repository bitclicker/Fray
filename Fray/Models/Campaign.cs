using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Fray.Models;

public class Campaign
{
    public long Id { get; set; }
    public DateTimeOffset CreatedDtm { get; set; }
    public DateTimeOffset StartDtm { get; set; }
    public DateTimeOffset NextSessionDtm { get; set; }
    public string Name { get; set; }
    public string OwnerId { get; set; }
    [ForeignKey("OwnerId")]
    public IdentityUser User { get; set; }
}