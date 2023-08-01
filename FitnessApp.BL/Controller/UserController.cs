using System;
using FitnessApp.BL.Model;
using System.Text.Json;

namespace FitnessApp.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь.
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>        
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height)
        {
            //TODO: Проверка

            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);
        }
        public UserController()
        {
            using (var fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                if (JsonSerializer.Deserialize<User>(fs) is User user)
                {
                    User = user;
                }
                // TODO: Что делать, если пользователя не прочитали?
            }
        }
        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public async void SaveAsync()
        {
            using (var fs = new FileStream("users.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<User>(fs, User);
            } 
        }
    }
}
