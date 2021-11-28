﻿using Core.Entities.Concreate;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        //IDataResult<List<OperationClaim>> GetClaims(User user);
        //IResult Add(User user);
        //IDataResult<User> GetByMail(string email);

        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
