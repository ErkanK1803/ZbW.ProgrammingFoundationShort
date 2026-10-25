using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe2_Loesung
{
  public partial class Form1 : Form
  {
    const decimal ChfToEur = 1.05m;
    public Form1()
    {
      InitializeComponent();
    }

    private void CmdCHFtoEUR_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(TxtBetrag.Text, out decimal Betrag))
      {
        MessageBox.Show("Bitte geben Sie einen gültigen Betrag ein.");
        return;
      }
      if (Betrag < 0)
      {
        MessageBox.Show("Negative Beträge sind nicht erlaubt");
        return;
      }
      decimal euro = Betrag / ChfToEur;
      LblErgebnis.Text = $"{euro:F2} EUR";
    }

    private void CmdEURToCHF_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(TxtBetrag.Text, out decimal Betrag))
      {
        MessageBox.Show("Bitte geben Sie einen gültigen Betrag ein.");
        return;
      }
      if (Betrag < 0)
      {
        MessageBox.Show("Negative Beträge sind nicht erlaubt");
        return;
      }
      decimal franken = Betrag * ChfToEur;
      LblErgebnis.Text = $"{franken:F2} CHF";
    }
  }
}
