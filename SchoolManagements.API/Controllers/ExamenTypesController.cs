using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Features.ExamenTypes.Queries;

namespace SchoolManagements.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamenTypesController : ApiControllerBase
    {
        //1- Object Mediator
        private readonly IMediator _mediator;

        //2-Constructor DI
        public ExamenTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region Methods Verbs
        [HttpGet("GetAllExamTypes")]
        public async Task<ActionResult<List<ExamTypeDto>>> Get()
        {
            return await _mediator.Send(new GetAllExamenTypesQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExamTypeDto>> GetDepatementById(int id)
        {
            return await _mediator.Send(new GetAllExamenTypeIdQuery(id));
        }
        #endregion
    }
}
