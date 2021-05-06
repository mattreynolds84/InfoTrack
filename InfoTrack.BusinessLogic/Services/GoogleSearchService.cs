using InfoTrack.DataAccess.Repositories;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InfoTrack.BusinessLogic.Services
{
    public class GoogleSearchService : IGoogleSearchService
    {
        private readonly IGoogleSearchRepository _googleSearchRepository;
        public GoogleSearchService(IGoogleSearchRepository googleSearchRepository)
        {
            _googleSearchRepository = googleSearchRepository;
        }

        public async Task<IEnumerable<int>> Search(string keywords, string uriToMatch)
        {
            var responseMessage = await _googleSearchRepository.GetResponse(keywords);           

            return ProcessResponse(responseMessage, uriToMatch);
        }
        
        public IEnumerable<int> ProcessResponse(string response, string uriToMatch)
        {
            var regEx = new Regex("<div class=.kCrYT.><a href");
            var matches = regEx.Matches(response);

            var results = new List<int>();
            
            for (int i = 0; i < matches.Count; i++)
            {
                var currentMatch = matches[i];
                var stopPosition = i == matches.Count - 1? response.Length : matches[i + 1].Index;
                var subString = response.Substring(currentMatch.Index, stopPosition - currentMatch.Index);
                if (subString.Contains(uriToMatch))
                {
                    results.Add(i + 1);
                }
            }
            return results;
        }
    }
}
