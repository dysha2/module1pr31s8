using module1pr31s8;

List<Programmer> programmerList = new List<Programmer>()
{
    new Programmer("Орлов",5,100),
    new Programmer("Смирнов",3,50),
    new Programmer("Дигилев",10,400),
    new Programmer("Медведев",1,10)
};
List<ProgrammerNew> programmerNewList = new List<ProgrammerNew>()
{
    new ProgrammerNew("Орлов",5,100,76),
    new ProgrammerNew("Смирнов",3,50,20),
    new ProgrammerNew("Дигилев",10,400,370),
    new ProgrammerNew("Медведев",1,10,8)
};
programmerList.ForEach(x => x.SetQ());
programmerNewList.ForEach(x => x.SetQ());
programmerList.ForEach(x=>Console.WriteLine(x.GetInfo()));
Console.WriteLine();
programmerNewList.ForEach(x => Console.WriteLine(x.GetInfo()));

