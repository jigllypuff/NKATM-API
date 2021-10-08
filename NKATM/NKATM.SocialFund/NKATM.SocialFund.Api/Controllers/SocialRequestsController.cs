using MediatR;
using Microsoft.AspNetCore.Mvc;
using NKATM.SocialFund.Application.DTOs.SocialRequest;
using NKATM.SocialFund.Application.Features.SocialRequests.Commands;
using NKATM.SocialFund.Application.Features.SocialRequests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialRequestsController : ControllerBase
    {
        private readonly IMediator mediator;

        public SocialRequestsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SocialRequestDto>> Get(Guid id)
        {
            var socialRequest = await mediator.Send(new GetSocialRequestQuery { Id = id });
            return Ok(socialRequest);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateSocialRequestDto socialRequest)
        {
            var command = new CreateSocialRequestCommand { SocialRequestDto = socialRequest };
            return Ok(await mediator.Send(command));
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateSocialRequestDto socialRequest)
        {
            var command = new UpdateSocialRequestCommand { SocialRequestDto = socialRequest };
            await mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteSocialRequestCommand { Id = id };
            await mediator.Send(command);
            return NoContent();
        }

        [HttpPut("changeacceptance/{id}")]
        public async Task<ActionResult> ChangeAcceptance(Guid id, [FromBody] ChangeSocialRequestStatusDto socialRequest)
        {
            var command = new UpdateSocialRequestCommand { Id = id, ChangeSocialRequestStatusDto = socialRequest };
            await mediator.Send(command);
            return NoContent();
        }
    }
}
