namespace Eu4ModEditor
{
    partial class AddExistFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExistFile));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.FilesViewPanel = new System.Windows.Forms.Panel();
            this.FilesList = new Eu4ModEditor.ControlComponent.GListBox();
            this.FiltrePanel = new System.Windows.Forms.Panel();
            this.FileTypeTree = new System.Windows.Forms.TreeView();
            this.VidePanel = new System.Windows.Forms.Panel();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Annuler = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLabel = new System.Windows.Forms.Label();
            this.CloseButton = new Eu4ModEditor.ControlComponent.ButtonZ();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeLabelText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.MiddlePanel.SuspendLayout();
            this.FilesViewPanel.SuspendLayout();
            this.FiltrePanel.SuspendLayout();
            this.VidePanel.SuspendLayout();
            this.DescriptionPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.MiddlePanel);
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(940, 580);
            this.MainPanel.TabIndex = 0;
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
            this.FilesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilesList.ForeColor = System.Drawing.Color.White;
            this.FilesList.FormattingEnabled = true;
            this.FilesList.ItemHeight = 36;
            this.FilesList.Location = new System.Drawing.Point(0, 0);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(473, 448);
            this.FilesList.TabIndex = 0;
            this.FilesList.SelectedIndexChanged += new System.EventHandler(this.FilesList_SelectedIndexChanged);
            // 
            // FiltrePanel
            // 
            this.FiltrePanel.Controls.Add(this.FileTypeTree);
            this.FiltrePanel.Controls.Add(this.VidePanel);
            this.FiltrePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FiltrePanel.Location = new System.Drawing.Point(0, 0);
            this.FiltrePanel.Name = "FiltrePanel";
            this.FiltrePanel.Size = new System.Drawing.Size(215, 448);
            this.FiltrePanel.TabIndex = 1;
            // 
            // FileTypeTree
            // 
            this.FileTypeTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.FileTypeTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileTypeTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTypeTree.ForeColor = System.Drawing.Color.White;
            this.FileTypeTree.Location = new System.Drawing.Point(0, 14);
            this.FileTypeTree.Name = "FileTypeTree";
            this.FileTypeTree.Size = new System.Drawing.Size(215, 434);
            this.FileTypeTree.TabIndex = 0;
            this.FileTypeTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.FileTypeTree_NodeMouseClick);
            // 
            // VidePanel
            // 
            this.VidePanel.Controls.Add(this.panel1);
            this.VidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VidePanel.Location = new System.Drawing.Point(0, 0);
            this.VidePanel.Name = "VidePanel";
            this.VidePanel.Size = new System.Drawing.Size(215, 14);
            this.VidePanel.TabIndex = 2;
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.Controls.Add(this.TypeLabelText);
            this.DescriptionPanel.Controls.Add(this.TypeLabel);
            this.DescriptionPanel.Controls.Add(this.DescriptionBox);
            this.DescriptionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DescriptionPanel.Location = new System.Drawing.Point(688, 0);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(250, 448);
            this.DescriptionPanel.TabIndex = 0;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DescriptionBox.ForeColor = System.Drawing.Color.White;
            this.DescriptionBox.Location = new System.Drawing.Point(7, 32);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(233, 56);
            this.DescriptionBox.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.Annuler);
            this.BottomPanel.Controls.Add(this.Ajouter);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 478);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(938, 100);
            this.BottomPanel.TabIndex = 3;
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.SystemColors.Control;
            this.Annuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Annuler.Location = new System.Drawing.Point(857, 66);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(75, 23);
            this.Annuler.TabIndex = 1;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.SystemColors.Control;
            this.Ajouter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ajouter.Location = new System.Drawing.Point(776, 66);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
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
            this.TopLabel.Size = new System.Drawing.Size(135, 13);
            this.TopLabel.TabIndex = 10;
            this.TopLabel.Text = "Ajout d\'un Element Existant";
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
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(14, 14);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(43, 13);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Type :";
            // 
            // TypeLabelText
            // 
            this.TypeLabelText.AutoSize = true;
            this.TypeLabelText.Location = new System.Drawing.Point(63, 15);
            this.TypeLabelText.Name = "TypeLabelText";
            this.TypeLabelText.Size = new System.Drawing.Size(0, 13);
            this.TypeLabelText.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 14);
            this.panel1.TabIndex = 3;
            // 
            // AddExistFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(940, 580);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExistFile";
            this.Text = "CreateNewFile";
            this.MainPanel.ResumeLayout(false);
            this.MiddlePanel.ResumeLayout(false);
            this.FilesViewPanel.ResumeLayout(false);
            this.FiltrePanel.ResumeLayout(false);
            this.VidePanel.ResumeLayout(false);
            this.DescriptionPanel.ResumeLayout(false);
            this.DescriptionPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
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
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TreeView FileTypeTree;
        private System.Windows.Forms.Panel VidePanel;
        private System.Windows.Forms.Label TypeLabelText;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Panel panel1;
    }
}