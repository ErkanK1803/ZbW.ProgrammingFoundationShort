using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe2_Loesung
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!double.TryParse(TxtNote.Text, out double note))
      {
        LblErgebnis.Text = "Bitte eine gültige Zahl eingeben!";
        return;
      }

      if (note < 1 || note > 6)
      {
        LblErgebnis.Text = "Die Note muss zwischen 1 und 6 liegen!";
        return;
      }

      string bewertung;

      if (note >= 5.5)
      {
        bewertung = "Sehr gut";
      }
      else if (note >= 4.5)
      {
        bewertung = "Gut";
      }
      else if (note >= 4.0)
      {
        bewertung = "Genügend";
      }
      else
      {
        bewertung = "Ungenügend";
      }

      LblErgebnis.Text = bewertung;

      if (CheckDetails.Checked)
      {
        double prozent = (note - 1) / 5 * 100;
        LblErgebnis.Text +=$"\n({prozent:F1}%)";
      }
    }
  }
}
