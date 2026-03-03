/**
* LZ010 Anwendung, die die grundliegende Funktion von RAID simulieren soll. 
* Class: Main
* version: 1.0_thatch; erstellt
*/
import java.util.*;
import hardwaresimulation.*; 
import navigationtext.*;

public class RaidSimulation {
	public static void main(String[] args) {
		
		System.out.println("Sie wünschen einen RAID einzurichten?");
		System.out.print("Bitte geben Sie die gewünschte Konfiguration an: ");
		
		String raid = Raid.konfigurieren();
		System.out.println("Sie haben " + raid + " gewählt.");
		
		//Dialog Datensatz erstellen
		System.out.println("Bitte geben Sie Ihren zu speichernden Text ein.");
		String datensatz = Datensatz.erstellen();
		System.out.println("Diesen Datensatz speichern?");
		System.out.print("Datensatz: " + datensatz);
		
	}
}