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
        }

        [HttpGet(Name = "GetInterview")]
        public IActionResult GetInterviewAsync()
        {
            _logger.LogInformation("Chegamos na controller e estamos no metodo GetInterviewAsync");
            var data = _dataInterviewRepository.GetDataAsync();
            return Ok(data);
        }
    }
}
