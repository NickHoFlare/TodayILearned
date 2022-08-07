using Microsoft.AspNetCore.Mvc;
using TodayILearnedApi.Models;

namespace TodayILearnedApi.Services
{
    public interface IQuotesService
    {
        Quote GetRandomQuote();
    }

    public class QuotesService: IQuotesService
    {
        private Quote mockQuote = new Quote(1, "William Crawford", "Being a student is easy. Learning requires actual work");

        public Quote GetRandomQuote()
        {
            return mockQuote;
        }
    }
}
