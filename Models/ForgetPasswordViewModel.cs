
using System.ComponentModel.DataAnnotations;

public class ForgetPasswordViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }
};