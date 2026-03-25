namespace raid_simulation;

public class RaidLVL
{
   public String raidName;

   public RaidLVL()
    {
       raidName = "RAID";
    }

    public String Raidchoice(int level)
    {
        switch (level) //nur 0,1,5 Eingabe zulassen
        {
            case 0:
                raidName = "RAID0";
                break;

            case 1:
                raidName = "RAID1";
                break;
            
            case 5: 
                raidName = "RAID5";
                break;
        }

        return raidName;
    }

}
