namespace SigmaApi.DAL
{
    public interface ICandidateRepo
    {
        void AddApplication(Candidate candidate);
        void UpdateApplication(Candidate candidate);
        Candidate FindByEmail(string email);
    }
}
