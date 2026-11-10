namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe1_Loesung
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
      TxtZahl = new TextBox();
      LblZahl = new Label();
      ChkRueckwerts = new CheckBox();
      BtnAnzeigen = new Button();
      TxtAnzeigen = new TextBox();
      SuspendLayout();
      // 
      // TxtZahl
      // 
      TxtZahl.Location = new Point(170, 55);
      TxtZahl.Name = "TxtZahl";
      TxtZahl.Size = new Size(125, 27);
      TxtZahl.TabIndex = 0;
      // 
      // LblZahl
      // 
      LblZahl.AutoSize = true;
      LblZahl.Location = new Point(51, 55);
      LblZahl.Name = "LblZahl";
      LblZahl.Size = new Size(85, 20);
      LblZahl.TabIndex = 1;
      LblZahl.Text = "Zahl (1-10):";
      // 
      // ChkRueckwerts
      // 
      ChkRueckwerts.AutoSize = true;
      ChkRueckwerts.Location = new Point(51, 113);
      ChkRueckwerts.Name = "ChkRueckwerts";
      ChkRueckwerts.Size = new Size(159, 24);
      ChkRueckwerts.TabIndex = 2;
      ChkRueckwerts.Text = "Rückwärts (10 -> 1)";
      ChkRueckwerts.UseVisualStyleBackColor = true;
      // 
      // BtnAnzeigen
      // 
      BtnAnzeigen.Location = new Point(116, 159);
      BtnAnzeigen.Name = "BtnAnzeigen";
      BtnAnzeigen.Size = new Size(94, 29);
      BtnAnzeigen.TabIndex = 3;
      BtnAnzeigen.Text = "Anzeigen";
      BtnAnzeigen.UseVisualStyleBackColor = true;
      BtnAnzeigen.Click += BtnAnzeigen_Click;
      // 
      // TxtAnzeigen
      // 
      TxtAnzeigen.Location = new Point(51, 210);
      TxtAnzeigen.Multiline = true;
      TxtAnzeigen.Name = "TxtAnzeigen";
      TxtAnzeigen.ReadOnly = true;
      TxtAnzeigen.ScrollBars = ScrollBars.Vertical;
      TxtAnzeigen.Size = new Size(247, 210);
      TxtAnzeigen.TabIndex = 4;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(356, 457);
      Controls.Add(TxtAnzeigen);
      Controls.Add(BtnAnzeigen);
      Controls.Add(ChkRueckwerts);
      Controls.Add(LblZahl);
      Controls.Add(TxtZahl);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox TxtZahl;
    private Label LblZahl;
    private CheckBox ChkRueckwerts;
    private Button BtnAnzeigen;
    private TextBox TxtAnzeigen;
  }
}