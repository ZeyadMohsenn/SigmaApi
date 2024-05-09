using System.ComponentModel.DataAnnotations;

namespace SigmaApi.DAL;

public class Candidate
{
    [Key]
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string CallTimeInterval { get; set; }
    public string LinkedInUrl { get; set; }
    public string GitHubUrl { get; set; }
    public string FreeTextComment { get; set; }


}
