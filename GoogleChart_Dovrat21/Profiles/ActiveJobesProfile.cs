using AutoMapper;
using GoogleChart_Dovrat21.Dtos;
using GoogleChart_Dovrat21.Models;

namespace GoogleChart_Dovrat21.Profiles
{
    public class JobsProfile: Profile
    {
        public JobsProfile()
        {
            // Source -> Target
            CreateMap<ActiveJob, ActiveJobReadDto>();
            CreateMap<ActiveJobCreateDto, ActiveJob>();
            CreateMap<jobView, JobViewReadDto>();
            CreateMap<PredictedJobView, PredictedJobViewReadDto>();



        }
       
    }
}
