using AccountManager.Data.Core;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManager.Data.DataServices
{
    public class AccountTypeDataService: DataServiceBase<AccountTypeDataService, AccountManagerDBContext>
    {
        public AccountTypeDataService(IMapper mapper, AccountManagerDBContext context) : base(mapper, context)
        {

        }
    }
}
