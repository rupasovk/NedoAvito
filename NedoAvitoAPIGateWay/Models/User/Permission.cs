using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NedoAvito.APIGateWay.Models
{
    public class Permission : BaseDbObject
    {
        #region Fields
        
        string _name;
        bool _isUse;

        #endregion

        #region Properties

        public string Name { get { return _name; } set { Name = value; } }

        public bool IsUse { get { return _isUse; } set { IsUse = value; } }

        #endregion
        
    }
}
