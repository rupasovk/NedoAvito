using NedoAvito.APIGateWay.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NedoAvito.APIGateWay.DTOs
{
    [Serializable]
    public class UserDto : IDataTransportObject
    {
        public string UserName { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
    }
}
