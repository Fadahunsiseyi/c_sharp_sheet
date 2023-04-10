
using LinqCheatSheet;

var lawyers = new[]
{
    new Lawyer(){
        FirstName = "John",
        LastName = "Doe"
    },
        new Lawyer(){
        FirstName = "Maria",
        LastName = "Maker"
    },
};

var clients = new[]
{
    new Client()
    {
        FirstName = "Tim",
        LastName = "Funny"
    },
    new Client()
    {
        FirstName = "Jim",
        LastName = "Decker"
    },
        new Client()
    {
        FirstName = "Jerry",
        LastName = "Newton"
    },
};

var cases = new[]
{
    new Case()
    {
        Title = "Car accident",
        AmountDispute = 1000,
        CaseType = CaseType.Commercial,
        Client = clients[0],
        Lawyer = lawyers[0]
    },
    new Case()
    {
        Title = "Molding flat",
        AmountDispute = 65000,
        CaseType = CaseType.ProBono,
        Client = clients[0],
        Lawyer = lawyers[0]
    },
    new Case()
    {
        Title = "Death threat",
        AmountDispute = 15000,
        CaseType = CaseType.Commercial,
        Client = clients[1],
        Lawyer = lawyers[1]
    },
    new Case()
    {
        Title = "Robbery",
        AmountDispute = 1500,
        CaseType = CaseType.Commercial,
        Client = clients[2],
        Lawyer = lawyers[1]
    },
};

foreach (Lawyer lawyer in lawyers )
{
    lawyer.Cases = cases.Where(c => c.Lawyer == lawyer).ToList();
}

foreach (Client client in clients)
{
    client.Cases = cases.Where(c => c.Client == client).ToList();
}

var workingFirstExample = lawyers.First(l => l.FirstName == "John");

try
{
    var firstExecpetionExample = lawyers.First(l => l.FirstName == "Joh");
}
catch (InvalidOperationException ex)
{

    Console.WriteLine("Invalid operation exception has been thrown, cause no matching elements found");
}

var firstOrDefault = lawyers.FirstOrDefault(law => law.FirstName == "Joh");

var workingSingleExample = lawyers.Single(law => law.FirstName == "John");

try
{
    var singleExample = lawyers.Single(law => law.FirstName == "Joh");
}
catch (InvalidOperationException ex)
{

    Console.WriteLine("Invalid operation exception has been thrown, cause no matching elements found");
}

try
{
    var singleLastName = lawyers.Single(law => law.LastName.Contains("e"));
}
catch (InvalidOperationException ex)
{

    Console.WriteLine("Invalid operation exception has been thrown, cause no matching elements found");
}

var singleOrDefault = lawyers.SingleOrDefault(law => law.FirstName == "Joh");

var checkForAny = lawyers.Where(law => law.Cases.Any(c => c.CaseType == CaseType.ProBono));

var checkForAll = lawyers.Where(law => law.Cases.All(c => c.CaseType == CaseType.Commercial));


var sumOfAmountDispute = cases.Sum(c => c.AmountDispute);
var aveOfAmountDispute = cases.Average(c => c.AmountDispute);
var maxOfAmountDispute = cases.Max(c => c.AmountDispute);
var minOfAmountDispute = cases.Min(c => c.AmountDispute);