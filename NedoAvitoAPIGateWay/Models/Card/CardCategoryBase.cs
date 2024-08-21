using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NedoAvito.APIGateWay.Models
{
    /// <summary>
    /// Базовый класс категорий карточки товара
    /// </summary>
    public class CardCategoryBase : BaseDbObject
    {
        #region Fields

        string _name;

        #endregion

        #region Properties

        /// <summary>
        ///  Наименование категории
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }

        #endregion
    }
}
