using System.ComponentModel.DataAnnotations;

namespace WebPDSConfirm.Data;

public class AuthDataModel {
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string? UserName { get; set; }

    [Required]
    public string? Password { get; set; }

    [Required]
    public bool isRemember { get; set; }
}