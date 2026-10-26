namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe3_Loesung
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      TxtZahl1 = new TextBox();
      TxtZahl2 = new TextBox();
      TxtZahl3 = new TextBox();
      LblZahl1 = new Label();
      LblZahl2 = new Label();
      LblZahl3 = new Label();
      CmdAnalysieren = new Button();
      LblSumme = new Label();
      LblDurchschnitt = new Label();
      LblGroesste = new Label();
      LblKleinste = new Label();
      LblUngeradeGerade = new Label();
      SuspendLayout();
      // 
      // TxtZahl1
      // 
      TxtZahl1.Location = new Point(161, 72);
      TxtZahl1.Name = "TxtZahl1";
      TxtZahl1.Size = new Size(125, 27);
      TxtZahl1.TabIndex = 0;
      // 
      // TxtZahl2
      // 
      TxtZahl2.Location = new Point(161, 144);
      TxtZahl2.Name = "TxtZahl2";
      TxtZahl2.Size = new Size(125, 27);
      TxtZahl2.TabIndex = 1;
      // 
      // TxtZahl3
      // 
      TxtZahl3.Location = new Point(160, 219);
      TxtZahl3.Name = "TxtZahl3";
      TxtZahl3.Size = new Size(125, 27);
      TxtZahl3.TabIndex = 2;
      // 
      // LblZahl1
      // 
      LblZahl1.AutoSize = true;
      LblZahl1.Location = new Point(84, 72);
      LblZahl1.Name = "LblZahl1";
      LblZahl1.Size = new Size(50, 20);
      LblZahl1.TabIndex = 3;
      LblZahl1.Text = "Zahl 1";
      // 
      // LblZahl2
      // 
      LblZahl2.AutoSize = true;
      LblZahl2.Location = new Point(84, 151);
      LblZahl2.Name = "LblZahl2";
      LblZahl2.Size = new Size(50, 20);
      LblZahl2.TabIndex = 4;
      LblZahl2.Text = "Zahl 2";
      // 
      // LblZahl3
      // 
      LblZahl3.AutoSize = true;
      LblZahl3.Location = new Point(84, 226);
      LblZahl3.Name = "LblZahl3";
      LblZahl3.Size = new Size(50, 20);
      LblZahl3.TabIndex = 5;
      LblZahl3.Text = "Zahl 3";
      // 
      // CmdAnalysieren
      // 
      CmdAnalysieren.Location = new Point(204, 435);
      CmdAnalysieren.Name = "CmdAnalysieren";
      CmdAnalysieren.Size = new Size(94, 29);
      CmdAnalysieren.TabIndex = 6;
      CmdAnalysieren.Text = "Analysieren";
      CmdAnalysieren.UseVisualStyleBackColor = true;
      CmdAnalysieren.Click += CmdAnalysieren_Click;
      // 
      // LblSumme
      // 
      LblSumme.AutoSize = true;
      LblSumme.Location = new Point(226, 297);
      LblSumme.Name = "LblSumme";
      LblSumme.Size = new Size(59, 20);
      LblSumme.TabIndex = 7;
      LblSumme.Text = "Summe";
      LblSumme.Click += LblSumme_Click;
      // 
      // LblDurchschnitt
      // 
      LblDurchschnitt.AutoSize = true;
      LblDurchschnitt.Location = new Point(204, 317);
      LblDurchschnitt.Name = "LblDurchschnitt";
      LblDurchschnitt.Size = new Size(91, 20);
      LblDurchschnitt.TabIndex = 8;
      LblDurchschnitt.Text = "Durchschnitt";
      LblDurchschnitt.Click += LblDurchschnitt_Click;
      // 
      // LblGroesste
      // 
      LblGroesste.AutoSize = true;
      LblGroesste.Location = new Point(204, 337);
      LblGroesste.Name = "LblGroesste";
      LblGroesste.Size = new Size(91, 20);
      LblGroesste.TabIndex = 9;
      LblGroesste.Text = "Grösste Zahl";
      // 
      // LblKleinste
      // 
      LblKleinste.AutoSize = true;
      LblKleinste.Location = new Point(204, 357);
      LblKleinste.Name = "LblKleinste";
      LblKleinste.Size = new Size(94, 20);
      LblKleinste.TabIndex = 10;
      LblKleinste.Text = "Kleinste Zahl";
      // 
      // LblUngeradeGerade
      // 
      LblUngeradeGerade.AutoSize = true;
      LblUngeradeGerade.Location = new Point(213, 377);
      LblUngeradeGerade.Name = "LblUngeradeGerade";
      LblUngeradeGerade.Size = new Size(81, 20);
      LblUngeradeGerade.TabIndex = 11;
      LblUngeradeGerade.Text = "Summe ist:";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(490, 476);
      Controls.Add(LblUngeradeGerade);
      Controls.Add(LblKleinste);
      Controls.Add(LblGroesste);
      Controls.Add(LblDurchschnitt);
      Controls.Add(LblSumme);
      Controls.Add(CmdAnalysieren);
      Controls.Add(LblZahl3);
      Controls.Add(LblZahl2);
      Controls.Add(LblZahl1);
      Controls.Add(TxtZahl3);
      Controls.Add(TxtZahl2);
      Controls.Add(TxtZahl1);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox TxtZahl1;
    private TextBox TxtZahl2;
    private TextBox TxtZahl3;
    private Label LblZahl1;
    private Label LblZahl2;
    private Label LblZahl3;
    private Button CmdAnalysieren;
    private Label LblSumme;
    private Label LblDurchschnitt;
    private Label LblGroesste;
    private Label LblKleinste;
    private Label LblUngeradeGerade;
  }
}
