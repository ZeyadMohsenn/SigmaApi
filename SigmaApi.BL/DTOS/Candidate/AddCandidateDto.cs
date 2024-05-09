using System.ComponentModel.DataAnnotations;

namespace SigmaApi.BL.DTOS.Candidate
{
    public class AddCandidateDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }
        
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        
        [Phone]
        public string PhoneNumber { get; set; }
        public string CallTimeInterval { get; set; }
        [Url]
        public string LinkedInUrl { get; set; }
        [Url]
        public string GitHubUrl { get; set; }
        
        [Required]
        [StringLength(500)]
        public string FreeTextComment { get; set; }

    }
}
