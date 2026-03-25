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

        myRaid.Raidchoice(raidChoice);
        Console.WriteLine(Dialog.CHOSEN_RAID + myRaid.raidName);
   
    }
}
