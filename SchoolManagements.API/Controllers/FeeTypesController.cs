using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Features.FeeTypes.Queries;


namespace SchoolManagements.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeeTypesController : ApiControllerBase
    {
        //1- Object Mediator
        private readonly IMediator _mediator;

        //2-Constructor DI
        public FeeTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region Methods Verbs
        [HttpGet("GetAllFeeTypes")]
        public async Task<ActionResult<List<FeeTypeDto>>> Get()
        {
            return await _mediator.Send(new GetAllFeeTypesQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FeeTypeDto>> GetFeeTypeById(int id)
        {
            return await _mediator.Send(new GetFeeTypesbyIdQuery(id));
        }

        #endregion
    }
}
