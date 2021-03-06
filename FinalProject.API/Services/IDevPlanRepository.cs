﻿using FinalProject.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.API.Services
{
    public interface IDevPlanRepository
    {
        IEnumerable<DevPlanViewModel> GetDevPlans();
        DevPlanViewModel GetDevPlan(int devPlanId);
        DevPlanViewModel CreateDevPlan(DevPlanDTO devPlan);
        DevPlanDTO UpdateDevPlan(int devPlanId, DevPlanValidationWrapper devPlan);
        DevPlanViewModel DeleteDevPlan(int devPlanId);
    }
}
