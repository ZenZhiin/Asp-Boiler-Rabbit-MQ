using System.ComponentModel.DataAnnotations;

namespace Test.Test.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}