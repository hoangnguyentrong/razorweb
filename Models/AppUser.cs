using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace c_.git.razorweb.Models
{
  public class AppUser : IdentityUser
  {
    [Column(TypeName ="nvarchar")]
    [StringLength(255)]
    public string HomeAddress {get;set;} = string.Empty;
  }
}