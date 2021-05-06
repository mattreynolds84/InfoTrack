using System.Collections.Generic;
using System.Threading.Tasks;

namespace InfoTrack.BusinessLogic.Services
{
    public interface IGoogleSearchService
    {
        Task<IEnumerable<int>> Search(string keywords, string uriToMatch);
    }
}
