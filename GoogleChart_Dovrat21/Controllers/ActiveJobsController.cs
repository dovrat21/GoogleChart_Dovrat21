using AutoMapper;
using GoogleChart_Dovrat21.Data;
using GoogleChart_Dovrat21.Dtos;
using GoogleChart_Dovrat21.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoogleChart_Dovrat21.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CampaignJobsController: ControllerBase
    {
        private readonly IActiveJobsRepo _activeJobsRepo;
        private readonly IJobsViewsRepo _jobsViewsRepo;
        private readonly IPredictedJobViewRepo _predictedJobViewRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<CampaignJobsController> _logger;

        public CampaignJobsController(IActiveJobsRepo activeJobsRepo, IJobsViewsRepo jobsViewsRepo, IPredictedJobViewRepo predictedJobViewRepo, IMapper mapper, ILogger<CampaignJobsController> logger)
        {
            _activeJobsRepo = activeJobsRepo;
            _jobsViewsRepo = jobsViewsRepo;
            _predictedJobViewRepo = predictedJobViewRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ActiveJobReadDto>> GetActiveJobs()
        {
            _logger.LogInformation("--> Getting ActiveJobs ...");
            var AllActiveJobs = _activeJobsRepo.GetAllActiveJobs();
            if (AllActiveJobs != null)
            {
                return Ok(_mapper.Map<IEnumerable<ActiveJobReadDto>>(AllActiveJobs));
            }
            else
            {
                _logger.LogInformation("--> No ActiveJobs ...");
                return Ok(null);

            }
            
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<JobViewReadDto>> GetJobsViews(string id)
        {
            _logger.LogInformation("--> Getting JobsViews ...");
            var AllJobsViews = _jobsViewsRepo.GetAllJobsViews().OrderBy(r=>r.Id).ToList();
            if (AllJobsViews != null)
            {
                return Ok(_mapper.Map<IEnumerable<JobViewReadDto>>(AllJobsViews));
            }
            else
            {
                _logger.LogInformation("--> No Jobs views ...");
                return Ok(null);

            }

        }

        [HttpGet("{id}/{name}")]
        public ActionResult<IEnumerable<PredictedJobViewReadDto>> PredictedJobView(string id, string name)
        {
            _logger.LogInformation("--> Getting PredictedJobView ...");
            var AllPredictedJobView = _predictedJobViewRepo.GetAllPredictedJobView().OrderBy(r => r.Id).ToList(); ;
            if (PredictedJobView != null)
            {
                return Ok(_mapper.Map<IEnumerable<PredictedJobViewReadDto>>(AllPredictedJobView));
            }
            else
            {
                _logger.LogInformation("--> No predicted Jobs views ...");
                return Ok(null);

            }

        }


    }
}
