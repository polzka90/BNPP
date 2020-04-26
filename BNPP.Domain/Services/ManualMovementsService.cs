using BNPP.Domain.Interfaces.Repositories;
using BNPP.Domain.Interfaces.Services;
using BNPP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNPP.Domain.Services
{
    public class ManualMovementsService : IManualMovementsService
    {
        private readonly IManualMovementsRepository _manualMovementsRepository;
        public ManualMovementsService(IManualMovementsRepository manualMovementsRepository)
        {
            _manualMovementsRepository = manualMovementsRepository;
        }

        public List<ManualMovement> GetAllManualMovements()
        {
            return _manualMovementsRepository.GetAllManualMovements();
        }

        public void InsertManualMovement(ManualMovement manualMovement)
        {
            int count = _manualMovementsRepository.GetAllManualMovementsCount();
            manualMovement.Num_Lancamento = count + 1;
            _manualMovementsRepository.InsertManualMovement(manualMovement);
        }
    }
}
