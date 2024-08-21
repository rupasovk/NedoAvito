using NedoAvito.APIGateWay.DTOs;
using NedoAvito.APIGateWay.Interfaces;
using System;

namespace NedoAvito.APIGateWay.Models
{
    public class User : ITransportable<User>
    {
        #region Fields

        Guid _id;
        DateTime _createDateTime;
        DateTime _changeDateTime;

        string _name;
        string _surname;
        DateTime _birthDay;
        string _email;
        string _country;
        Role _role;
        Guid _roleId;

        #endregion

        #region Constructors

        public User() { } //=> _userImages = new List<UserImage>();

        public User(Guid id, string name, string surname, DateTime birthDay, string email, string country)
        {
            Id = id;
            Name = name;
            SurName = surname;
            BirthDay = birthDay;
            Email = email;
            Country = country;
            //_userImages = new List<UserImage>();
        }

        public User(string name, string surname, DateTime birthDay, string email, string country)
        {
            Name = name;
            SurName = surname;
            BirthDay = birthDay;
            Email = email;
            Country = country;
            //_userImages = new List<UserImage>();
        }

        public User(UserDto userDto)
        {
            Name = userDto.UserName;
            SurName = userDto.Surname;
            BirthDay = userDto.Birthday;
            Email = userDto.Email;
            Country = userDto.Country;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Oid
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
        /// Имя
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string SurName { get { return _surname; } set { _surname = value; } }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDay { get { return _birthDay; } set { _birthDay = value; } }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get { return _email; } set { _email = value; } }
        
        /// <summary>
        /// Страна проживания
        /// </summary>
        public string Country { get { return _country; } set { _country = value; } }
        
        /// <summary>
        /// Роль
        /// </summary>
        public Role Role { get { return _role; } set { _role = value; } }

        /// <summary>
        /// Oid роли
        /// </summary>
        public Guid RoleId { get { return _roleId; } set { _roleId = value; } }

        //public UserImage UserImage { get { return _userImage; } set { _userImage = value; } }

        //public List<UserImage> UserImages { get { return _userImages; } }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"User: {Name} {SurName}, {BirthDay.ToString("dd.MM.yyyy HH:mm:ss")}, {Email}, {Country}";
        }

        public User GetFromDto(IDataTransportObject _dto)
        {
            return new User(_dto as UserDto);
        }

        public IDataTransportObject TranslateToDto()
        {
            return new UserDto() { 
                
            };
        }

        #endregion
    }
}
