namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe2_Loesung
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
      txtEingabe = new TextBox();
      LblEingabe = new Label();
      btnAnalysieren = new Button();
      LblErgebnis = new Label();
      SuspendLayout();
      // 
      // txtEingabe
      // 
      txtEingabe.Location = new Point(79, 133);
      txtEingabe.Multiline = true;
      txtEingabe.Name = "txtEingabe";
      txtEingabe.ScrollBars = ScrollBars.Vertical;
      txtEingabe.Size = new Size(871, 223);
      txtEingabe.TabIndex = 0;
      // 
      // LblEingabe
      // 
      LblEingabe.AutoSize = true;
      LblEingabe.Location = new Point(79, 44);
      LblEingabe.Name = "LblEingabe";
      LblEingabe.Size = new Size(249, 48);
      LblEingabe.TabIndex = 1;
      LblEingabe.Text = "Text eingeben:";
      // 
      // btnAnalysieren
      // 
      btnAnalysieren.Location = new Point(364, 381);
      btnAnalysieren.Name = "btnAnalysieren";
      btnAnalysieren.Size = new Size(252, 118);
      btnAnalysieren.TabIndex = 2;
      btnAnalysieren.Text = "Analysieren";
      btnAnalysieren.UseVisualStyleBackColor = true;
      btnAnalysieren.Click += btnAnalysieren_Click;
      // 
      // LblErgebnis
      // 
      LblErgebnis.AutoSize = true;
      LblErgebnis.Location = new Point(407, 548);
      LblErgebnis.Name = "LblErgebnis";
      LblErgebnis.Size = new Size(156, 48);
      LblErgebnis.TabIndex = 3;
      LblErgebnis.Text = "Ergebnis";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(20F, 48F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1024, 685);
      Controls.Add(LblErgebnis);
      Controls.Add(btnAnalysieren);
      Controls.Add(LblEingabe);
      Controls.Add(txtEingabe);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox txtEingabe;
    private Label LblEingabe;
    private Button btnAnalysieren;
    private Label LblErgebnis;
  }
}