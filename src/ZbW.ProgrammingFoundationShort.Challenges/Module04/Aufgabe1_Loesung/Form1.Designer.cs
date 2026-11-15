namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe1_Loesung
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
      lblMontag = new Label();
      lblDienstag = new Label();
      lblMittwoch = new Label();
      lblDonnerstag = new Label();
      lblFreitag = new Label();
      lblSamstag = new Label();
      lblSonntag = new Label();
      txtDienstag = new TextBox();
      txtMittwoch = new TextBox();
      txtDonnerstag = new TextBox();
      txtFreitag = new TextBox();
      txtSamstag = new TextBox();
      txtSonntag = new TextBox();
      txtMontag = new TextBox();
      btnAuswerten = new Button();
      lblDurchschnitt = new Label();
      lblMaximum = new Label();
      lblMinimum = new Label();
      SuspendLayout();
      // 
      // lblMontag
      // 
      lblMontag.AutoSize = true;
      lblMontag.Location = new Point(46, 42);
      lblMontag.Name = "lblMontag";
      lblMontag.Size = new Size(49, 15);
      lblMontag.TabIndex = 0;
      lblMontag.Text = "Montag";
      // 
      // lblDienstag
      // 
      lblDienstag.AutoSize = true;
      lblDienstag.Location = new Point(46, 74);
      lblDienstag.Name = "lblDienstag";
      lblDienstag.Size = new Size(53, 15);
      lblDienstag.TabIndex = 1;
      lblDienstag.Text = "Dienstag";
      // 
      // lblMittwoch
      // 
      lblMittwoch.AutoSize = true;
      lblMittwoch.Location = new Point(46, 110);
      lblMittwoch.Name = "lblMittwoch";
      lblMittwoch.Size = new Size(58, 15);
      lblMittwoch.TabIndex = 2;
      lblMittwoch.Text = "Mittwoch";
      // 
      // lblDonnerstag
      // 
      lblDonnerstag.AutoSize = true;
      lblDonnerstag.Location = new Point(46, 146);
      lblDonnerstag.Name = "lblDonnerstag";
      lblDonnerstag.Size = new Size(68, 15);
      lblDonnerstag.TabIndex = 3;
      lblDonnerstag.Text = "Donnerstag";
      // 
      // lblFreitag
      // 
      lblFreitag.AutoSize = true;
      lblFreitag.Location = new Point(46, 184);
      lblFreitag.Name = "lblFreitag";
      lblFreitag.Size = new Size(43, 15);
      lblFreitag.TabIndex = 4;
      lblFreitag.Text = "Freitag";
      lblFreitag.Click += label5_Click;
      // 
      // lblSamstag
      // 
      lblSamstag.AutoSize = true;
      lblSamstag.Location = new Point(46, 218);
      lblSamstag.Name = "lblSamstag";
      lblSamstag.Size = new Size(52, 15);
      lblSamstag.TabIndex = 5;
      lblSamstag.Text = "Samstag";
      // 
      // lblSonntag
      // 
      lblSonntag.AutoSize = true;
      lblSonntag.Location = new Point(46, 251);
      lblSonntag.Name = "lblSonntag";
      lblSonntag.Size = new Size(51, 15);
      lblSonntag.TabIndex = 6;
      lblSonntag.Text = "Sonnatg";
      // 
      // txtDienstag
      // 
      txtDienstag.Location = new Point(186, 66);
      txtDienstag.Name = "txtDienstag";
      txtDienstag.Size = new Size(100, 23);
      txtDienstag.TabIndex = 7;
      // 
      // txtMittwoch
      // 
      txtMittwoch.Location = new Point(186, 102);
      txtMittwoch.Name = "txtMittwoch";
      txtMittwoch.Size = new Size(100, 23);
      txtMittwoch.TabIndex = 8;
      // 
      // txtDonnerstag
      // 
      txtDonnerstag.Location = new Point(186, 138);
      txtDonnerstag.Name = "txtDonnerstag";
      txtDonnerstag.Size = new Size(100, 23);
      txtDonnerstag.TabIndex = 9;
      // 
      // txtFreitag
      // 
      txtFreitag.Location = new Point(186, 181);
      txtFreitag.Name = "txtFreitag";
      txtFreitag.Size = new Size(100, 23);
      txtFreitag.TabIndex = 10;
      // 
      // txtSamstag
      // 
      txtSamstag.Location = new Point(186, 215);
      txtSamstag.Name = "txtSamstag";
      txtSamstag.Size = new Size(100, 23);
      txtSamstag.TabIndex = 11;
      // 
      // txtSonntag
      // 
      txtSonntag.Location = new Point(186, 248);
      txtSonntag.Name = "txtSonntag";
      txtSonntag.Size = new Size(100, 23);
      txtSonntag.TabIndex = 12;
      // 
      // txtMontag
      // 
      txtMontag.Location = new Point(186, 37);
      txtMontag.Name = "txtMontag";
      txtMontag.Size = new Size(100, 23);
      txtMontag.TabIndex = 13;
      // 
      // btnAuswerten
      // 
      btnAuswerten.Location = new Point(198, 277);
      btnAuswerten.Name = "btnAuswerten";
      btnAuswerten.Size = new Size(75, 23);
      btnAuswerten.TabIndex = 14;
      btnAuswerten.Text = "Auswerten";
      btnAuswerten.UseVisualStyleBackColor = true;
      btnAuswerten.Click += btnAuswerten_Click;
      // 
      // lblDurchschnitt
      // 
      lblDurchschnitt.AutoSize = true;
      lblDurchschnitt.Location = new Point(325, 91);
      lblDurchschnitt.Name = "lblDurchschnitt";
      lblDurchschnitt.Size = new Size(86, 15);
      lblDurchschnitt.TabIndex = 15;
      lblDurchschnitt.Text = "Durchschnitt: -";
      // 
      // lblMaximum
      // 
      lblMaximum.AutoSize = true;
      lblMaximum.Location = new Point(310, 138);
      lblMaximum.Name = "lblMaximum";
      lblMaximum.Size = new Size(126, 15);
      lblMaximum.TabIndex = 16;
      lblMaximum.Text = "Höchste Temperatur: -";
      // 
      // lblMinimum
      // 
      lblMinimum.AutoSize = true;
      lblMinimum.Location = new Point(310, 189);
      lblMinimum.Name = "lblMinimum";
      lblMinimum.Size = new Size(117, 15);
      lblMinimum.TabIndex = 17;
      lblMinimum.Text = "Tiefste Temperatur: -";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(448, 384);
      Controls.Add(lblMinimum);
      Controls.Add(lblMaximum);
      Controls.Add(lblDurchschnitt);
      Controls.Add(btnAuswerten);
      Controls.Add(txtMontag);
      Controls.Add(txtSonntag);
      Controls.Add(txtSamstag);
      Controls.Add(txtFreitag);
      Controls.Add(txtDonnerstag);
      Controls.Add(txtMittwoch);
      Controls.Add(txtDienstag);
      Controls.Add(lblSonntag);
      Controls.Add(lblSamstag);
      Controls.Add(lblFreitag);
      Controls.Add(lblDonnerstag);
      Controls.Add(lblMittwoch);
      Controls.Add(lblDienstag);
      Controls.Add(lblMontag);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblMontag;
    private Label lblDienstag;
    private Label lblMittwoch;
    private Label lblDonnerstag;
    private Label lblFreitag;
    private Label lblSamstag;
    private Label lblSonntag;
    private TextBox txtDienstag;
    private TextBox txtMittwoch;
    private TextBox txtDonnerstag;
    private TextBox txtFreitag;
    private TextBox txtSamstag;
    private TextBox txtSonntag;
    private TextBox txtMontag;
    private Button btnAuswerten;
    private Label lblDurchschnitt;
    private Label lblMaximum;
    private Label lblMinimum;
  }
}