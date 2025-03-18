namespace TN01___WFCadastroContato
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            msnMenu = new MenuStrip();
            mnsCadastrar = new ToolStripMenuItem();
            mnsSobre = new ToolStripMenuItem();
            mnsListagem = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            msnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // msnMenu
            // 
            msnMenu.Items.AddRange(new ToolStripItem[] { mnsCadastrar, mnsSobre, mnsListagem, mnsSair });
            msnMenu.Location = new Point(0, 0);
            msnMenu.Name = "msnMenu";
            msnMenu.Size = new Size(422, 24);
            msnMenu.TabIndex = 0;
            msnMenu.Text = "menuStrip1";
            // 
            // mnsCadastrar
            // 
            mnsCadastrar.Name = "mnsCadastrar";
            mnsCadastrar.Size = new Size(69, 20);
            mnsCadastrar.Text = "Cadastrar";
            mnsCadastrar.Click += mnsCadastrar_Click;
            // 
            // mnsSobre
            // 
            mnsSobre.Name = "mnsSobre";
            mnsSobre.Size = new Size(49, 20);
            mnsSobre.Text = "Sobre";
            // 
            // mnsListagem
            // 
            mnsListagem.Name = "mnsListagem";
            mnsListagem.Size = new Size(67, 20);
            mnsListagem.Text = "Listagem";
            mnsListagem.Click += mnsListagem_Click;
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(38, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(422, 288);
            Controls.Add(pictureBox1);
            Controls.Add(msnMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = msnMenu;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            msnMenu.ResumeLayout(false);
            msnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msnMenu;
        private ToolStripMenuItem mnsCadastrar;
        private ToolStripMenuItem mnsSobre;
        private ToolStripMenuItem mnsSair;
        private PictureBox pictureBox1;
        private ToolStripMenuItem mnsListagem;
    }
}
