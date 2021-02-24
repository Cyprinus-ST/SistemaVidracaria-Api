﻿using Api.Domain.Entities.Budget;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Repository
{
    public interface IBudgetRepository : IRepository<BudgetEntity>
    {
        Task<bool> ExistBudget(Guid idProject);
    }
}