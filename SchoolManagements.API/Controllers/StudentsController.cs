using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolManagements.Application.DTOs;
using SchoolManagements.Application.Features.Students.Commands.CreateStudents;
using SchoolManagements.Application.Features.Students.Commands.DeleteStudents;
using SchoolManagements.Application.Features.Students.Commands.UpdateStudents;
using SchoolManagements.Application.Features.Students.Queries;

namespace SchoolManagements.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ApiControllerBase
    {
        //1- Object Mediator
        private readonly IMediator _mediator;

        //2-Constructor DI
        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region Methods Verbs

        [HttpGet("GetAllStudents")]
        public async Task<ActionResult<List<StudentsDto>>> Get()
        {
            return await _mediator.Send(new GetAllStudentsQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentsDto>> GetById(int id)
        {
            return await _mediator.Send(new GetStudentsByIdQuery(id));
        }

        [HttpGet]
        [Route("standard/{standardId}")]
        public async Task<ActionResult<List<StudentsDto>>> GetStudentsByStandard(int standardId)
        {
           return await _mediator.Send(new GetStudentsByStandardQuery(standardId));
        }

        [HttpPost]
        public async Task<ActionResult<string>> Create(CreateStudentCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<string>> Update(int id, UpdateStudentCommand command)
        {
            if (id != command.studentId)
            {
                return BadRequest();
            }

            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> Delete(int id)
        {
            return await _mediator.Send(new DeleteStudentCommand(id));
        }
        #endregion
    }
}
