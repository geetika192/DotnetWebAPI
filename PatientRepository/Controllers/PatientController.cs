using Microsoft.AspNetCore.Mvc;
using PatientRepository.Models;
using PatientRepository.DataAccess;
namespace PatientRepository.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController:ControllerBase
    {
        IPatientsRepository IPatientsRepository;
        public PatientController(IPatientsRepository _patientsRepository)
        {
            IPatientsRepository=_patientsRepository;
        }
        [HttpPost("AddRecord")]
        public IActionResult CreateEmployee(Patients pat)
        {
            IPatientsRepository.AddPatientRecord(pat);
            return Ok("record is added");

        }
        
  [HttpPut("Update")]  
        public IActionResult Edit(Patients patient)  
        {  
            if (ModelState.IsValid)  
            {  
                IPatientsRepository.UpdatePatientRecord(patient);  
                return Ok("Record Update Successfully !!!!");  
            }  
            return BadRequest();  
        }  
[HttpDelete("{id}")]  
        public IActionResult DeleteConfirmed(string id)  
        {  
            var data = IPatientsRepository.GetPatientSingleRecord(id);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            IPatientsRepository.DeletePatientRecord(id);  
            return Ok("delete successfully !!!!");  
        }  
 [HttpGet("{id}")]  
        public Patients Details(string id)  
        {  
            return IPatientsRepository.GetPatientSingleRecord(id);

        }  
    }
}