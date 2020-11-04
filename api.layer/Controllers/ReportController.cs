using api.layer.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.layer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : Controller
    {
        private readonly IGitActionsManager _gitActionsManager;

        public ReportController(IGitActionsManager gitActionsManager)
        {
            var test = "123213";
            var test1 = "123213";
            _gitActionsManager = gitActionsManager;
        }

        [HttpGet]
        public async Task<List<RatingEntity>> Get()
        {
            return await _gitActionsManager.FetchRaitingReport();
        }
    }
}
