namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe2_Loesung
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
      LblAnleitung = new Label();
      TxtVermutung = new TextBox();
      BtnRaten = new Button();
      BtnNeuesSpiel = new Button();
      LblRueckmeldung = new Label();
      LblVersuche = new Label();
      SuspendLayout();
      // 
      // LblAnleitung
      // 
      LblAnleitung.AutoSize = true;
      LblAnleitung.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
      LblAnleitung.Location = new Point(37, 26);
      LblAnleitung.Name = "LblAnleitung";
      LblAnleitung.Size = new Size(413, 38);
      LblAnleitung.TabIndex = 0;
      LblAnleitung.Text = "Errate eine Zahl von 1 bis 100:";
      // 
      // TxtVermutung
      // 
      TxtVermutung.Location = new Point(37, 100);
      TxtVermutung.Name = "TxtVermutung";
      TxtVermutung.Size = new Size(125, 27);
      TxtVermutung.TabIndex = 1;
      // 
      // BtnRaten
      // 
      BtnRaten.Location = new Point(185, 100);
      BtnRaten.Name = "BtnRaten";
      BtnRaten.Size = new Size(94, 29);
      BtnRaten.TabIndex = 2;
      BtnRaten.Text = "Raten";
      BtnRaten.UseVisualStyleBackColor = true;
      BtnRaten.Click += BtnRaten_Click;
      // 
      // BtnNeuesSpiel
      // 
      BtnNeuesSpiel.Location = new Point(303, 100);
      BtnNeuesSpiel.Name = "BtnNeuesSpiel";
      BtnNeuesSpiel.Size = new Size(114, 29);
      BtnNeuesSpiel.TabIndex = 3;
      BtnNeuesSpiel.Text = "Neues Spiel";
      BtnNeuesSpiel.UseVisualStyleBackColor = true;
      BtnNeuesSpiel.Click += BtnNeuesSpiel_Click;
      // 
      // LblRueckmeldung
      // 
      LblRueckmeldung.AutoSize = true;
      LblRueckmeldung.Location = new Point(169, 168);
      LblRueckmeldung.Name = "LblRueckmeldung";
      LblRueckmeldung.Size = new Size(126, 20);
      LblRueckmeldung.TabIndex = 4;
      LblRueckmeldung.Text = "Bereit zum Raten!";
      // 
      // LblVersuche
      // 
      LblVersuche.AutoSize = true;
      LblVersuche.Location = new Point(197, 217);
      LblVersuche.Name = "LblVersuche";
      LblVersuche.Size = new Size(82, 20);
      LblVersuche.TabIndex = 5;
      LblVersuche.Text = "Versuche: 0";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(526, 295);
      Controls.Add(LblVersuche);
      Controls.Add(LblRueckmeldung);
      Controls.Add(BtnNeuesSpiel);
      Controls.Add(BtnRaten);
      Controls.Add(TxtVermutung);
      Controls.Add(LblAnleitung);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LblAnleitung;
    private TextBox TxtVermutung;
    private Button BtnRaten;
    private Button BtnNeuesSpiel;
    private Label LblRueckmeldung;
    private Label LblVersuche;
  }
}