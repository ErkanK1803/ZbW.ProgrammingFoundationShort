using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe3_Loesung
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void LblSumme_Click(object sender, EventArgs e)
    {

    }

    private void CmdAnalysieren_Click(object sender, EventArgs e)
    {
      if (!int.TryParse(TxtZahl1.Text, out int zahl1))
      {
        MessageBox.Show("Bitte geben Sie bei Zahl 1 eine ganze Zahl ein.");
        return;
      }
      if (!int.TryParse(TxtZahl2.Text, out int zahl2))
      {
        MessageBox.Show("Bitte geben Sie bei Zahl 2 eine ganze Zahl ein.");
        return;
      }
      if (!int.TryParse(TxtZahl3.Text, out int zahl3))
      {
        MessageBox.Show("Bitte geben Sie bei Zahl 3 eine ganze Zahl ein.");
        return;
      }
      long summe = (long)zahl1 + zahl2 + zahl3;
      LblSumme.Text = $"Summe: {summe}";

      double durchschnitt = summe / 3.0;
      LblDurchschnitt.Text = $"Durchschnitt: {durchschnitt:F2}";

      int groesste = zahl1;

      if (zahl2 > groesste)
      {
        groesste = zahl2;
      }
      if (zahl3 > groesste)
      {
        groesste = zahl3;
      }

      LblGroesste.Text = $"Grösste Zahl: {groesste}";

      int kleinste = zahl1;

      if (zahl2 < kleinste)
      {
        kleinste = zahl2;
      }
      if (zahl3 < kleinste)
      {
        kleinste = zahl3;
      }

      LblKleinste.Text = $"Kleinste Zahl: {kleinste}";

      if (summe % 2 == 0)
      {
        LblUngeradeGerade.Text = "Summe ist: gerade";
      }
      else
      {
        LblUngeradeGerade.Text = "Summe ist: ungerade";
      }
    }

    private void LblDurchschnitt_Click(object sender, EventArgs e)
    {

    }
  }
}
