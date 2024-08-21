using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NedoAvito.APIGateWay.Models
{
    /// <summary>
    /// Базовый класс для сущностей в базе
    /// </summary>
    public class BaseDbObject
    {
        #region Fields

        Guid _id;
        DateTime _createDateTime;
        DateTime _changeDateTime;
        Guid _creatorId;
        User _creator;
        Guid _changeMakerId;
        User _changeMaker;

        #endregion

        #region Properties

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid Id { get { return _id; } set { _id = value; } }
        
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDateTime { get { return _createDateTime; } set { _createDateTime = value; } }
        
        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime ChangeDateTime { get { return _changeDateTime; } set { _changeDateTime = value; } }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid CreatorId { get { return _id; } set { _id = value; } }

        /// <summary>
        /// Создал
        /// </summary>
        public User Creator { get { return _creator; } set { _creator = value; } }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid ChangeMakerId { get { return _id; } set { _id = value; } }

        /// <summary>
        /// Изменил
        /// </summary>
        public User ChangeMaker { get { return _changeMaker; } set { _changeMaker = value; } }

        #endregion

        #region Events

        #endregion
    }
}
