using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe2_Loesung
{
  public partial class Form1 : Form
  {
    private Random zufall = new Random();
    private int geheimeZahl;
    private int versuche = 0;
    public Form1()
    {
      InitializeComponent();
      geheimeZahl = zufall.Next(1, 101);
    }

    private void BtnRaten_Click(object sender, EventArgs e)
    {
      if (!int.TryParse(TxtVermutung.Text, out int tipp))
      {
        MessageBox.Show("Bitte eine ganze Zahl eingeben.");
        return;
      }

      versuche++;
      LblVersuche.Text = $"Versuche: {versuche}";

      if (tipp < geheimeZahl)
      {
        LblRueckmeldung.Text = "zu klein!";
      }
      else if (tipp > geheimeZahl)
      {
        LblRueckmeldung.Text = "Zu gross!";
      }
      else
      {
        LblRueckmeldung.Text = "Richtig";

        MessageBox.Show(
        $"Glückwunsch! Du hast {versuche} Versuche gebraucht.");
      }

    }

    private void BtnNeuesSpiel_Click(object sender, EventArgs e)
    {
      geheimeZahl = zufall.Next(1, 101);
      versuche = 0;

      LblVersuche.Text = "Versuche: 0";
      LblRueckmeldung.Text = "Bereit zum Raten!";

      TxtVermutung.Clear();
    }
  }
}
