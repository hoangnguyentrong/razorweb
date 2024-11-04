using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace c_.git.razorweb.Models;

  public class Article
  {
    [Key]
    public int Id {get;set;}
    [StringLength(255, MinimumLength = 5, ErrorMessage = "Tieu de phai tu {2} den {1} ki tu")]
    [Required(ErrorMessage ="{0} phai nhap")]
    [Column(TypeName ="nvarchar")]
    [Display(Name ="Ten")]
    public string Title {get;set;} = string.Empty;
    [DataType(DataType.Date)]
    [Required]
    [Display(Name ="Thoi gian")]
    public DateTime Created {get;set;}
    [Column(TypeName ="ntext")]
    [Display(Name ="Noi dung")]
    public string Content {get;set;} =string.Empty;
  }
