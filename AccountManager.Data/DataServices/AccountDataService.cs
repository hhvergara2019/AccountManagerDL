using AccountManager.Data.Core;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManager.Data.DataServices
{
    public class AccountDataService : DataServiceBase<AccountTypeDataService, AccountManagerDBContext>
    {
        public AccountDataService(IMapper mapper, AccountManagerDBContext context) : base(mapper, context)
        {

        }
    }
}
