/**
* Stellt Funktionen für die Simulation von Raidkonfigurationen bereit.
*/
package hardwaresimulation;
import java.util.*;


public class Raid {
		static String raidKonfig;
		
	public static String konfigurieren() {
		Scanner neuerRaid = new Scanner (System.in);
		int eingabe; 
		
		eingabe = neuerRaid.nextInt();//Scanner
		//Darf später nur 0,1,5 annehmen (Kombi 1+0 wird vorerst unberücksichtigt)
				
		switch(eingabe){
			case 0: 
				raidKonfig = "RAID0";
				break;
			case 1:
				raidKonfig = "RAID1";
				break;
			case 5: 
				raidKonfig = "RAID5";
				break;
		}
		
		return raidKonfig;
			
	}
	
	
	//Raid0
	
	//Raid1
	
	//Raid5
 
}