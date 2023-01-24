using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.TeamMemberDtos
{
    public class MemberUpdateDto
    {
        public MemberGetDto memberGet { get; set; }
        public MemberPostDto memberPost { get; set; }
        public MemberUpdateDto()
        {
            memberPost = new MemberPostDto();
        }
    }
}
