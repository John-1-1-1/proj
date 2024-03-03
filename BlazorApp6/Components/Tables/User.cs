using System.ComponentModel.DataAnnotations;
using BlazorApp6.Components.Validators;

namespace BlazorApp6.Components.Tables;

public class User {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле является обязательным.")]
    [Display(Name = "Name")]
    public string Name { get; set; } = "";
        
    [Required(ErrorMessage = "Поле является обязательным.")]
    [Display(Name = "LastName")]
    public string LastName { get; set; } = "";
        
    [Required(ErrorMessage = "Поле является обязательным.")]
    [Display(Name = "MiddleName")]
    public string MiddleName { get; set; } = "";
        
    [Required(ErrorMessage = "Поле является обязательным.")]
    [Display(Name = "Telephone")]
    public string Telephone { get; set; } = "";
        
    [Required(ErrorMessage = "Поле является обязательным.")]
    [Display(Name = "City")]
    public string City { get; set; } = "";
        
    [Required(ErrorMessage = "Поле является обязательным.")]
    [Display(Name = "School")]
    public string School { get; set; } = "";
        
    [Required(ErrorMessage = "Поле является обязательным.")]
    [Display(Name = "Class")]
    public int Class { get; set; }

    [Required(ErrorMessage = "Поле является обязательным.")]
    [Display(Name = "DateBirth")]
    [RAgeValidator()]
    public DateOnly DateBirth { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        
    [Required(ErrorMessage = "Поле является обязательным.")]
    [EmailAddress(ErrorMessage = "Почта не является действительной.")]
    [Display(Name = "Email")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Поле является обязательным.")]
    [StringLength(100, ErrorMessage = "Длина {0} должна быть не менее {2} и не более {1} символов.", MinimumLength = 8)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; } = "";
}