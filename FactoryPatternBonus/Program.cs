using FactoryPatternBonus;
Console.WriteLine();
Console.WriteLine("What kind of Data Base would you like to use?");
Console.WriteLine();
Console.WriteLine("Type \"list\" for a list data access");
Console.WriteLine("Type \"mongo\" for a mongo data access");
Console.WriteLine("Type \"sql\" for a sql data access");

var userInput = Console.ReadLine();
var databaseObject = DataAccessFactory.GetDataAccessType(userInput);
databaseObject.LoadData();
databaseObject.SaveData();  