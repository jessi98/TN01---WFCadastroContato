﻿namespace WFUsandoListagem2
{
    partial class FormListagem
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
            dgvListagemUsuarios = new DataGridView();
            lblListagemUsuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListagemUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvListagemUsuarios
            // 
            dgvListagemUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListagemUsuarios.Location = new Point(3, 40);
            dgvListagemUsuarios.Name = "dgvListagemUsuarios";
            dgvListagemUsuarios.Size = new Size(466, 220);
            dgvListagemUsuarios.TabIndex = 0;
            // 
            // lblListagemUsuarios
            // 
            lblListagemUsuarios.AutoSize = true;
            lblListagemUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListagemUsuarios.Location = new Point(12, 9);
            lblListagemUsuarios.Name = "lblListagemUsuarios";
            lblListagemUsuarios.Size = new Size(200, 25);
            lblListagemUsuarios.TabIndex = 1;
            lblListagemUsuarios.Text = "Listagem de Usuários";
            lblListagemUsuarios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 263);
            Controls.Add(lblListagemUsuarios);
            Controls.Add(dgvListagemUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListagem";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListagemUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListagemUsuarios;
        private Label lblListagemUsuarios;
    }
}