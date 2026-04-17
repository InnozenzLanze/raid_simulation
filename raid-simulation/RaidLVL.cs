namespace raid_simulation;

public class RaidLVL
{
   public String raidName;
   public String[] storage; //Groesse abhaengig von Mindestanzahl Festplatten
   public int usedCapacity;

   public RaidLVL() //Constructor Raid
    {
       raidName = "RAID";
       usedCapacity = 0;
       storage = new String[2];
    }
}

public interface IRaidCreator //Interface fuer RAID0, 1, 5
{
    RaidLVL CreateRaid();
}

public class RaidZeroCreator : IRaidCreator
{
    public RaidLVL CreateRaid() =>  new RaidZero();
}

public class RaidOneCreator : IRaidCreator
{
    public RaidLVL CreateRaid() => new RaidOne();
}

public class RaidFiveCreator : IRaidCreator
{
    public RaidLVL CreateRaid() => new RaidFive();
}

public class RaidZero : RaidLVL //Kindklassen RAID 0, 1, 5
{
    public RaidZero() //Constructor
    {
        raidName = "RAID0";
    }
    
    public String[] Striping(String userInput)
    {
        String[] stripedData = new String[2];
        //userInput in Strings zerschneiden
        return stripedData;
    }
}
public class RaidOne : RaidLVL
{
    public RaidOne() //Constructor
    {
        raidName = "RAID1";
    }
    public String[] Mirroring(String userInput)
    {
        String[] mirroredData = new String[2];
        //userInput in Strings spiegeln (duplizieren)
        return mirroredData;
    }
}

public class RaidFive : RaidLVL
{
    public RaidFive()
    {
        raidName = "RAID5";
        storage = new String[3];
    }

    public String[] Parity(String userInput)
    {
        String[] parityData = new String[2];
        //userInput in Strings spiegeln (duplizieren) Datengroeße reduzieren
        return parityData;
    }
}
