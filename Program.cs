using System;
using System.Linq;

namespace AnimalWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat { Name = "Philip", Age = 20, Breed = "None", Fur = Fur.Short, Character = Character.Evil, Voice = Voice.Meow };
            Cat cat2 = new Cat { Name = "Alb", Age = 4, Breed = "Siamese", Fur = Fur.Long, Character = Character.Kind, Voice = Voice.Meow};
            Dog dog1 = new Dog { Name = "Sharik", Age = 5, Breed = "Khaski", Fur = Fur.Short, Training = LevelOfTraining.High, Voice = Voice.Bark };
            Dog dog2 = new Dog { Name = "Mukhtar", Age = 10, Breed = "Sheepdog", Fur = Fur.Short, Training = LevelOfTraining.High, Voice = Voice.Bark };
            Cow cow1 = new Cow { Name = "Milka", Age = 3, Products = Products.Milk, Profit = LevelOfProfit.High, Weight = 300 };
            Cow cow2 = new Cow { Name = "Maria", Age = 2, Products = Products.Milk, Profit = LevelOfProfit.Little, Weight = 100 };
            Chicken chicken1 = new Chicken { Name = "Ryaba", Age = 1, Products = Products.Eggs, Profit = LevelOfProfit.Little, EggsPerDay = 1 };
            Chicken chicken2 = new Chicken { Name = "Snowhite", Age = 2, Products = Products.Eggs, Profit = LevelOfProfit.High, EggsPerDay = 5 };
            Owl owl1 = new Owl { Name = "Hedwig", Age = 5, Breed = "Polar", MoveKind = MoveKind.Fly, Predation = Predation.Carnivourus };
            Owl owl2 = new Owl { Name = "Villi", Age = 4, Breed = "None", MoveKind = MoveKind.Fly, Predation = Predation.Carnivourus };
            Snake snake1 = new Snake { Name = "Basilisk", Age = 200, MoveKind = MoveKind.Crowling, Predation = Predation.Carnivourus, Toxicity = Toxicity.Fatal };
            Snake snake2 = new Snake { Name = "Nagini", Age = 100, MoveKind = MoveKind.Crowling, Predation = Predation.Carnivourus, Toxicity = Toxicity.Fatal };
            Group<IDomestic> domesticGroup = new Group<IDomestic>();
            domesticGroup.AnimalGroup.Add(cat1);
            domesticGroup.AnimalGroup.Add(dog1);
            domesticGroup.AnimalGroup.Add(cat2);
            domesticGroup.AnimalGroup.Add(dog2);
         /*   foreach (IDomestic dom in  domesticGroup.AnimalGroup)
            {
                Console.WriteLine("Breed = "+dom.Breed + ", fur = " + dom.Fur + ", voice = " + dom.Voice);
            }*/
            var result1 = from d in domesticGroup.AnimalGroup
                          where d.Fur == Fur.Short
                          orderby d.Voice descending
                          select "Voice = " + d.Voice + ", breed = " + d.Breed + ", fur = " + d.Fur + "\n";
            Console.WriteLine(string.Join("", result1));
            Group<IFeed> feedGroup = new Group<IFeed>();
            feedGroup.AnimalGroup.Add(chicken1);
            feedGroup.AnimalGroup.Add(cow1);
            feedGroup.AnimalGroup.Add(chicken2);
            feedGroup.AnimalGroup.Add(cow2);
          /*  foreach (IFeed fed in feedGroup.AnimalGroup)
            {
                Console.WriteLine("Products = " + fed.Products + ", Profit = " + fed.Profit);
            }*/
            var result2 = from f in feedGroup.AnimalGroup
                          where f.Products == Products.Eggs
                          orderby f.Profit descending
                          select "Profit = " + f.Profit + ", products = " + f.Products + "\n";
            Console.WriteLine(string.Join("", result2));
            Group<IWild> wildGroup = new Group<IWild>();
            wildGroup.AnimalGroup.Add(snake1);
            wildGroup.AnimalGroup.Add(owl1);
            wildGroup.AnimalGroup.Add(snake2);
            wildGroup.AnimalGroup.Add(owl2);
            var result3 = from w in wildGroup.AnimalGroup
                          where w.MoveKind == MoveKind.Crowling
                          select "Move kind = " + w.MoveKind + ", predation = " + w.Predation + "\n";
            Console.WriteLine(string.Join("", result3));
            Group<Animal> allGroup = new Group<Animal>();
            allGroup.AnimalGroup.Add(cat1);
            allGroup.AnimalGroup.Add(dog1);
            allGroup.AnimalGroup.Add(cow1);
            allGroup.AnimalGroup.Add(chicken1);
            allGroup.AnimalGroup.Add(owl1);
            allGroup.AnimalGroup.Add(snake1);
            var result4 = from g in allGroup.AnimalGroup
                          orderby g.Age
                          select "Age = " + g.Age + ", name = " + g.Name + "\n";
            Console.WriteLine(string.Join("", result4));
            Console.ReadLine();
        }
    }
}