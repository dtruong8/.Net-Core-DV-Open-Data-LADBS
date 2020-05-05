﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public interface IPermitRepository
    {
        List<Permit> getAllProjectList();
        List<Permit> getProjectList(string name);
    }
}