using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace c_.git.razorweb.Models
{
  public class Article
  {
    [Key]
    public int Id {get;set;}
    [MaxLength(255)]
    [Required]
    [Column(TypeName ="nvarchar")]
    public string Title {get;set;} = string.Empty;
    [DataType(DataType.Date)]
    [Required]
    public DateTime Created {get;set;}
    [Column(TypeName ="ntext")]
    public string Content {get;set;} =string.Empty;
  }
}