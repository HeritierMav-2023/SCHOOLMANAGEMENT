using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Features.Departements.Queries;


namespace SchoolManagements.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartementsController : ApiControllerBase
    {
        //1- Object Mediator
        private readonly IMediator _mediator;

        //2-Constructor DI
        public DepartementsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region Methods Verbs
        [HttpGet("GetAllDepartements")]
        public async Task<ActionResult<List<DeptDto>>> Get()
        {
            return await _mediator.Send(new GetAllDepartmentQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeptDto>> GetDepatementById(int id)
        {
            return await _mediator.Send(new GetDepartmentByIdQuery(id));
        }

        #endregion
    }
}
