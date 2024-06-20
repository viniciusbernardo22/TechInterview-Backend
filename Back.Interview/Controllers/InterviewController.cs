using Back.Interview.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Back.Interview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterviewController : ControllerBase
    {
        private readonly ILogger<InterviewController> _logger;
        private readonly IDataInterviewRepository _dataInterviewRepository;

        public InterviewController(ILogger<InterviewController> logger, IDataInterviewRepository dataInterviewRepository)
        {
            _logger = logger;
            _dataInterviewRepository = dataInterviewRepository;
        }

        [HttpGet(Name = "GetInterview")]
        public async Task<IActionResult> GetInterviewAsync()
        {
            _logger.LogInformation("Chegamos na controller e estamos no metodo GetInterviewAsync");
            var data = await _dataInterviewRepository.GetDataAsync();
            return Ok(data);
        }
    }
}
