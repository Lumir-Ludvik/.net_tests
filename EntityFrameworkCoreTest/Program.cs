// See https://aka.ms/new-console-template for more information

using EntityFrameworkCoreTest.Db;
using EntityFrameworkCoreTest.Db.DbModels;

static async Task TestDb()
{
    using(BaseContext db = new())
    {

        //CREATE
        db.Add<PersonModel>(new() { Name = null, Age = 23 });
        await db.SaveChangesAsync();
        
        //READ
        var person = db.People?.OrderBy(p => p.Id).Last();
        Console.WriteLine(person?.Name ?? "no person today :(");
        
        //UPDATE
        if(person is not null)
        {
            person.Name ??= "Pysk!";
            //CREATE Car to realation
            person.Cars.Add(new()
            {
                Name = "Pysk's car",
                Weight = 3,
                Owner = person
            });
            await db.SaveChangesAsync();
        }

        //READ Person's car name
        person = db.People?.OrderBy(p => p.Id).Last();
        if(person is not null) 
            Console.WriteLine($"{person.Name ?? "no person today :("} has {person.Cars.First().Name ?? "nothing :("} ");

        //READ Car's owner
        var car = db.Cars?.OrderBy(c => c.Id).Last();
        if(car is not null)
        {
            Console.WriteLine($"{car.Name ?? "there is no car :("} with owner {car.Owner?.Name ?? "there is no owner :("}");
        }

        //DELETE
        if(person is not null)
        {
            var res = db.Remove(person);
            await db.SaveChangesAsync();
            Console.WriteLine($"Goodbye {res.Entity.Name}");
        }

    }
}

await TestDb();


