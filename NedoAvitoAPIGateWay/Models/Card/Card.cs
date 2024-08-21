using NedoAvito.APIGateWay.DTOs;
using NedoAvito.APIGateWay.Interfaces;

namespace NedoAvito.APIGateWay.Models
{
    /// <summary>
    /// Карточка товара
    /// </summary>
    public class Card : BaseDbObject, ITransportable<Card>
    {
        #region Fields

        string _cardObjectName;
        string _cardObjectDescription;

        CardCategory _сardCategory;

        bool _isUse;

        #endregion

        #region Properties

        /// <summary>
        /// Наименование товара
        /// </summary>
        public string CardObjectName { get { return _cardObjectName; } set { _cardObjectName = value; } }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string CardObjectDescription { get { return _cardObjectDescription; } set { _cardObjectDescription = value; } }

        /// <summary>
        /// Категория карточки товара
        /// </summary>
        public CardCategory CardCategory { get { return _сardCategory; } set { _сardCategory = value; } }

        #endregion

        #region ITransportable

        public Card GetFromDto(IDataTransportObject _dto)
        {
            return new Card();
        }

        public IDataTransportObject TranslateToDto()
        {
            return new CardDto() { };
        }

        #endregion

        #region Events

        #endregion
    }
}
