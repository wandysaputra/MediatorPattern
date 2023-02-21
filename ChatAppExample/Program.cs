// See https://aka.ms/new-console-template for more information
var teamChat = new TeamChatRoom();
var jim = new Developer("Jim");
var ben = new Developer("Ben");
var gin = new Developer("Gin");
var kim = new Tester("Kim");
var dan = new Tester("Dan");

teamChat.RegisterMembers(jim, ben, gin, kim, dan);

jim.Send("Hey everyone, we're going to be deploying at 2pm today");
kim.Send("Ok, thanks for letting us know");

Console.WriteLine();
ben.SendTo<Developer>("Make sure to execute unit test before checking in");