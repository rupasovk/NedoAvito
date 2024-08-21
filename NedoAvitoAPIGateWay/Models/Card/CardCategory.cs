using NedoAvito.APIGateWay.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NedoAvito.APIGateWay.Models
{
    /// <summary>
    /// Категория карточки товара
    /// </summary>
    public class CardCategory : CardCategoryBase, ITransportable<CardCategory>
    {
        #region Fields

        CardSuperCategory _cardSuperCategory;
        Guid _cardSuperCategoryId;

        #endregion

        #region Constructors

        public CardCategory()
        { 
        
        }

        #endregion

        #region Properties

        /// <summary>
        /// Обобщающая категория карточек товара
        /// </summary>
        public CardSuperCategory CardSuperCategory { get { return _cardSuperCategory; } set { _cardSuperCategory = value; } }

        /// <summary>
        /// Oid обобщающей категории карточек товара
        /// </summary>
        public Guid CardSuperCategoryId { get { return _cardSuperCategoryId; } set { _cardSuperCategoryId = value; } }

        #endregion

        #region ITransportable

        public CardCategory GetFromDto(IDataTransportObject _dto)
        {
            throw new NotImplementedException();
        }

        public IDataTransportObject TranslateToDto()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
