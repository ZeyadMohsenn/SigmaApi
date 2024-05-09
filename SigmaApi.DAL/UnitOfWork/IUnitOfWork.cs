using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaApi.DAL
{
    public interface IUnitOfWork
    {
        public ICandidateRepo CandidateRepo { get; }

        int SaveChanges();
    }
}
