using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountManager.Data.Core
{
    public class ModelBase<t>
    {
        public t Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
