using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe1_Loesung
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void BtnAnzeigen_Click(object sender, EventArgs e)
    {
      if (!int.TryParse(TxtZahl.Text, out int zahl))
      {
        MessageBox.Show("Bitte eine ganze Zahl eingeben.");
        return;
      }
      if (zahl < 1 || zahl > 10)
      {
        MessageBox.Show("Bitte eine Zahl von 1 bis 10 eingeben.");
        return;
      }

      TxtAnzeigen.Clear();

      for (int i = 1; i<= 10; i++)
      {
        int ergebnis = zahl * i;

        TxtAnzeigen.AppendText(
          $"{zahl} * {i} = {ergebnis}" + Environment.NewLine);
      }

      if (ChkRueckwerts.Checked)
      {
        TxtAnzeigen.AppendText(Environment.NewLine);

        for (int i = 10; i >= 1; i--)
        {
          int ergebnis = zahl * i;

          TxtAnzeigen.AppendText(
            $"{zahl} * {i} = {ergebnis}" + Environment.NewLine);

        }
      }
    }
  }
}
