using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Features.Standards.Commands.CreateStandards;
using SchoolManagements.Application.Features.Standards.Commands.DeleteStandards;
using SchoolManagements.Application.Features.Standards.Commands.UpdateStandards;
using SchoolManagements.Application.Features.Standards.Queries;



namespace SchoolManagements.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandardsController : ApiControllerBase
    {
        //1- Object Mediator
        private readonly IMediator _mediator;

        //2-Constructor DI
        public StandardsController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        #region Methods Verbs
        [HttpGet("GetAllStandards")]
        public async Task<ActionResult<List<StandardDto>>> Get()
        {
            return await _mediator.Send(new GetAllStandardsQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StandardDto>> GetStandardById(int id)
        {
            return await _mediator.Send(new GetStandardByIdQuery(id));
        }

        [HttpPost("CreateStandard")]
        public async Task<ActionResult<string>> Create(CreateStandardCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<string>> Update(int id, UpdateStandardCommand command)
        {
            if (id != command.StandardId)
            {
                return BadRequest();
            }

            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> Delete(int id)
        {
            return await _mediator.Send(new DeleteStandardCommand(id));
        }
        #endregion
    }
}
