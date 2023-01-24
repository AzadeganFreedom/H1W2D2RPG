using H1W2D2RPG;

Character firstChar = new Character();
//firstChar.Name = "EtEllerAndet";

//the method is static, so it runs on the class and not the object
firstChar.CharacterClass = Character.GetCharacterClassRandomly();
firstChar.CharacterGender = Character.GetRandomGender();
firstChar.CharacterRace = Character.GetRandomRace();
//firstChar.CharacterStats = Stats.GetRolled();
firstChar.Stats.GetRolled();
firstChar.Stats.Dexterity = 1;


/*static void Menu(Character firstChar)
{

    Console.WriteLine("(1) Show Character");

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            {
                Console.WriteLine(firstChar.Name + " the " + firstChar.CharacterRace + " " + firstChar.CharacterClass + "\n");
                Console.WriteLine("Gender: " + firstChar.CharacterGender);

                Console.WriteLine("--------------");
                firstChar.Stats.ShowStats();
                Console.WriteLine("--------------");
                break;
            }
    }
}*/
Console.WriteLine(firstChar.Name + " the " + firstChar.CharacterRace + " " + firstChar.CharacterClass + "\n");
Console.WriteLine("Gender: " + firstChar.CharacterGender);

Console.WriteLine("--------------");
firstChar.Stats.ShowStats();
Console.WriteLine("--------------");


