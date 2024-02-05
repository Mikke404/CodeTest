// See https://aka.ms/new-console-template for more information

using CodeTest;

IEnumerable<Budget> schoolPersonnel = new List<Budget>
{
    new TeacherBudget(),
    new PedagogueBudget(),
    new SchoolLeaderBudget(),
};

foreach (Budget personnel in schoolPersonnel)
{
    Console.WriteLine($"Budget for {personnel.GetType().Name} : {personnel.Result()}");
}

Console.WriteLine($"Total Budget: {schoolPersonnel.Sum(x => x.Result())}");