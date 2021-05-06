using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrack.DataAccess.Repositories
{
    public interface IGoogleSearchRepository
    {
        Task<string> GetResponse(string keywords);
    }
}
