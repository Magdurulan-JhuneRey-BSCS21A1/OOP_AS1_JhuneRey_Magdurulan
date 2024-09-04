using System;
interface IMakeSound
{
    public string sound { get; }
}


enum Kind
{
    Dog, Cat, Lizard, Bird
}

enum Gender
{
    Male, Female
}

class Pet
{
    public string Name { get; set; }
    public Kind Kind { get; set; }
    public Gender Gender { get; set; }
    public string Owner { get; set; }

    public Pet(string name, Kind kind, Gender gender, string owner)
    {
        Name = name;
        Kind = kind;
        Gender = gender;
        Owner = owner;
    }

    public override string ToString()
    {
        return $"Pet Name: {Name}\nKind: {Kind}\nGender: {Gender}\nOwner: {Owner}\n";
    }
}
class Dog : Pet, IMakeSound
{
    public string sound => "Woof Woof Woof";
    public string Unique { get; } = "Canine";

    public Dog(string name, Gender gender, string owner)
        : base(name, Kind.Dog, gender, owner)
    {
    }

    public override string ToString()
    {
        return base.ToString() + $"Unique Trait: {Unique}\n";
    }

  

}

class Cat : Pet, IMakeSound
{
    public string sound => "Meww Meww Meww";
    public string Unique { get; } = "Feline";
    public Cat(string name, Gender gender, string owner)
        : base(name, Kind.Cat, gender, owner)
    {
    }
    public override string ToString()
    {
        return base.ToString() + $"Unique Trait: {Unique}\n";
    }

}

class Lizard : Pet, IMakeSound
{
    public string sound => "Hissssss";
    public string Unique { get; } = "Scales";
    public Lizard(string name, Gender gender, string owner)
        : base(name, Kind.Lizard, gender, owner)
    {
    }
    public override string ToString()
    {
        return base.ToString() + $"Unique Trait: {Unique}\n";
    }
}

class Bird : Pet, IMakeSound
{
    public string sound => "Tweeeeet";
    public string Unique { get; } = "Scales";
    public Bird(string name, Gender gender, string owner)
        : base(name, Kind.Bird, gender, owner)
    {
    }
    public override string ToString()
    {
        return base.ToString() + $"Unique Trait: {Unique}\n";
    }


}

