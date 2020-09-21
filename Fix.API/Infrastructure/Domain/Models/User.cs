using Fixit.DataTransfersObject.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fix.API.Infrastructure.Domain.Models
{
    public class User : BaseModel
    {
        public User()
        {
            this.LoginStatus = LoginStatus.InActive;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public LoginStatus LoginStatus { get; set; }

        public int LoginRetries { get; set; }

        public Gender Gender { get; set; }

        //public int ContactNumber { get; set; }

    }
}
