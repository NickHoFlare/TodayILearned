using Microsoft.AspNetCore.Mvc;
using TodayILearnedApi.Models;
using TodayILearnedApi.Services;

namespace TodayILearnedApi.Controllers
{
    [ApiController]
    [Route("api/quotes")]
    public class QuotesController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly IQuotesService _quotesService;

        public QuotesController(ILogger<PostsController> logger, IQuotesService quotesService)
        {
            _logger = logger;
            _quotesService = quotesService;
        }

        [HttpGet("random", Name = "GetRandomQuote")]
        public ActionResult<List<Quote>> GetRandomQuote()
        {
            return Ok(_quotesService.GetRandomQuote());
        }
    }
}