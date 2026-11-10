namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================

public static class Zahlenraten
{
  public static void Start()
  {
   
   var random = new Random();
   int geheimzahl = random.Next(1, 101);

   int versuche = 0;
   bool geraten = false;

   while (!geraten)
    {
      Console.Write("Rate eine Zahl zwischen 0 und 100");
      string eingabe = Console.ReadLine();

      if (!int.TryParse(eingabe, out int tipp))
      {
        Console.WriteLine("Bitte eine ganze Zahl eingeben!");
        continue;
      }

      versuche++;

      if (tipp < geheimzahl)
      {
        Console.WriteLine("Deine Zahl ist zu tief!");
      }
      else if (tipp > geheimzahl)
      {
        Console.WriteLine("Deine Zahl ist zu hoch!");
      }
      else
      {
        geraten = true;
      }     
    }

    Console.WriteLine("Richtig! Anzahl Versuche: " + versuche);
  }
}
