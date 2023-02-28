using CarLibaryProject;
using Microsoft.AspNetCore.Mvc;
using RESTCarLibaryProjectAPI.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTCarLibaryProjectAPI.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private CarRepository _repo;

        public CarsController(CarRepository repository)
        {
            _repo = repository;
        }

        // GET: api/<CarsController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            List<Car> result = _repo.GetAll();
            if (result.Count < 1)
            {
                return NoContent();
            }
            return Ok(result);
        }

        // GET api/<CarsController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]   
        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id)
        {
            Car getCar = _repo.GetById(id);
            if (getCar == null)
            {
                return NotFound();
            }
            return Ok(getCar);
        }

        // POST api/<CarsController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<Car> Post([FromBody] Car addCar)
        {
            try
            {
                Car AddedCar = _repo.Add(addCar);
                return Created($"api/car/{AddedCar.Id}",AddedCar);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CarsController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]   
        [HttpPut("{id}")]
        public ActionResult<Car> Put(int id, [FromBody] Car carUpdates)
        {
            try
            {
                Car updatedCar = _repo.Update(id, carUpdates);
                if (updatedCar == null)
                {
                    return NoContent();
                }
                return Ok(updatedCar);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // DELETE api/<CarsController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public ActionResult<Car> Delete(int carToDeleteById)
        {
            Car carToDelete = _repo.Delete(carToDeleteById);
            if (carToDelete == null)
            {
                return NotFound();
            }
            return Ok(carToDelete);
        }
    }
}
