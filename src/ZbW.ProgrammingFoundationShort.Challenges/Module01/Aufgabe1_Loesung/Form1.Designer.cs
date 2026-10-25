namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Loesung
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
      CmdBerechnen = new Button();
      TxtGewicht = new TextBox();
      TxtGroesse = new TextBox();
      LblGewicht = new Label();
      LblGroesse = new Label();
      LblGewichtEinheit = new Label();
      LblGroesseEinheit = new Label();
      LblErgebnis = new Label();
      SuspendLayout();
      // 
      // CmdBerechnen
      // 
      CmdBerechnen.Location = new Point(187, 192);
      CmdBerechnen.Name = "CmdBerechnen";
      CmdBerechnen.Size = new Size(100, 23);
      CmdBerechnen.TabIndex = 0;
      CmdBerechnen.Text = "BMI berechnen";
      CmdBerechnen.UseVisualStyleBackColor = true;
      CmdBerechnen.Click += CmdBerechnen_Click;
      // 
      // TxtGewicht
      // 
      TxtGewicht.Location = new Point(119, 37);
      TxtGewicht.Name = "TxtGewicht";
      TxtGewicht.Size = new Size(100, 23);
      TxtGewicht.TabIndex = 1;
      TxtGewicht.TextChanged += textBox1_TextChanged;
      // 
      // TxtGroesse
      // 
      TxtGroesse.Location = new Point(119, 83);
      TxtGroesse.Name = "TxtGroesse";
      TxtGroesse.Size = new Size(100, 23);
      TxtGroesse.TabIndex = 2;
      // 
      // LblGewicht
      // 
      LblGewicht.AutoSize = true;
      LblGewicht.Location = new Point(33, 37);
      LblGewicht.Name = "LblGewicht";
      LblGewicht.Size = new Size(50, 15);
      LblGewicht.TabIndex = 3;
      LblGewicht.Text = "Gewicht";
      LblGewicht.Click += label1_Click;
      // 
      // LblGroesse
      // 
      LblGroesse.AutoSize = true;
      LblGroesse.Location = new Point(33, 83);
      LblGroesse.Name = "LblGroesse";
      LblGroesse.Size = new Size(42, 15);
      LblGroesse.TabIndex = 4;
      LblGroesse.Text = "Grösse";
      // 
      // LblGewichtEinheit
      // 
      LblGewichtEinheit.AutoSize = true;
      LblGewichtEinheit.Location = new Point(235, 40);
      LblGewichtEinheit.Name = "LblGewichtEinheit";
      LblGewichtEinheit.Size = new Size(20, 15);
      LblGewichtEinheit.TabIndex = 5;
      LblGewichtEinheit.Text = "kg";
      // 
      // LblGroesseEinheit
      // 
      LblGroesseEinheit.AutoSize = true;
      LblGroesseEinheit.Location = new Point(235, 91);
      LblGroesseEinheit.Name = "LblGroesseEinheit";
      LblGroesseEinheit.Size = new Size(18, 15);
      LblGroesseEinheit.TabIndex = 6;
      LblGroesseEinheit.Text = "m";
      // 
      // LblErgebnis
      // 
      LblErgebnis.AutoSize = true;
      LblErgebnis.Location = new Point(176, 155);
      LblErgebnis.Name = "LblErgebnis";
      LblErgebnis.Size = new Size(121, 15);
      LblErgebnis.TabIndex = 7;
      LblErgebnis.Text = "Hier erscheint ihr BMI";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(466, 227);
      Controls.Add(LblErgebnis);
      Controls.Add(LblGroesseEinheit);
      Controls.Add(LblGewichtEinheit);
      Controls.Add(LblGroesse);
      Controls.Add(LblGewicht);
      Controls.Add(TxtGroesse);
      Controls.Add(TxtGewicht);
      Controls.Add(CmdBerechnen);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button CmdBerechnen;
    private TextBox TxtGewicht;
    private TextBox TxtGroesse;
    private Label LblGewicht;
    private Label LblGroesse;
    private Label LblGewichtEinheit;
    private Label LblGroesseEinheit;
    private Label LblErgebnis;
  }
}