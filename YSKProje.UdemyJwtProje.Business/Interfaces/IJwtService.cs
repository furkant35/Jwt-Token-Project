﻿using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.UdemyJwtProje.Entities.Concrete;

namespace YSKProje.UdemyJwtProje.Business.Interfaces
{
    public interface IJwtService
    {
        public string GenerateJwt(AppUser appUser, List<AppRole> roles);
    }
}
