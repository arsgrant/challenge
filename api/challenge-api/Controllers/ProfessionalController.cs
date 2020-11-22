using challenge_api.Mock;
using challenge_api.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace challenge_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessionalController
    {
        [HttpGet]
        [Route("list")]
        public IEnumerable<Professional> GetListProfessional()
        {
            MockData mock = new MockData();
            List<Professional> list = new List<Professional>();

            list = mock.GetListProfessional();

            return list;
        }

        [HttpGet]
        [Route("list-schedule/{id}")]
        public List<Schedule> GetListProfessionalSchedule(int professionalId)
        {
            MockData mock = new MockData();
            List<Schedule> list = new List<Schedule>();

            list = mock.GetListProfessionalSchedule();

            return list;
        }
    }
}
