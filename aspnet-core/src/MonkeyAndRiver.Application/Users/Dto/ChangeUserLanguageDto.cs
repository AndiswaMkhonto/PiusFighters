using System.ComponentModel.DataAnnotations;

namespace MonkeyAndRiver.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}