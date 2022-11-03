using Member.Data1.Interface;
using Member.Data1.Model;
using Member.Data1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemberApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMember members = new MembersRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Members>> GetAllMembers()
        {
            return members.GetAllMember();
        }
        [HttpGet("{id}")]
        public ActionResult<Members> GetMemberById(int id)
        {
            return members.GetMember(id);
        }
    }
}
