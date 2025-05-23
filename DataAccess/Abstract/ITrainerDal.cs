﻿using System.Collections.Generic;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ITrainerDal : IEntityRepository<Trainer>
    {
        List<TrainerDetailDto> GetTrainerDetails();
    }
}