using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe1_Loesung
{

  public enum TrafficLightColor { Red, Yellow, Green }

  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void RdoRot_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void CmdAnzeigen_Click(object sender, EventArgs e)
    {
      TrafficLightColor farbe;

      if (RdoRot.Checked)
      {
        farbe = TrafficLightColor.Red;
      }
      else if (RdoGelb.Checked)
      {
        farbe = TrafficLightColor.Yellow;
      }
      else
      {
        farbe = TrafficLightColor.Green;
      }
      switch (farbe)
      {
        case TrafficLightColor.Red:
          LblErgebnis.Text = "Anhalten!";
          LblErgebnis.BackColor = Color.Red;
          break;

        case TrafficLightColor.Yellow:
          LblErgebnis.Text = "Vorsicht, bremsen!";
          LblErgebnis.BackColor = Color.Yellow;
          break;

        case TrafficLightColor.Green:
          LblErgebnis.Text = "Fahren!";
          LblErgebnis.BackColor = Color.Green;
          break;
      }
    }
  }
}
