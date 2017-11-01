namespace Eu4ModEditor.EditorFilesSetting
{
    partial class CountrySettings
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLabel = new System.Windows.Forms.Label();
            this.CloseButton = new Eu4ModEditor.ControlComponent.ButtonZ();
            this.CountryFileLabel = new System.Windows.Forms.Label();
            this.CountryTagsLabel = new System.Windows.Forms.Label();
            this.LocalisationFileLabel = new System.Windows.Forms.Label();
            this.CountryFileBox = new System.Windows.Forms.TextBox();
            this.CountryTagsBox = new System.Windows.Forms.TextBox();
            this.LocalisationBox = new System.Windows.Forms.TextBox();
            this.ParcourirCountryButton = new System.Windows.Forms.Button();
            this.ParcourirTagButton = new System.Windows.Forms.Button();
            this.ParcourirLocalisationButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Controls.Add(this.TopLabel);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(303, 30);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CountrySettings_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CountrySettings_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CountrySettings_MouseUp);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(11, 8);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(81, 13);
            this.TopLabel.TabIndex = 10;
            this.TopLabel.Text = "Ajouter un Pays";
            this.TopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CountrySettings_MouseDown);
            this.TopLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CountrySettings_MouseMove);
            this.TopLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CountrySettings_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.BZBackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.DisplayText = "X";
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(269, 2);
            this.CloseButton.MouseClickColor1 = System.Drawing.Color.Red;
            this.CloseButton.MouseHoverColor = System.Drawing.Color.Red;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(31, 24);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.TextLocation_X = 6;
            this.CloseButton.TextLocation_Y = -1;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CountryFileLabel
            // 
            this.CountryFileLabel.AutoSize = true;
            this.CountryFileLabel.Location = new System.Drawing.Point(43, 46);
            this.CountryFileLabel.Name = "CountryFileLabel";
            this.CountryFileLabel.Size = new System.Drawing.Size(59, 13);
            this.CountryFileLabel.TabIndex = 3;
            this.CountryFileLabel.Text = "CountryFile";
            // 
            // CountryTagsLabel
            // 
            this.CountryTagsLabel.AutoSize = true;
            this.CountryTagsLabel.Location = new System.Drawing.Point(13, 78);
            this.CountryTagsLabel.Name = "CountryTagsLabel";
            this.CountryTagsLabel.Size = new System.Drawing.Size(89, 13);
            this.CountryTagsLabel.TabIndex = 4;
            this.CountryTagsLabel.Text = "Country Tags File";
            // 
            // LocalisationFileLabel
            // 
            this.LocalisationFileLabel.AutoSize = true;
            this.LocalisationFileLabel.Location = new System.Drawing.Point(20, 106);
            this.LocalisationFileLabel.Name = "LocalisationFileLabel";
            this.LocalisationFileLabel.Size = new System.Drawing.Size(82, 13);
            this.LocalisationFileLabel.TabIndex = 6;
            this.LocalisationFileLabel.Text = "Localisation File";
            // 
            // CountryFileBox
            // 
            this.CountryFileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CountryFileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountryFileBox.ForeColor = System.Drawing.Color.White;
            this.CountryFileBox.Location = new System.Drawing.Point(108, 43);
            this.CountryFileBox.Name = "CountryFileBox";
            this.CountryFileBox.ReadOnly = true;
            this.CountryFileBox.Size = new System.Drawing.Size(100, 20);
            this.CountryFileBox.TabIndex = 7;
            // 
            // CountryTagsBox
            // 
            this.CountryTagsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CountryTagsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountryTagsBox.ForeColor = System.Drawing.Color.White;
            this.CountryTagsBox.Location = new System.Drawing.Point(108, 75);
            this.CountryTagsBox.Name = "CountryTagsBox";
            this.CountryTagsBox.ReadOnly = true;
            this.CountryTagsBox.Size = new System.Drawing.Size(100, 20);
            this.CountryTagsBox.TabIndex = 8;
            // 
            // LocalisationBox
            // 
            this.LocalisationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LocalisationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalisationBox.ForeColor = System.Drawing.Color.White;
            this.LocalisationBox.Location = new System.Drawing.Point(108, 103);
            this.LocalisationBox.Name = "LocalisationBox";
            this.LocalisationBox.ReadOnly = true;
            this.LocalisationBox.Size = new System.Drawing.Size(100, 20);
            this.LocalisationBox.TabIndex = 9;
            this.LocalisationBox.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.LocalisationBox.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // ParcourirCountryButton
            // 
            this.ParcourirCountryButton.BackColor = System.Drawing.SystemColors.Control;
            this.ParcourirCountryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ParcourirCountryButton.Location = new System.Drawing.Point(215, 43);
            this.ParcourirCountryButton.Name = "ParcourirCountryButton";
            this.ParcourirCountryButton.Size = new System.Drawing.Size(75, 23);
            this.ParcourirCountryButton.TabIndex = 10;
            this.ParcourirCountryButton.Text = "Parcourir";
            this.ParcourirCountryButton.UseVisualStyleBackColor = false;
            this.ParcourirCountryButton.Click += new System.EventHandler(this.ParcourirCountryButton_Click);
            // 
            // ParcourirTagButton
            // 
            this.ParcourirTagButton.BackColor = System.Drawing.SystemColors.Control;
            this.ParcourirTagButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ParcourirTagButton.Location = new System.Drawing.Point(215, 73);
            this.ParcourirTagButton.Name = "ParcourirTagButton";
            this.ParcourirTagButton.Size = new System.Drawing.Size(75, 23);
            this.ParcourirTagButton.TabIndex = 11;
            this.ParcourirTagButton.Text = "Parcourir";
            this.ParcourirTagButton.UseVisualStyleBackColor = false;
            this.ParcourirTagButton.Click += new System.EventHandler(this.ParcourirTagButton_Click);
            // 
            // ParcourirLocalisationButton
            // 
            this.ParcourirLocalisationButton.BackColor = System.Drawing.SystemColors.Control;
            this.ParcourirLocalisationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ParcourirLocalisationButton.Location = new System.Drawing.Point(215, 100);
            this.ParcourirLocalisationButton.Name = "ParcourirLocalisationButton";
            this.ParcourirLocalisationButton.Size = new System.Drawing.Size(75, 23);
            this.ParcourirLocalisationButton.TabIndex = 12;
            this.ParcourirLocalisationButton.Text = "Parcourir";
            this.ParcourirLocalisationButton.UseVisualStyleBackColor = false;
            this.ParcourirLocalisationButton.Click += new System.EventHandler(this.ParcourirLocalisationButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.Control;
            this.OKButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OKButton.Location = new System.Drawing.Point(73, 151);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.BackColor = System.Drawing.SystemColors.Control;
            this.AnnulerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AnnulerButton.Location = new System.Drawing.Point(154, 151);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(75, 23);
            this.AnnulerButton.TabIndex = 14;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = false;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // CountrySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(303, 186);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ParcourirLocalisationButton);
            this.Controls.Add(this.ParcourirTagButton);
            this.Controls.Add(this.ParcourirCountryButton);
            this.Controls.Add(this.LocalisationBox);
            this.Controls.Add(this.CountryTagsBox);
            this.Controls.Add(this.CountryFileBox);
            this.Controls.Add(this.LocalisationFileLabel);
            this.Controls.Add(this.CountryTagsLabel);
            this.Controls.Add(this.CountryFileLabel);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CountrySettings";
            this.ShowInTaskbar = false;
            this.Text = "CountrySettings";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TopLabel;
        private ControlComponent.ButtonZ CloseButton;
        private System.Windows.Forms.Label CountryFileLabel;
        private System.Windows.Forms.Label CountryTagsLabel;
        private System.Windows.Forms.Label LocalisationFileLabel;
        private System.Windows.Forms.TextBox CountryFileBox;
        private System.Windows.Forms.TextBox CountryTagsBox;
        private System.Windows.Forms.TextBox LocalisationBox;
        private System.Windows.Forms.Button ParcourirCountryButton;
        private System.Windows.Forms.Button ParcourirTagButton;
        private System.Windows.Forms.Button ParcourirLocalisationButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button AnnulerButton;
    }
}