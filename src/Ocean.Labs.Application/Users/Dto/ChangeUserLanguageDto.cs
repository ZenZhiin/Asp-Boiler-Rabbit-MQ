using System.ComponentModel.DataAnnotations;

namespace Ocean.Labs.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}