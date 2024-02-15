﻿using AppointEase.Application.Contracts.Models.DbModels;
using AppointEase.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointEase.Data.Repositories
{
    public class UserRepository : Repository<TblPacient>
    {
        public UserRepository(AppointEaseContext context) : base(context)
        {
        }
    }
}
