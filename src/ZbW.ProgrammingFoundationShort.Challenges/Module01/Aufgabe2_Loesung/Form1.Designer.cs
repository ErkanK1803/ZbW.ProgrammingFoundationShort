namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe2_Loesung
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
      LblBetrag = new Label();
      TxtBetrag = new TextBox();
      CmdCHFtoEUR = new Button();
      CmdEURToCHF = new Button();
      LblKurs = new Label();
      LblErgebnis = new Label();
      SuspendLayout();
      // 
      // LblBetrag
      // 
      LblBetrag.AutoSize = true;
      LblBetrag.Location = new Point(58, 53);
      LblBetrag.Name = "LblBetrag";
      LblBetrag.Size = new Size(41, 15);
      LblBetrag.TabIndex = 0;
      LblBetrag.Text = "Betrag";
      // 
      // TxtBetrag
      // 
      TxtBetrag.Location = new Point(119, 50);
      TxtBetrag.Name = "TxtBetrag";
      TxtBetrag.Size = new Size(100, 23);
      TxtBetrag.TabIndex = 1;
      // 
      // CmdCHFtoEUR
      // 
      CmdCHFtoEUR.Location = new Point(119, 106);
      CmdCHFtoEUR.Name = "CmdCHFtoEUR";
      CmdCHFtoEUR.Size = new Size(99, 23);
      CmdCHFtoEUR.TabIndex = 2;
      CmdCHFtoEUR.Text = "CHF -> EUR";
      CmdCHFtoEUR.UseVisualStyleBackColor = true;
      CmdCHFtoEUR.Click += CmdCHFtoEUR_Click;
      // 
      // CmdEURToCHF
      // 
      CmdEURToCHF.Location = new Point(247, 106);
      CmdEURToCHF.Name = "CmdEURToCHF";
      CmdEURToCHF.Size = new Size(101, 23);
      CmdEURToCHF.TabIndex = 3;
      CmdEURToCHF.Text = "EUR -> CHF";
      CmdEURToCHF.UseVisualStyleBackColor = true;
      CmdEURToCHF.Click += CmdEURToCHF_Click;
      // 
      // LblKurs
      // 
      LblKurs.AutoSize = true;
      LblKurs.Location = new Point(121, 204);
      LblKurs.Name = "LblKurs";
      LblKurs.Size = new Size(98, 15);
      LblKurs.TabIndex = 4;
      LblKurs.Text = "1 EUR = 1.05 CHF";
      // 
      // LblErgebnis
      // 
      LblErgebnis.AutoSize = true;
      LblErgebnis.Location = new Point(209, 168);
      LblErgebnis.Name = "LblErgebnis";
      LblErgebnis.Size = new Size(52, 15);
      LblErgebnis.TabIndex = 5;
      LblErgebnis.Text = "Ergebnis";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(433, 228);
      Controls.Add(LblErgebnis);
      Controls.Add(LblKurs);
      Controls.Add(CmdEURToCHF);
      Controls.Add(CmdCHFtoEUR);
      Controls.Add(TxtBetrag);
      Controls.Add(LblBetrag);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LblBetrag;
    private TextBox TxtBetrag;
    private Button CmdCHFtoEUR;
    private Button CmdEURToCHF;
    private Label LblKurs;
    private Label LblErgebnis;
  }
}