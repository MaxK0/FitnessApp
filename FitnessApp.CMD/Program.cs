using FitnessApp.BL.Controller;

Console.WriteLine("Вас приветствует приложение Fitness");

Console.Write("Введите имя пользователя: ");
var name = Console.ReadLine();

Console.Write("Введите пол: ");
var gender = Console.ReadLine();

Console.Write("Введите дату рождения: ");
var birthDay = DateTime.Parse(Console.ReadLine());

Console.Write("Введите вес: ");
var weight = double.Parse(Console.ReadLine());

Console.Write("Введите рост: ");
var height = double.Parse(Console.ReadLine());

var userController = new UserController(name, gender, birthDay, weight, height);
userController.SaveAsync();

//TODO: Сделать проверки
//Есть идея, чтобы сделать идентификацию по телефону или почте. Если пользователь вводит уже существующий идентификатор и пароль, то заходится в приложение.
//Ещё было бы классно сделать подтверждение по телефону без пароля.
