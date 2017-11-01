namespace Eu4ModEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MinButton = new Eu4ModEditor.ControlComponent.ButtonZ();
            this.MaxButton = new Eu4ModEditor.ControlComponent.MinMaxButton();
            this.CloseButton = new Eu4ModEditor.ControlComponent.ButtonZ();
            this.IconPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripZ1 = new Eu4ModEditor.ControlComponent.MenuStripZ();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalSplit = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SolutionView = new Eu4ModEditor.EditorComponent.SolutionTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SolutionHeaderPanel = new System.Windows.Forms.Panel();
            this.SolutionLabel = new System.Windows.Forms.Label();
            this.TextTab = new Eu4ModEditor.ControlComponent.VisualStudioTabControl();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopPanel.SuspendLayout();
            this.menuStripZ1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalSplit)).BeginInit();
            this.PrincipalSplit.Panel1.SuspendLayout();
            this.PrincipalSplit.Panel2.SuspendLayout();
            this.PrincipalSplit.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SolutionHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))), System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))));
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.MinButton);
            this.TopPanel.Controls.Add(this.MaxButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.IconPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1094, 30);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // MinButton
            // 
            this.MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinButton.BackColor = System.Drawing.Color.Transparent;
            this.MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MinButton.DisplayText = "_";
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.MinButton.ForeColor = System.Drawing.Color.White;
            this.MinButton.Location = new System.Drawing.Point(993, 3);
            this.MinButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MinButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(31, 24);
            this.MinButton.TabIndex = 10;
            this.MinButton.Text = "_";
            this.MinButton.TextLocation_X = 6;
            this.MinButton.TextLocation_Y = -12;
            this.toolTip1.SetToolTip(this.MinButton, "Minimize");
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxButton.BackColor = System.Drawing.Color.Transparent;
            this.MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MaxButton.CFormState = Eu4ModEditor.ControlComponent.MinMaxButton.CustomFormState.Normal;
            this.MaxButton.DisplayText = "_";
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.ForeColor = System.Drawing.Color.White;
            this.MaxButton.Location = new System.Drawing.Point(1026, 1);
            this.MaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(31, 24);
            this.MaxButton.TabIndex = 9;
            this.MaxButton.Text = "minMaxButton1";
            this.MaxButton.TextLocation_X = 8;
            this.MaxButton.TextLocation_Y = 7;
            this.toolTip1.SetToolTip(this.MaxButton, "Maximize");
            this.MaxButton.UseVisualStyleBackColor = false;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CloseButton.DisplayText = "X";
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1060, 2);
            this.CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(31, 24);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.TextLocation_X = 6;
            this.CloseButton.TextLocation_Y = -1;
            this.toolTip1.SetToolTip(this.CloseButton, "Close");
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // IconPanel
            // 
            this.IconPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconPanel.BackgroundImage")));
            this.IconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IconPanel.Location = new System.Drawing.Point(3, 2);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(29, 25);
            this.IconPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TitleLabel.Location = new System.Drawing.Point(48, 7);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(231, 17);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Europa Universalis IV Modding Studio";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.TitleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // menuStripZ1
            // 
            this.menuStripZ1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStripZ1.Location = new System.Drawing.Point(0, 30);
            this.menuStripZ1.Name = "menuStripZ1";
            this.menuStripZ1.Size = new System.Drawing.Size(1094, 24);
            this.menuStripZ1.TabIndex = 2;
            this.menuStripZ1.Text = "menuStripZ1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.nouveauToolStripMenuItem,
            this.enregistrerToolStripMenuItem});
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ouvrirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // PrincipalSplit
            // 
            this.PrincipalSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrincipalSplit.Location = new System.Drawing.Point(0, 54);
            this.PrincipalSplit.Name = "PrincipalSplit";
            // 
            // PrincipalSplit.Panel1
            // 
            this.PrincipalSplit.Panel1.Controls.Add(this.panel3);
            // 
            // PrincipalSplit.Panel2
            // 
            this.PrincipalSplit.Panel2.Controls.Add(this.TextTab);
            this.PrincipalSplit.Size = new System.Drawing.Size(1094, 537);
            this.PrincipalSplit.SplitterDistance = 350;
            this.PrincipalSplit.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SolutionView);
            this.panel3.Controls.Add(this.SolutionHeaderPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 537);
            this.panel3.TabIndex = 1;
            // 
            // SolutionView
            // 
            this.SolutionView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.SolutionView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolutionView.ForeColor = System.Drawing.SystemColors.Control;
            this.SolutionView.ImageIndex = 0;
            this.SolutionView.ImageList = this.imageList1;
            this.SolutionView.Location = new System.Drawing.Point(0, 25);
            this.SolutionView.Name = "SolutionView";
            this.SolutionView.SelectedImageIndex = 0;
            this.SolutionView.Size = new System.Drawing.Size(350, 512);
            this.SolutionView.TabIndex = 0;
            this.SolutionView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SolutionView_NodeMouseClick);
            this.SolutionView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SolutionView_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Eu4Logo");
            this.imageList1.Images.SetKeyName(1, "folder");
            this.imageList1.Images.SetKeyName(2, "Pays");
            // 
            // SolutionHeaderPanel
            // 
            this.SolutionHeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionHeaderPanel.Controls.Add(this.SolutionLabel);
            this.SolutionHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SolutionHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.SolutionHeaderPanel.Name = "SolutionHeaderPanel";
            this.SolutionHeaderPanel.Size = new System.Drawing.Size(350, 25);
            this.SolutionHeaderPanel.TabIndex = 2;
            // 
            // SolutionLabel
            // 
            this.SolutionLabel.AutoSize = true;
            this.SolutionLabel.BackColor = System.Drawing.Color.Transparent;
            this.SolutionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SolutionLabel.Location = new System.Drawing.Point(3, 6);
            this.SolutionLabel.Name = "SolutionLabel";
            this.SolutionLabel.Size = new System.Drawing.Size(114, 13);
            this.SolutionLabel.TabIndex = 1;
            this.SolutionLabel.Text = "Explorateur de solution";
            // 
            // TextTab
            // 
            this.TextTab.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TextTab.AllowDrop = true;
            this.TextTab.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TextTab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextTab.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.TextTab.ClosingMessage = null;
            this.TextTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTab.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TextTab.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TextTab.ItemSize = new System.Drawing.Size(240, 16);
            this.TextTab.Location = new System.Drawing.Point(0, 0);
            this.TextTab.Name = "TextTab";
            this.TextTab.SelectedIndex = 0;
            this.TextTab.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextTab.ShowClosingButton = true;
            this.TextTab.ShowClosingMessage = false;
            this.TextTab.Size = new System.Drawing.Size(740, 537);
            this.TextTab.TabIndex = 0;
            this.TextTab.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1094, 591);
            this.Controls.Add(this.PrincipalSplit);
            this.Controls.Add(this.menuStripZ1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.TopPanel.ResumeLayout(false);
            this.menuStripZ1.ResumeLayout(false);
            this.menuStripZ1.PerformLayout();
            this.PrincipalSplit.Panel1.ResumeLayout(false);
            this.PrincipalSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalSplit)).EndInit();
            this.PrincipalSplit.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.SolutionHeaderPanel.ResumeLayout(false);
            this.SolutionHeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel IconPanel;
        private System.Windows.Forms.Label TitleLabel;
        private ControlComponent.ButtonZ CloseButton;
        private ControlComponent.MinMaxButton MaxButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private ControlComponent.ButtonZ MinButton;
        private ControlComponent.MenuStripZ menuStripZ1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.SplitContainer PrincipalSplit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SolutionHeaderPanel;
        private System.Windows.Forms.Label SolutionLabel;
        private EditorComponent.SolutionTreeView SolutionView;
        private ControlComponent.VisualStudioTabControl TextTab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
    }
}

