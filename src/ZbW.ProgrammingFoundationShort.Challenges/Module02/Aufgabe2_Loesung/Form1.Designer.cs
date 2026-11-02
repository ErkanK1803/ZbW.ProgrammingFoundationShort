namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe2_Loesung
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
      LblNote = new Label();
      TxtNote = new TextBox();
      CheckDetails = new CheckBox();
      button1 = new Button();
      LblErgebnis = new Label();
      SuspendLayout();
      // 
      // LblNote
      // 
      LblNote.AutoSize = true;
      LblNote.Location = new Point(43, 50);
      LblNote.Name = "LblNote";
      LblNote.Size = new Size(147, 20);
      LblNote.TabIndex = 0;
      LblNote.Text = "Note eingeben (1-6):";
      // 
      // TxtNote
      // 
      TxtNote.Location = new Point(196, 47);
      TxtNote.Name = "TxtNote";
      TxtNote.Size = new Size(125, 27);
      TxtNote.TabIndex = 1;
      // 
      // CheckDetails
      // 
      CheckDetails.AutoSize = true;
      CheckDetails.Location = new Point(43, 103);
      CheckDetails.Name = "CheckDetails";
      CheckDetails.Size = new Size(242, 24);
      CheckDetails.TabIndex = 2;
      CheckDetails.Text = "Details anzeigen (Prozentwerte)";
      CheckDetails.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      button1.AutoSize = true;
      button1.Location = new Point(120, 188);
      button1.Name = "button1";
      button1.Size = new Size(81, 30);
      button1.TabIndex = 3;
      button1.Text = "Bewerten";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // LblErgebnis
      // 
      LblErgebnis.AutoSize = true;
      LblErgebnis.Location = new Point(65, 137);
      LblErgebnis.Name = "LblErgebnis";
      LblErgebnis.Size = new Size(200, 20);
      LblErgebnis.TabIndex = 4;
      LblErgebnis.Text = "Hier erscheint die Bewertung";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(341, 254);
      Controls.Add(LblErgebnis);
      Controls.Add(button1);
      Controls.Add(CheckDetails);
      Controls.Add(TxtNote);
      Controls.Add(LblNote);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LblNote;
    private TextBox TxtNote;
    private CheckBox CheckDetails;
    private Button button1;
    private Label LblErgebnis;
  }
}