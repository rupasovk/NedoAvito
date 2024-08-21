using NedoAvito.APIGateWay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NedoAvito.APIGateWay.Models
{
    /// <summary>
    /// Обобщающая категория карточек товара
    /// </summary>
    public class CardSuperCategory : CardCategoryBase
    {
        #region Fields

        List<CardCategory> _subCategories;

        #endregion

        #region Properties

        /// <summary>
        /// Коллекция подкатегорий
        /// </summary>
        public List<CardCategory> SubCategories { get { return _subCategories; } set { _subCategories = value; } }

        #endregion

    }
}
