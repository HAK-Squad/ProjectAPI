using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        private readonly APIprojectDBcontext _context;
        public EntryController(APIprojectDBcontext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<LogEntry> FindEntriesByDoor(string doorName)
        {
            var result = _context.LogEntries.Where(le => le.DoorName == doorName).ToList();
            return result;

        }
        [HttpGet ("byEvent")]
        public List<LogEntry> FindEntriesByEvent(string codeString)
        {
            var result = _context.LogEntries.Where(cs => cs.CodeString == codeString).ToList();
            return result;

        }


    }
}
