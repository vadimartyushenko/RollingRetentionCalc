// See https://aka.ms/new-console-template for more information

using DBRepository;
using Models;

// добавление данных
using (var db = new RepositoryContext()) {

    var user1 = new User { UserId = 3, LastActivityDate = DateTime.Now, RegistrationDate = DateTime.Now.AddDays(-7) };
    var user2 = new User { UserId = 4, LastActivityDate = DateTime.Now, RegistrationDate = DateTime.Now.AddDays(-1)};

    db.Users.AddRange(user1, user2);
    db.SaveChanges();
}
// получение данных
using (var db = new RepositoryContext()) {

    var users = db.Users.ToList();
    Console.WriteLine("Users list:");
    foreach (User u in users) {
        Console.WriteLine($"{u.UserId}: reg.date {u.RegistrationDate}; last act-ty {u.LastActivityDate}");
    }
}