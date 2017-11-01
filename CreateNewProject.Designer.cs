namespace Eu4ModEditor
{
    partial class CreateNewProject
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ProjectEmplacementLabel = new System.Windows.Forms.Label();
            this.ProjectEmplacementBox = new System.Windows.Forms.TextBox();
            this.ModEmplacementLabel = new System.Windows.Forms.Label();
            this.ModEmplacementBox = new System.Windows.Forms.TextBox();
            this.ParcourirProjectButton = new System.Windows.Forms.Button();
            this.ParcourirModButton = new System.Windows.Forms.Button();
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
            this.TopPanel.Size = new System.Drawing.Size(336, 30);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateNewProject_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateNewProject_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreateNewProject_MouseUp);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(3, 10);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(81, 13);
            this.TopLabel.TabIndex = 10;
            this.TopLabel.Text = "Nouveau Projet";
            this.TopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateNewProject_MouseDown);
            this.TopLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateNewProject_MouseMove);
            this.TopLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreateNewProject_MouseUp);
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
            this.CloseButton.Location = new System.Drawing.Point(302, 2);
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
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(104, 57);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Nom";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(139, 55);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 4;
            // 
            // ProjectEmplacementLabel
            // 
            this.ProjectEmplacementLabel.AutoSize = true;
            this.ProjectEmplacementLabel.Location = new System.Drawing.Point(17, 83);
            this.ProjectEmplacementLabel.Name = "ProjectEmplacementLabel";
            this.ProjectEmplacementLabel.Size = new System.Drawing.Size(116, 13);
            this.ProjectEmplacementLabel.TabIndex = 5;
            this.ProjectEmplacementLabel.Text = "Emplacement du Projet";
            // 
            // ProjectEmplacementBox
            // 
            this.ProjectEmplacementBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ProjectEmplacementBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProjectEmplacementBox.ForeColor = System.Drawing.Color.White;
            this.ProjectEmplacementBox.Location = new System.Drawing.Point(139, 81);
            this.ProjectEmplacementBox.Name = "ProjectEmplacementBox";
            this.ProjectEmplacementBox.ReadOnly = true;
            this.ProjectEmplacementBox.Size = new System.Drawing.Size(100, 20);
            this.ProjectEmplacementBox.TabIndex = 6;
            // 
            // ModEmplacementLabel
            // 
            this.ModEmplacementLabel.AutoSize = true;
            this.ModEmplacementLabel.Location = new System.Drawing.Point(23, 109);
            this.ModEmplacementLabel.Name = "ModEmplacementLabel";
            this.ModEmplacementLabel.Size = new System.Drawing.Size(110, 13);
            this.ModEmplacementLabel.TabIndex = 7;
            this.ModEmplacementLabel.Text = "Emplacement du Mod";
            // 
            // ModEmplacementBox
            // 
            this.ModEmplacementBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ModEmplacementBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModEmplacementBox.ForeColor = System.Drawing.Color.White;
            this.ModEmplacementBox.Location = new System.Drawing.Point(139, 107);
            this.ModEmplacementBox.Name = "ModEmplacementBox";
            this.ModEmplacementBox.ReadOnly = true;
            this.ModEmplacementBox.Size = new System.Drawing.Size(100, 20);
            this.ModEmplacementBox.TabIndex = 8;
            // 
            // ParcourirProjectButton
            // 
            this.ParcourirProjectButton.BackColor = System.Drawing.SystemColors.Control;
            this.ParcourirProjectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ParcourirProjectButton.Location = new System.Drawing.Point(245, 78);
            this.ParcourirProjectButton.Name = "ParcourirProjectButton";
            this.ParcourirProjectButton.Size = new System.Drawing.Size(75, 23);
            this.ParcourirProjectButton.TabIndex = 9;
            this.ParcourirProjectButton.Text = "Parcourir";
            this.ParcourirProjectButton.UseVisualStyleBackColor = false;
            this.ParcourirProjectButton.Click += new System.EventHandler(this.ParcourirProjectButton_Click);
            // 
            // ParcourirModButton
            // 
            this.ParcourirModButton.BackColor = System.Drawing.SystemColors.Control;
            this.ParcourirModButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ParcourirModButton.Location = new System.Drawing.Point(245, 104);
            this.ParcourirModButton.Name = "ParcourirModButton";
            this.ParcourirModButton.Size = new System.Drawing.Size(75, 23);
            this.ParcourirModButton.TabIndex = 10;
            this.ParcourirModButton.Text = "Parcourir";
            this.ParcourirModButton.UseVisualStyleBackColor = false;
            this.ParcourirModButton.Click += new System.EventHandler(this.ParcourirModButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.Control;
            this.OKButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OKButton.Location = new System.Drawing.Point(90, 144);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.BackColor = System.Drawing.SystemColors.Control;
            this.AnnulerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AnnulerButton.Location = new System.Drawing.Point(171, 144);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(75, 23);
            this.AnnulerButton.TabIndex = 12;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = false;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // CreateNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(336, 179);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ParcourirModButton);
            this.Controls.Add(this.ParcourirProjectButton);
            this.Controls.Add(this.ModEmplacementBox);
            this.Controls.Add(this.ModEmplacementLabel);
            this.Controls.Add(this.ProjectEmplacementBox);
            this.Controls.Add(this.ProjectEmplacementLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNewProject";
            this.Text = "Nouveau Projet";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private ControlComponent.ButtonZ CloseButton;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label ProjectEmplacementLabel;
        private System.Windows.Forms.TextBox ProjectEmplacementBox;
        private System.Windows.Forms.Label ModEmplacementLabel;
        private System.Windows.Forms.TextBox ModEmplacementBox;
        private System.Windows.Forms.Button ParcourirProjectButton;
        private System.Windows.Forms.Button ParcourirModButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button AnnulerButton;
    }
}