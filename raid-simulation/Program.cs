namespace raid_simulation;

class Program
{
    static void Main(string[] args)
    {
        RaidLVL myRaid = new RaidLVL();
        int raidChoice;
        String userInput;
        
        Console.WriteLine(Dialog.INITIAL_DIALOG);
        //Nutzereingabe
        raidChoice = Convert.ToInt32(Console.ReadLine()); //nur 0,1,5 zulassen

        IRaidCreator raidCreator;
        
        switch (raidChoice)
        {
            case 0:
                raidCreator = new RaidZeroCreator();
                break;

            case 1:
                raidCreator = new RaidOneCreator();
                break;
            
            case 5:
                raidCreator = new RaidFiveCreator();
                break;
            default:
                throw new ArgumentException("ungueltige Eingabe");
        }
        RaidLVL raid = raidCreator.CreateRaid();

        Console.WriteLine(Dialog.CHOSEN_RAID + raid.raidName);

        //User Input und Verarbeitung temp (spaeter als RAIDLVL.Methoden)

        Console.Write("Bitte geben Sie Ihren zu speichernden Text ein:");
        userInput = Console.ReadLine();

    }
}
