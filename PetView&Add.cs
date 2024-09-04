using System;
using System.Xml.Linq;


public class pety
{
    private List<Dog> dogs = new List<Dog>();
    private List<Cat> cats = new List<Cat>();
    private List<Lizard> lizards = new List<Lizard>();
    private List<Bird> birds = new List<Bird>();

    public void Start()
    {

        while (true)
        {
            Console.WriteLine("Choose an option:\n" +
                              "1. View all pets\n" +
                              "2. Add a pet\n" +
                              "3. View dogs\n" +
                              "4. View cats\n" +
                              "5. View lizards\n" +
                              "6. View birds\n" +
                              "7. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ViewAllPets();
                    break;
                case "2":
                    AddPet();
                    break;
                case "3":
                    ViewPetsByCategory(Kind.Dog);
                    break;
                case "4":
                    ViewPetsByCategory(Kind.Cat);
                    break;
                case "5":
                    ViewPetsByCategory(Kind.Lizard);
                    break;
                case "6":
                    ViewPetsByCategory(Kind.Bird);
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    private void AddPet()
    {
        Console.WriteLine("Pet Kind\n" +
                          "1. Dog\n" +
                          "2. Cat\n" +
                          "3. Lizard\n" +
                          "4. Bird\n");
        int petKind = Convert.ToInt32(Console.ReadLine());
        Kind kind = (Kind)(petKind - 1);

        Console.WriteLine("Enter the Pet Name:");
        string name = Console.ReadLine();

        Console.WriteLine("1. Male\n" +
                          "2. Female");
        int inputgender = Convert.ToInt32(Console.ReadLine());
        Gender gender = (Gender)(inputgender - 1);

        Console.WriteLine("Enter the Owner Name:");
        string owner = Console.ReadLine();

    
        switch (kind)
        {
            case Kind.Dog:
                Dog dog = new Dog(name, gender, owner);
                dogs.Add(dog);
                Console.WriteLine(dog.sound);
                break;

            case Kind.Cat:
                Cat cat = new Cat(name, gender, owner);
                cats.Add(cat);
                Console.WriteLine(cat.sound);
                break;

            case Kind.Lizard:
                Lizard lizard = new Lizard(name, gender, owner);
                lizards.Add(lizard);
                Console.WriteLine(lizard.sound);
                break;

            case Kind.Bird:
                Bird bird = new Bird(name, gender, owner);
                birds.Add(bird);
                Console.WriteLine(bird.sound);
                break;

            default:
                Console.WriteLine("Unsupported pet kind.");
                break;
        }

    }

    private void ViewAllPets()
    {
        int i = 0;
        Console.WriteLine("All Pets: ");
        foreach (var dog in dogs)
        {
            i++;
            Console.WriteLine($"{i}. {dog}");
        }
        foreach (var cat in cats)
        {
            i++;
            Console.WriteLine($"{i}. {cat}");
        }
        foreach (var lizard in lizards)
        {
            i++;
            Console.WriteLine($"{i}. {lizard}");
        }
        foreach (var bird in birds)
        {
            i++;
            Console.WriteLine($"{i}. {bird}");
        }
    }

    private void ViewPetsByCategory(Kind kind)
    {
        int i = 0;
        Console.WriteLine($"{kind}s:");
        switch (kind)
        {
            case Kind.Dog:
                foreach (var dog in dogs)
                {
                    i++;
                    Console.WriteLine($"{i}. {dog}");
                }
                break;
            case Kind.Cat:
                foreach (var cat in cats)
                {
                    i++;
                    Console.WriteLine($"{i}. {cat}");
                }
                break;
            case Kind.Lizard:
                foreach (var lizard in lizards)
                {
                    i++ ;
                    Console.WriteLine($"{i}. {lizard}");
                }
                break;
            case Kind.Bird:
                foreach (var bird in birds)
                {
                    i++;
                    Console.WriteLine($"{i}. {bird}");
                }
                break;
            default:
                Console.WriteLine("Unsupported pet kind.");
                break;
        }
    }
}