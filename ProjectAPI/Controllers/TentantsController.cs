using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{



[Route("api/[controller]")]
    [ApiController]
    public class TentantsController : ControllerBase
    {
        private readonly APIprojectDBcontext _context;
        //public TentantsController(APIprojectDBcontext context)
        //{
        //    _context = context;
        //}
        private APIprojectDBcontext _dbContext;



        public TentantsController(APIprojectDBcontext dbContext)
        {
            _dbContext = dbContext;

        }
        [HttpGet("byApartmentnumb1")]
        private  List<ViewModelsFindTentantsAparments> ListTenantAt(string ApartmentNum)
        {
            

            var results = (from p in _dbContext.People
                           join ps in _dbContext.Tags on p.ApertmentNumber equals ps.TagNumber
                           select new ViewModelsFindTentantsAparments()
                           {
                               FindTentantsAparments = p.ApertmentNumber,
                               TagNumber = ps.TagNumber,
                               FirstName = p.FirstName
                           }).ToList();
            return results; 
        }




        [HttpGet("byApartmentnumb2")]
        public List<Person> FindTentantsByApartment(string ApartmentNum)
        {
            var result = _dbContext.People.Where(an => an.ApertmentNumber == ApartmentNum).ToList();
           
            return result;

        }




    }
}


