/**
* Stellt Funktionen für die Nutzung von Datensätzen in Simulationen bereit.
*/
package hardwaresimulation;
import java.util.*;

public class Datensatz {
	//Funktionen
	public static String erstellen() {
		Scanner neuerDatensatz = new Scanner (System.in);
		String eingabe = "leer"; 
		
		eingabe = neuerDatensatz.nextLine();//Scanner
						
		return eingabe;
			
	}
}