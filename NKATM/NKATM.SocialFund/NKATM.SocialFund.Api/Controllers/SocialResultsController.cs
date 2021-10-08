using MediatR;
using Microsoft.AspNetCore.Mvc;
using NKATM.SocialFund.Application.DTOs.SocialResult;
using NKATM.SocialFund.Application.Features.SocialResults.Commands;
using NKATM.SocialFund.Application.Features.SocialResults.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialResultsController : ControllerBase
    {
        private readonly IMediator mediator;

        public SocialResultsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SocialResultDto>> Get(Guid id)
        {
            var socialResult = await mediator.Send(new GetSocialResultQuery { Id = id });
            return Ok(socialResult);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateSocialResultDto socialResult)
        {
            var command = new CreateSocialResultCommand { SocialResultDto = socialResult };
            return Ok(await mediator.Send(command));
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateSocialResultDto socialResult)
        {
            var command = new UpdateSocialResultCommand { SocialResultDto = socialResult };
            await mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteSocialResultCommand { Id = id };
            await mediator.Send(command);
            return NoContent();
        }
    }
}
