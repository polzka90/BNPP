using BNPP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNPP.Domain.Interfaces.Repositories
{
    public interface IManualMovementsRepository
    {
        List<ManualMovement> GetAllManualMovements();
        int GetAllManualMovementsCount();
        void InsertManualMovement(ManualMovement manualMovement);

    }
}
