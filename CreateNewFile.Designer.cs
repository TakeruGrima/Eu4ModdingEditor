namespace Eu4ModEditor
{
    partial class CreateNewFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewFile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.FilesViewPanel = new System.Windows.Forms.Panel();
            this.FilesList = new Eu4ModEditor.ControlComponent.GListBox();
            this.FiltrePanel = new System.Windows.Forms.Panel();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLabel = new System.Windows.Forms.Label();
            this.CloseButton = new Eu4ModEditor.ControlComponent.ButtonZ();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.MiddlePanel.SuspendLayout();
            this.FilesViewPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MiddlePanel);
            this.panel1.Controls.Add(this.BottomPanel);
            this.panel1.Controls.Add(this.TopPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 580);
            this.panel1.TabIndex = 0;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.Controls.Add(this.FilesViewPanel);
            this.MiddlePanel.Controls.Add(this.FiltrePanel);
            this.MiddlePanel.Controls.Add(this.DescriptionPanel);
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddlePanel.Location = new System.Drawing.Point(0, 30);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(938, 448);
            this.MiddlePanel.TabIndex = 5;
            // 
            // FilesViewPanel
            // 
            this.FilesViewPanel.Controls.Add(this.FilesList);
            this.FilesViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesViewPanel.Location = new System.Drawing.Point(215, 0);
            this.FilesViewPanel.Name = "FilesViewPanel";
            this.FilesViewPanel.Size = new System.Drawing.Size(473, 448);
            this.FilesViewPanel.TabIndex = 2;
            // 
            // FilesList
            // 
            this.FilesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.FilesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilesList.ForeColor = System.Drawing.Color.White;
            this.FilesList.FormattingEnabled = true;
            this.FilesList.ItemHeight = 36;
            this.FilesList.Location = new System.Drawing.Point(0, 0);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(473, 448);
            this.FilesList.TabIndex = 0;
            // 
            // FiltrePanel
            // 
            this.FiltrePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FiltrePanel.Location = new System.Drawing.Point(0, 0);
            this.FiltrePanel.Name = "FiltrePanel";
            this.FiltrePanel.Size = new System.Drawing.Size(215, 448);
            this.FiltrePanel.TabIndex = 1;
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DescriptionPanel.Location = new System.Drawing.Point(688, 0);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(250, 448);
            this.DescriptionPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 478);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(938, 100);
            this.BottomPanel.TabIndex = 3;
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
            this.TopPanel.Size = new System.Drawing.Size(938, 30);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateNewFile_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateNewFile_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreateNewFile_MouseUp);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(11, 8);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(130, 13);
            this.TopLabel.TabIndex = 10;
            this.TopLabel.Text = "Ajout d\'un nouvel Element";
            this.TopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateNewFile_MouseDown);
            this.TopLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateNewFile_MouseMove);
            this.TopLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreateNewFile_MouseUp);
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
            this.CloseButton.Location = new System.Drawing.Point(904, 2);
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Pays");
            this.imageList1.Images.SetKeyName(1, "Event");
            this.imageList1.Images.SetKeyName(2, "Decision");
            this.imageList1.Images.SetKeyName(3, "Mission");
            // 
            // CreateNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(940, 580);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNewFile";
            this.Text = "CreateNewFile";
            this.panel1.ResumeLayout(false);
            this.MiddlePanel.ResumeLayout(false);
            this.FilesViewPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TopPanel;
        private ControlComponent.ButtonZ CloseButton;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.Panel FilesViewPanel;
        private ControlComponent.GListBox FilesList;
        private System.Windows.Forms.Panel FiltrePanel;
        private System.Windows.Forms.Panel DescriptionPanel;
    }
}