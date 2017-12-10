﻿namespace Maquette_1
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sélectionnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redémmarerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerContenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCheminSource = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpboxConfiguration = new System.Windows.Forms.GroupBox();
            this.lblCroissantStatic = new System.Windows.Forms.Label();
            this.chkboxCroissant = new System.Windows.Forms.CheckBox();
            this.lblAleatoirementStatic = new System.Windows.Forms.Label();
            this.chkboxAleatoire = new System.Windows.Forms.CheckBox();
            this.lblCreationDesGroupesStatic = new System.Windows.Forms.Label();
            this.rdobtnNombreDeGroupes = new System.Windows.Forms.RadioButton();
            this.rdobtnPersonnesParGroupe = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtagrdSource = new System.Windows.Forms.DataGridView();
            this.Personne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFichierSourceStatic = new System.Windows.Forms.Label();
            this.lblNombrePersonnes = new System.Windows.Forms.Label();
            this.lblResultatStatic = new System.Windows.Forms.Label();
            this.dtagrdResultat = new System.Windows.Forms.DataGridView();
            this.Groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonneResultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpboxConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sélectionnerToolStripMenuItem,
            this.redémmarerToolStripMenuItem,
            this.arrêterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // sélectionnerToolStripMenuItem
            // 
            this.sélectionnerToolStripMenuItem.Name = "sélectionnerToolStripMenuItem";
            this.sélectionnerToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sélectionnerToolStripMenuItem.Text = "Ouvrir";
            // 
            // redémmarerToolStripMenuItem
            // 
            this.redémmarerToolStripMenuItem.Name = "redémmarerToolStripMenuItem";
            this.redémmarerToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.redémmarerToolStripMenuItem.Text = "Redémmarrer";
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.arrêterToolStripMenuItem.Text = "Quitter";
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effacerContenuToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // effacerContenuToolStripMenuItem
            // 
            this.effacerContenuToolStripMenuItem.Name = "effacerContenuToolStripMenuItem";
            this.effacerContenuToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.effacerContenuToolStripMenuItem.Text = "Effacer contenu";
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(258, 52);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(293, 34);
            this.btnExportTxt.TabIndex = 4;
            this.btnExportTxt.Text = "Exporter au format texte";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(258, 92);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(293, 34);
            this.btnExportCsv.TabIndex = 5;
            this.btnExportCsv.Text = "Exporter au format csv";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCheminSource);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(258, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblCheminSource
            // 
            this.lblCheminSource.AutoSize = true;
            this.lblCheminSource.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCheminSource.Location = new System.Drawing.Point(42, 32);
            this.lblCheminSource.Name = "lblCheminSource";
            this.lblCheminSource.Size = new System.Drawing.Size(202, 13);
            this.lblCheminSource.TabIndex = 0;
            this.lblCheminSource.Text = "C:\\Users\\creb\\Documents\\personnes.txt";
            this.lblCheminSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // grpboxConfiguration
            // 
            this.grpboxConfiguration.Controls.Add(this.lblCroissantStatic);
            this.grpboxConfiguration.Controls.Add(this.chkboxCroissant);
            this.grpboxConfiguration.Controls.Add(this.lblAleatoirementStatic);
            this.grpboxConfiguration.Controls.Add(this.chkboxAleatoire);
            this.grpboxConfiguration.Controls.Add(this.lblCreationDesGroupesStatic);
            this.grpboxConfiguration.Controls.Add(this.rdobtnNombreDeGroupes);
            this.grpboxConfiguration.Controls.Add(this.rdobtnPersonnesParGroupe);
            this.grpboxConfiguration.Controls.Add(this.textBox3);
            this.grpboxConfiguration.Controls.Add(this.textBox1);
            this.grpboxConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpboxConfiguration.Location = new System.Drawing.Point(258, 135);
            this.grpboxConfiguration.Name = "grpboxConfiguration";
            this.grpboxConfiguration.Size = new System.Drawing.Size(293, 200);
            this.grpboxConfiguration.TabIndex = 8;
            this.grpboxConfiguration.TabStop = false;
            this.grpboxConfiguration.Text = "Configuration";
            // 
            // lblCroissantStatic
            // 
            this.lblCroissantStatic.AutoSize = true;
            this.lblCroissantStatic.Location = new System.Drawing.Point(125, 146);
            this.lblCroissantStatic.Name = "lblCroissantStatic";
            this.lblCroissantStatic.Size = new System.Drawing.Size(58, 15);
            this.lblCroissantStatic.TabIndex = 19;
            this.lblCroissantStatic.Text = "Croissant";
            // 
            // chkboxCroissant
            // 
            this.chkboxCroissant.AutoSize = true;
            this.chkboxCroissant.Location = new System.Drawing.Point(239, 147);
            this.chkboxCroissant.Name = "chkboxCroissant";
            this.chkboxCroissant.Size = new System.Drawing.Size(15, 14);
            this.chkboxCroissant.TabIndex = 18;
            this.chkboxCroissant.UseVisualStyleBackColor = true;
            // 
            // lblAleatoirementStatic
            // 
            this.lblAleatoirementStatic.AutoSize = true;
            this.lblAleatoirementStatic.Location = new System.Drawing.Point(125, 131);
            this.lblAleatoirementStatic.Name = "lblAleatoirementStatic";
            this.lblAleatoirementStatic.Size = new System.Drawing.Size(83, 15);
            this.lblAleatoirementStatic.TabIndex = 17;
            this.lblAleatoirementStatic.Text = "Aléatoirement";
            // 
            // chkboxAleatoire
            // 
            this.chkboxAleatoire.AutoSize = true;
            this.chkboxAleatoire.Location = new System.Drawing.Point(239, 132);
            this.chkboxAleatoire.Name = "chkboxAleatoire";
            this.chkboxAleatoire.Size = new System.Drawing.Size(15, 14);
            this.chkboxAleatoire.TabIndex = 16;
            this.chkboxAleatoire.UseVisualStyleBackColor = true;
            // 
            // lblCreationDesGroupesStatic
            // 
            this.lblCreationDesGroupesStatic.AutoSize = true;
            this.lblCreationDesGroupesStatic.Location = new System.Drawing.Point(3, 112);
            this.lblCreationDesGroupesStatic.Name = "lblCreationDesGroupesStatic";
            this.lblCreationDesGroupesStatic.Size = new System.Drawing.Size(130, 15);
            this.lblCreationDesGroupesStatic.TabIndex = 14;
            this.lblCreationDesGroupesStatic.Text = "Création des groupes :";
            // 
            // rdobtnNombreDeGroupes
            // 
            this.rdobtnNombreDeGroupes.AutoSize = true;
            this.rdobtnNombreDeGroupes.Location = new System.Drawing.Point(6, 81);
            this.rdobtnNombreDeGroupes.Name = "rdobtnNombreDeGroupes";
            this.rdobtnNombreDeGroupes.Size = new System.Drawing.Size(135, 19);
            this.rdobtnNombreDeGroupes.TabIndex = 13;
            this.rdobtnNombreDeGroupes.TabStop = true;
            this.rdobtnNombreDeGroupes.Text = "Nombre de groupes";
            this.rdobtnNombreDeGroupes.UseVisualStyleBackColor = true;
            // 
            // rdobtnPersonnesParGroupe
            // 
            this.rdobtnPersonnesParGroupe.AutoSize = true;
            this.rdobtnPersonnesParGroupe.Location = new System.Drawing.Point(6, 44);
            this.rdobtnPersonnesParGroupe.Name = "rdobtnPersonnesParGroupe";
            this.rdobtnPersonnesParGroupe.Size = new System.Drawing.Size(217, 19);
            this.rdobtnPersonnesParGroupe.TabIndex = 12;
            this.rdobtnPersonnesParGroupe.TabStop = true;
            this.rdobtnPersonnesParGroupe.Text = "Nombre de personnes par groupes";
            this.rdobtnPersonnesParGroupe.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(239, 79);
            this.textBox3.MaxLength = 3;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 21);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "3";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 42);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "3";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtagrdSource
            // 
            this.dtagrdSource.AllowUserToOrderColumns = true;
            this.dtagrdSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagrdSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personne});
            this.dtagrdSource.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtagrdSource.Location = new System.Drawing.Point(12, 52);
            this.dtagrdSource.Name = "dtagrdSource";
            this.dtagrdSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtagrdSource.Size = new System.Drawing.Size(236, 358);
            this.dtagrdSource.TabIndex = 9;
            // 
            // Personne
            // 
            this.Personne.HeaderText = "Personne";
            this.Personne.Name = "Personne";
            this.Personne.Width = 192;
            // 
            // lblFichierSourceStatic
            // 
            this.lblFichierSourceStatic.AutoSize = true;
            this.lblFichierSourceStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichierSourceStatic.Location = new System.Drawing.Point(9, 33);
            this.lblFichierSourceStatic.Name = "lblFichierSourceStatic";
            this.lblFichierSourceStatic.Size = new System.Drawing.Size(98, 16);
            this.lblFichierSourceStatic.TabIndex = 15;
            this.lblFichierSourceStatic.Text = "Fichier source :";
            // 
            // lblNombrePersonnes
            // 
            this.lblNombrePersonnes.AutoSize = true;
            this.lblNombrePersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePersonnes.Location = new System.Drawing.Point(9, 416);
            this.lblNombrePersonnes.Name = "lblNombrePersonnes";
            this.lblNombrePersonnes.Size = new System.Drawing.Size(159, 16);
            this.lblNombrePersonnes.TabIndex = 17;
            this.lblNombrePersonnes.Text = "Nombre de personnes : 7";
            // 
            // lblResultatStatic
            // 
            this.lblResultatStatic.AutoSize = true;
            this.lblResultatStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultatStatic.Location = new System.Drawing.Point(557, 34);
            this.lblResultatStatic.Name = "lblResultatStatic";
            this.lblResultatStatic.Size = new System.Drawing.Size(63, 16);
            this.lblResultatStatic.TabIndex = 19;
            this.lblResultatStatic.Text = "Résultat :";
            // 
            // dtagrdResultat
            // 
            this.dtagrdResultat.AllowUserToOrderColumns = true;
            this.dtagrdResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagrdResultat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Groupe,
            this.PersonneResultat});
            this.dtagrdResultat.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtagrdResultat.Location = new System.Drawing.Point(560, 52);
            this.dtagrdResultat.Name = "dtagrdResultat";
            this.dtagrdResultat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtagrdResultat.Size = new System.Drawing.Size(302, 358);
            this.dtagrdResultat.TabIndex = 18;
            // 
            // Groupe
            // 
            this.Groupe.HeaderText = "Groupe";
            this.Groupe.Name = "Groupe";
            this.Groupe.Width = 60;
            // 
            // PersonneResultat
            // 
            this.PersonneResultat.HeaderText = "Personne";
            this.PersonneResultat.Name = "PersonneResultat";
            this.PersonneResultat.Width = 198;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 438);
            this.Controls.Add(this.lblResultatStatic);
            this.Controls.Add(this.dtagrdResultat);
            this.Controls.Add(this.lblNombrePersonnes);
            this.Controls.Add(this.lblFichierSourceStatic);
            this.Controls.Add(this.dtagrdSource);
            this.Controls.Add(this.grpboxConfiguration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Générateur de groupe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpboxConfiguration.ResumeLayout(false);
            this.grpboxConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sélectionnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redémmarerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerContenuToolStripMenuItem;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCheminSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpboxConfiguration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdobtnNombreDeGroupes;
        private System.Windows.Forms.RadioButton rdobtnPersonnesParGroupe;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCroissantStatic;
        private System.Windows.Forms.CheckBox chkboxCroissant;
        private System.Windows.Forms.Label lblAleatoirementStatic;
        private System.Windows.Forms.CheckBox chkboxAleatoire;
        private System.Windows.Forms.Label lblCreationDesGroupesStatic;
        public System.Windows.Forms.DataGridView dtagrdSource;
        private System.Windows.Forms.Label lblFichierSourceStatic;
        private System.Windows.Forms.Label lblNombrePersonnes;
        private System.Windows.Forms.Label lblResultatStatic;
        public System.Windows.Forms.DataGridView dtagrdResultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonneResultat;
    }
}
