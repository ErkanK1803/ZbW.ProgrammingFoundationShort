using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Loesung
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void CmdBerechnen_Click(object sender, EventArgs e)
    {
      if (!double.TryParse(TxtGewicht.Text, out double gewicht))
      {
        MessageBox.Show("Bitte geben Sie ein gültiges Gewicht ein.");
        return;
      }
      if (!double.TryParse(TxtGroesse.Text, out double groesse))
      {
        MessageBox.Show("Bitte geben Sie eine gültige Grösse ein.");
        return;
      }
      if (gewicht <= 0 || groesse <= 0)
      {
        MessageBox.Show("Gewicht und Grösse müssen grösser als 0 sein.");
        return;
      }
      double bmi = gewicht / (groesse * groesse);

      LblErgebnis.Text = $"Ihr BMI beträgt: {bmi:F2}";
    }
  }
}
