namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe3_Versicherungspraemie;

partial class VersicherungspraemieForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblAlter = new Label();
    TxtAlter = new TextBox();
    GrpTyp = new GroupBox();
    RadBasis = new RadioButton();
    RadStandard = new RadioButton();
    RadPremium = new RadioButton();
    ChkUnfall = new CheckBox();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    GrpTyp.SuspendLayout();
    SuspendLayout();
    // 
    // LblAlter
    // 
    LblAlter.AutoSize = true;
    LblAlter.Location = new Point(14, 27);
    LblAlter.Name = "LblAlter";
    LblAlter.Size = new Size(92, 20);
    LblAlter.TabIndex = 0;
    LblAlter.Text = "Alter (Jahre):";
    // 
    // TxtAlter
    // 
    TxtAlter.Location = new Point(149, 23);
    TxtAlter.Margin = new Padding(3, 4, 3, 4);
    TxtAlter.Name = "TxtAlter";
    TxtAlter.Size = new Size(91, 27);
    TxtAlter.TabIndex = 1;
    // 
    // GrpTyp
    // 
    GrpTyp.Controls.Add(RadBasis);
    GrpTyp.Controls.Add(RadStandard);
    GrpTyp.Controls.Add(RadPremium);
    GrpTyp.Location = new Point(14, 67);
    GrpTyp.Margin = new Padding(3, 4, 3, 4);
    GrpTyp.Name = "GrpTyp";
    GrpTyp.Padding = new Padding(3, 4, 3, 4);
    GrpTyp.Size = new Size(251, 127);
    GrpTyp.TabIndex = 2;
    GrpTyp.TabStop = false;
    GrpTyp.Text = "Versicherungstyp";
    // 
    // RadBasis
    // 
    RadBasis.AutoSize = true;
    RadBasis.Checked = true;
    RadBasis.Location = new Point(11, 27);
    RadBasis.Margin = new Padding(3, 4, 3, 4);
    RadBasis.Name = "RadBasis";
    RadBasis.Size = new Size(106, 24);
    RadBasis.TabIndex = 0;
    RadBasis.TabStop = true;
    RadBasis.Text = "Basis (×1.0)";
    // 
    // RadStandard
    // 
    RadStandard.AutoSize = true;
    RadStandard.Location = new Point(11, 60);
    RadStandard.Margin = new Padding(3, 4, 3, 4);
    RadStandard.Name = "RadStandard";
    RadStandard.Size = new Size(133, 24);
    RadStandard.TabIndex = 1;
    RadStandard.Text = "Standard (×1.4)";
    // 
    // RadPremium
    // 
    RadPremium.AutoSize = true;
    RadPremium.Location = new Point(11, 91);
    RadPremium.Margin = new Padding(3, 4, 3, 4);
    RadPremium.Name = "RadPremium";
    RadPremium.Size = new Size(132, 24);
    RadPremium.TabIndex = 2;
    RadPremium.Text = "Premium (×1.8)";
    // 
    // ChkUnfall
    // 
    ChkUnfall.AutoSize = true;
    ChkUnfall.Location = new Point(14, 207);
    ChkUnfall.Margin = new Padding(3, 4, 3, 4);
    ChkUnfall.Name = "ChkUnfall";
    ChkUnfall.Size = new Size(182, 24);
    ChkUnfall.TabIndex = 3;
    ChkUnfall.Text = "Unfallzusatz (+20 CHF)";
    // 
    // CmdBerechnen
    // 
    CmdBerechnen.Location = new Point(14, 247);
    CmdBerechnen.Margin = new Padding(3, 4, 3, 4);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(149, 37);
    CmdBerechnen.TabIndex = 4;
    CmdBerechnen.Text = "Berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(14, 300);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 20);
    LblErgebnis.TabIndex = 5;
    // 
    // VersicherungspraemieForm
    // 
    AutoScaleDimensions = new SizeF(8F, 20F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(434, 453);
    Controls.Add(LblAlter);
    Controls.Add(TxtAlter);
    Controls.Add(GrpTyp);
    Controls.Add(ChkUnfall);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Margin = new Padding(3, 4, 3, 4);
    Name = "VersicherungspraemieForm";
    Text = "Versicherungsprämie – Aufgabe 3";
    GrpTyp.ResumeLayout(false);
    GrpTyp.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblAlter;
  private TextBox TxtAlter;
  private GroupBox GrpTyp;
  private RadioButton RadBasis;
  private RadioButton RadStandard;
  private RadioButton RadPremium;
  private CheckBox ChkUnfall;
  private Button CmdBerechnen;
  private Label LblErgebnis;
}
