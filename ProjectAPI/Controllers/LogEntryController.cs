using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using System.Net.Http;


namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogEntryController : ControllerBase
    {   
        // Let us get acces to our DBContext
        private APIprojectDBcontext _dbContext;
        public LogEntryController(APIprojectDBcontext dbContext)
        {
            _dbContext = dbContext;
        }

        // API the gets all the LogEnteries
        [HttpGet("GetLog")]
        public IActionResult Get()
        {
            try
            {
                var logs = _dbContext.LogEntries.ToList();
                if (logs.Count == 0)
                {
                    return StatusCode(404, "The data is not found in the EntryLog");
                }

                return Ok(logs);
            }
            catch (Exception)
            {

                return StatusCode(500, "There is an error" );
            }
   
           
        }

        [HttpPost("LogEntry")]
        // Request from body is used to say what the user is supposed to put as an input
        // and the input skeleton is from the LogEntry Model
        public IActionResult Create([FromBody] LogEntry request)
        {
            //Creating a new instance of LogEntry class
            LogEntry log = new LogEntry();
            log.WalkedThroughDoor = request.WalkedThroughDoor;
            log.DoorName = request.DoorName;
            //log.Door = request.Door;
            log.CodeString = request.CodeString;
            //log.Code = request.Code;
            log.TagNumber = request.TagNumber;
            //log.Tag = request.Tag;
            log.FirstName = request.FirstName;
            log.LastName = request.LastName;

            try
            {
                _dbContext.LogEntries.Add(log);
                _dbContext.SaveChanges();
            }
            // Put an ex to inspect the exception if it occurs
            catch (Exception ex)
            {

                return StatusCode(500, "There is an error");
            }

            // get all LogEntries that was saved
            var logs = _dbContext.LogEntries.ToList();
            return Ok(logs);
        }

        [HttpDelete("DeleteLog/{Id}")]
        public IActionResult Delete([FromRoute]int Id)
        {
            try
            {
                var log = _dbContext.LogEntries.FirstOrDefault(x => x.LogEntryId == Id);
                if (log == null)
                {
                    return StatusCode(404, "The data is not found in the EntryLog");
                }

                _dbContext.Entry(log).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                return StatusCode(500, "There is an error");
            }

            // get all LogEntries that was saved
            var logs = _dbContext.LogEntries.ToList();
            return Ok(logs);
        }

        [HttpPut("UpdateLog")]
        public IActionResult Update([FromBody] LogEntry request)
        {
            try
            {
                var log = _dbContext.LogEntries.FirstOrDefault(x => x.LogEntryId == request.LogEntryId);
                if (log == null)
                {
                    return StatusCode(404, "The data is not found in the EntryLog");
                }

                log.WalkedThroughDoor = request.WalkedThroughDoor;
                log.DoorName = request.DoorName;
                log.CodeString = request.CodeString;
                log.TagNumber = request.TagNumber;
                log.FirstName = request.FirstName;
                log.LastName = request.LastName;

                _dbContext.Entry(log).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                return StatusCode(500, "There is an error");
            }

            // get all LogEntries that was saved
            var logs = _dbContext.LogEntries.ToList();
            return Ok(logs);

        }

        
                
    }


    
}
