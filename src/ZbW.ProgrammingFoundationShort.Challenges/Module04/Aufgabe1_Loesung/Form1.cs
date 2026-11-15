using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe1_Loesung
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void btnAuswerten_Click(object sender, EventArgs e)
    {
      TextBox[] felder =
{
    txtMontag, txtDienstag, txtMittwoch, txtDonnerstag,
    txtFreitag, txtSamstag, txtSonntag
};

      double[] temperaturen = new double[felder.Length];

      for (int i = 0; i < felder.Length; i++)
      {
        if (!double.TryParse(felder[i].Text, out double temperatur))
        {
          MessageBox.Show($"Bitte in Feld {i + 1} eine gültige Temperatur eingeben.");
          felder[i].Focus();
          return;
        }

        temperaturen[i] = temperatur;
      }

      lblDurchschnitt.Text = $"Durchschnitt: {Average(temperaturen):F1} °C";
      lblMaximum.Text = $"Höchste Temperatur: {Maximum(temperaturen):F1} °C";
      lblMinimum.Text = $"Tiefste Temperatur: {Minimum(temperaturen):F1} °C";
    }
    private double Average(double[] values)
    {
      double summe = 0;

      foreach (double temperatur in values)
      {
        summe += temperatur;
      }

      return summe / values.Length;
    }
    private double Maximum(double[] values)
    {
      double max = values[0];

      foreach (double temperatur in values)
      {
        if (temperatur > max)
        {
          max = temperatur;
        }
      }

      return max;
    }
    private double Minimum(double[] values)
    {
      double min = values[0];

      foreach (double temperatur in values)
      {
        if (temperatur < min)
        {
          min = temperatur;
        }
      }

      return min;
    }
  }
}
