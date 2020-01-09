namespace MapperExample.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MapperExample.Interfaces;
    using Models;

    [ApiController]
    [Route("[controller]")]
    public class MappingsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public MappingsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get([FromQuery]CustomerDto dto)
        {
            var source = new SourceModel
            {
                SomeSourceString = "Some value",
                SomeSourceInt = 5
            };

            var target1 = _mapper.Map<SourceModel, TargetModel>(source);
            var target = _mapper.Map<CustomerDto, CustomerEntity>(dto);

            return Ok(new { target, target1 });
        }
    }
}
