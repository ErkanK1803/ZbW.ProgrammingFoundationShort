namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe1_Loesung
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
      GrpAmpel = new GroupBox();
      RdoGruen = new RadioButton();
      RdoGelb = new RadioButton();
      RdoRot = new RadioButton();
      CmdAnzeigen = new Button();
      LblErgebnis = new Label();
      GrpAmpel.SuspendLayout();
      SuspendLayout();
      // 
      // GrpAmpel
      // 
      GrpAmpel.Controls.Add(RdoGruen);
      GrpAmpel.Controls.Add(RdoGelb);
      GrpAmpel.Controls.Add(RdoRot);
      GrpAmpel.Location = new Point(64, 37);
      GrpAmpel.Name = "GrpAmpel";
      GrpAmpel.Size = new Size(156, 146);
      GrpAmpel.TabIndex = 0;
      GrpAmpel.TabStop = false;
      GrpAmpel.Text = "Ampelfarbe";
      // 
      // RdoGruen
      // 
      RdoGruen.AutoSize = true;
      RdoGruen.Location = new Point(6, 98);
      RdoGruen.Name = "RdoGruen";
      RdoGruen.Size = new Size(61, 24);
      RdoGruen.TabIndex = 2;
      RdoGruen.TabStop = true;
      RdoGruen.Text = "Grün";
      RdoGruen.UseVisualStyleBackColor = true;
      // 
      // RdoGelb
      // 
      RdoGelb.AutoSize = true;
      RdoGelb.Location = new Point(6, 68);
      RdoGelb.Name = "RdoGelb";
      RdoGelb.Size = new Size(61, 24);
      RdoGelb.TabIndex = 1;
      RdoGelb.TabStop = true;
      RdoGelb.Text = "Gelb";
      RdoGelb.UseVisualStyleBackColor = true;
      // 
      // RdoRot
      // 
      RdoRot.AutoSize = true;
      RdoRot.Checked = true;
      RdoRot.Location = new Point(6, 38);
      RdoRot.Name = "RdoRot";
      RdoRot.Size = new Size(53, 24);
      RdoRot.TabIndex = 0;
      RdoRot.TabStop = true;
      RdoRot.Text = "Rot";
      RdoRot.UseVisualStyleBackColor = true;
      // 
      // CmdAnzeigen
      // 
      CmdAnzeigen.Location = new Point(88, 222);
      CmdAnzeigen.Name = "CmdAnzeigen";
      CmdAnzeigen.Size = new Size(94, 29);
      CmdAnzeigen.TabIndex = 1;
      CmdAnzeigen.Text = "Anzeigen";
      CmdAnzeigen.UseVisualStyleBackColor = true;
      CmdAnzeigen.Click += CmdAnzeigen_Click;
      // 
      // LblErgebnis
      // 
      LblErgebnis.BackColor = SystemColors.ActiveBorder;
      LblErgebnis.Location = new Point(281, 46);
      LblErgebnis.Name = "LblErgebnis";
      LblErgebnis.Size = new Size(131, 137);
      LblErgebnis.TabIndex = 2;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(487, 474);
      Controls.Add(LblErgebnis);
      Controls.Add(CmdAnzeigen);
      Controls.Add(GrpAmpel);
      Name = "Form1";
      GrpAmpel.ResumeLayout(false);
      GrpAmpel.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private GroupBox GrpAmpel;
    private RadioButton RdoGruen;
    private RadioButton RdoGelb;
    private RadioButton RdoRot;
    private Button CmdAnzeigen;
    private Label LblErgebnis;
  }
}
