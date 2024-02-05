// See https://aka.ms/new-console-template for more information

using CodeTest;

IEnumerable<SchoolPersonnel> schoolPersonnel = new List<SchoolPersonnel>
{
    new Teacher(),
    new Pedagogue(),
    new SchoolLeader(),
};

foreach (SchoolPersonnel personnel in schoolPersonnel)
{
    Console.WriteLine($"Budget for {personnel.GetType().Name} : {personnel.Result()}");
}

Console.WriteLine($"Total Budget: {schoolPersonnel.Sum(x => x.Result())}");