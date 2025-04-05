namespace FakturaAlex
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            avsluttToolStripMenuItem = new ToolStripMenuItem();
            kunderToolStripMenuItem = new ToolStripMenuItem();
            opprettNyKundeToolStripMenuItem = new ToolStripMenuItem();
            visAlleKunderToolStripMenuItem = new ToolStripMenuItem();
            fakturaToolStripMenuItem = new ToolStripMenuItem();
            opprettNyFakturaToolStripMenuItem = new ToolStripMenuItem();
            visAlleFakturaerToolStripMenuItem = new ToolStripMenuItem();
            hjelpToolStripMenuItem = new ToolStripMenuItem();
            omFakturaAlexToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, kunderToolStripMenuItem, fakturaToolStripMenuItem, hjelpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1892, 46);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { avsluttToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(58, 38);
            fileToolStripMenuItem.Text = "&Fil";
            // 
            // avsluttToolStripMenuItem
            // 
            avsluttToolStripMenuItem.Name = "avsluttToolStripMenuItem";
            avsluttToolStripMenuItem.Size = new Size(220, 44);
            avsluttToolStripMenuItem.Text = "&Avslutt";
            avsluttToolStripMenuItem.Click += avsluttToolStripMenuItem_Click;
            // 
            // kunderToolStripMenuItem
            // 
            kunderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opprettNyKundeToolStripMenuItem, visAlleKunderToolStripMenuItem });
            kunderToolStripMenuItem.Name = "kunderToolStripMenuItem";
            kunderToolStripMenuItem.Size = new Size(111, 38);
            kunderToolStripMenuItem.Text = "&Kunder";
            // 
            // opprettNyKundeToolStripMenuItem
            // 
            opprettNyKundeToolStripMenuItem.Name = "opprettNyKundeToolStripMenuItem";
            opprettNyKundeToolStripMenuItem.Size = new Size(359, 44);
            opprettNyKundeToolStripMenuItem.Text = "&Opprett ny kunde";
            opprettNyKundeToolStripMenuItem.Click += opprettNyKundeToolStripMenuItem_Click;
            // 
            // visAlleKunderToolStripMenuItem
            // 
            visAlleKunderToolStripMenuItem.Name = "visAlleKunderToolStripMenuItem";
            visAlleKunderToolStripMenuItem.Size = new Size(359, 44);
            visAlleKunderToolStripMenuItem.Text = "&Vis alle kunder";
            visAlleKunderToolStripMenuItem.Click += visAlleKunderToolStripMenuItem_Click;
            // 
            // fakturaToolStripMenuItem
            // 
            fakturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opprettNyFakturaToolStripMenuItem, visAlleFakturaerToolStripMenuItem });
            fakturaToolStripMenuItem.Name = "fakturaToolStripMenuItem";
            fakturaToolStripMenuItem.Size = new Size(111, 38);
            fakturaToolStripMenuItem.Text = "&Faktura";
            // 
            // opprettNyFakturaToolStripMenuItem
            // 
            opprettNyFakturaToolStripMenuItem.Name = "opprettNyFakturaToolStripMenuItem";
            opprettNyFakturaToolStripMenuItem.Size = new Size(344, 44);
            opprettNyFakturaToolStripMenuItem.Text = "&Opprett ny faktura";
            // 
            // visAlleFakturaerToolStripMenuItem
            // 
            visAlleFakturaerToolStripMenuItem.Name = "visAlleFakturaerToolStripMenuItem";
            visAlleFakturaerToolStripMenuItem.Size = new Size(344, 44);
            visAlleFakturaerToolStripMenuItem.Text = "&Vis alle fakturaer";
            // 
            // hjelpToolStripMenuItem
            // 
            hjelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { omFakturaAlexToolStripMenuItem });
            hjelpToolStripMenuItem.Name = "hjelpToolStripMenuItem";
            hjelpToolStripMenuItem.Size = new Size(90, 38);
            hjelpToolStripMenuItem.Text = "&Hjelp";
            // 
            // omFakturaAlexToolStripMenuItem
            // 
            omFakturaAlexToolStripMenuItem.Name = "omFakturaAlexToolStripMenuItem";
            omFakturaAlexToolStripMenuItem.Size = new Size(315, 44);
            omFakturaAlexToolStripMenuItem.Text = "&Om FakturaAlex";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 46);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 4, 0);
            toolStrip1.Size = new Size(1892, 42);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(46, 36);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1892, 1156);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 6, 6, 6);
            Name = "mainForm";
            Text = "FakturaAlex";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem kunderToolStripMenuItem;
        private ToolStripMenuItem fakturaToolStripMenuItem;
        private ToolStripMenuItem avsluttToolStripMenuItem;
        private ToolStripMenuItem opprettNyKundeToolStripMenuItem;
        private ToolStripMenuItem visAlleKunderToolStripMenuItem;
        private ToolStripMenuItem opprettNyFakturaToolStripMenuItem;
        private ToolStripMenuItem visAlleFakturaerToolStripMenuItem;
        private ToolStripMenuItem hjelpToolStripMenuItem;
        private ToolStripMenuItem omFakturaAlexToolStripMenuItem;
    }
}
