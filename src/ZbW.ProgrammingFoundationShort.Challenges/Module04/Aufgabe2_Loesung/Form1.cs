using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe2_Loesung
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnAnalysieren_Click(object sender, EventArgs e)
    {
      string text = txtEingabe.Text;
      string[] woerter = TextToWords(text);
      LblErgebnis.Text = $"Wörter: {CountWords(woerter)}\n" +
        $"Zeichen: {CountCharacters(text)}\n" +
        $"Längstes Wort: {LongestWord(woerter)}";
                    
    }
    private string[] TextToWords(string text)
    {
      return text.Split(
        new[] {' ', '\r', '\n', '\t'},
        StringSplitOptions.RemoveEmptyEntries);
    }

    private int CountWords(string[] words)
    {
      return words.Length;
    }

    private int CountCharacters(string text)
    {
      int anzahl = 0;

      foreach (char zeichen in text)
      {
        if (!char.IsWhiteSpace(zeichen))
        {
          anzahl++;
        }
      }
      return anzahl;
    }

    private string LongestWord(string[] words)
    {
      string laengstes = "";

      foreach (string wort in words)
      {
        if (wort.Length > laengstes.Length)
        {
          laengstes = wort;
        }
      }
      return laengstes;
    }
  }
}
