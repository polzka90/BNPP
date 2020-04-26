using BNPP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNPP.Domain.Interfaces.Services
{
    public interface IManualMovementsService
    {
        List<ManualMovement> GetAllManualMovements();
        void InsertManualMovement(ManualMovement manualMovement);
    }
}
