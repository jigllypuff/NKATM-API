using MediatR;
using Microsoft.AspNetCore.Mvc;
using NKATM.SocialFund.Application.DTOs.SocialType;
using NKATM.SocialFund.Application.Features.SocialTypes.Commands;
using NKATM.SocialFund.Application.Features.SocialTypes.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialTypesController : ControllerBase
    {
        private readonly IMediator mediator;

        public SocialTypesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SocialTypeDto>> Get(Guid id)
        {
            var socialType = await mediator.Send(new GetSocialTypeQuery { Id = id });
            return Ok(socialType);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateSocialTypeDto socialType)
        {
            var command = new CreateSocialTypeCommand { SocialTypeDto = socialType };
            return Ok(await mediator.Send(command));
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] SocialTypeDto socialType)
        {
            var command = new UpdateSocialTypeCommand { SocialTypeDto = socialType };
            await mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteSocialTypeCommand { Id = id };
            await mediator.Send(command);
            return NoContent();
        }
    }
}
