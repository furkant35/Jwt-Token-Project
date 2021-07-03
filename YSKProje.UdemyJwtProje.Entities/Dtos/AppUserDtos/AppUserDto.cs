using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.UdemyJwtProje.Entities.Dtos.AppUserDtos
{
    public class AppUserDto
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
    }
}
