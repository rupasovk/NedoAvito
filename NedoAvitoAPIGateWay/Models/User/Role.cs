using System.Collections.Generic;

namespace NedoAvito.APIGateWay.Models
{
    public class Role : BaseDbObject
    {
        List<User> _user;
        List<Permission> _permissions;

        public List<User> Users { get { return _user; } set { _user = value; } }
        public List<Permission> Permissions { get { return _permissions; } set { _permissions = value; } }
    }
}
