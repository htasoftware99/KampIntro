using GameProject;

GamerManager gamerManager = new GamerManager(new UserValidationManager());
gamerManager.Add(new Gamer { Id = 1, BirthYear = 1999, FirstName = "Hasan", LastName = "Aykaç", IdentityNumber = 12345 });
