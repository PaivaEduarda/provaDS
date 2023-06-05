using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hp_api.Controllers.Data;
using hp_api.Model;
using Microsoft.AspNetCore.Mvc;

namespace hp_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HpController : ControllerBase
    {
        private HpContext _context; 
        public HpController(HpContext context) 
        { 
            // construtor 
            _context = context; 
        } 
        
        [HttpGet] 
        public ActionResult<List<Hp_Personagens>> GetAll() 
        { 
            return _context.Hp_Personagens.ToList(); 
        }
        
    }
}