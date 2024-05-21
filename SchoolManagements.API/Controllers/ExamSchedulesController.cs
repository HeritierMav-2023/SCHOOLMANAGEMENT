using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Features.ExamenSchedules.Queries;

namespace SchoolManagements.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamSchedulesController : ApiControllerBase
    {
        //1- Object Mediator
        private readonly IMediator _mediator;

        //2-Constructor DI
        public ExamSchedulesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region Methods Verbs
        [HttpGet("GetAllExamenSchedules")]
        public async Task<ActionResult<List<ExamScheduleDto>>> Get()
        {
            return await _mediator.Send(new GetAllExamenScheduleQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExamScheduleDto>> GetExamenScheduleById(int id)
        {
            return await _mediator.Send(new GetExamenScheduleIdQuery(id));
        }

        #endregion
    }
}
