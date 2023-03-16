using System.ComponentModel.DataAnnotations;

namespace AppUploadFile.Models
{
    public class Form
    {
        [Required(ErrorMessage = "Fill in the email")]
        public string Email { get; set; }

        //[Required]
        //[FileExtensions(Extensions = "docx", ErrorMessage ="The file must be only type of 'docx'")]
        //public string FileName { get; set; }
    }
}
