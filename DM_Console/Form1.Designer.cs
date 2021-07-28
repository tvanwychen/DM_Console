
namespace DM_Console
{
    partial class FrmConsole
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoteTitle = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPlayer = new System.Windows.Forms.TabPage();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.tabNPC = new System.Windows.Forms.TabPage();
            this.btnDeleteNPC = new System.Windows.Forms.Button();
            this.btnCreateNPC = new System.Windows.Forms.Button();
            this.tabBoss = new System.Windows.Forms.TabPage();
            this.btnDeleteBoss = new System.Windows.Forms.Button();
            this.btnCreateBoss = new System.Windows.Forms.Button();
            this.tabEnemy = new System.Windows.Forms.TabPage();
            this.btnDeleteEnemy = new System.Windows.Forms.Button();
            this.btnCreateEnemy = new System.Windows.Forms.Button();
            this.tabNote = new System.Windows.Forms.TabPage();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.btnCreateNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPlayer.SuspendLayout();
            this.tabNPC.SuspendLayout();
            this.tabBoss.SuspendLayout();
            this.tabEnemy.SuspendLayout();
            this.tabNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblNoteTitle);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1609, 849);
            this.splitContainer1.SplitterDistance = 1275;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(841, 426);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(413, 420);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(422, 426);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 420);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 426);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 419);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(841, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 417);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(422, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 417);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 417);
            this.panel1.TabIndex = 0;
            // 
            // lblNoteTitle
            // 
            this.lblNoteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoteTitle.AutoSize = true;
            this.lblNoteTitle.Location = new System.Drawing.Point(147, 15);
            this.lblNoteTitle.Name = "lblNoteTitle";
            this.lblNoteTitle.Size = new System.Drawing.Size(63, 25);
            this.lblNoteTitle.TabIndex = 2;
            this.lblNoteTitle.Text = "Notes";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 525);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPlayer);
            this.tabControl.Controls.Add(this.tabNPC);
            this.tabControl.Controls.Add(this.tabBoss);
            this.tabControl.Controls.Add(this.tabEnemy);
            this.tabControl.Controls.Add(this.tabNote);
            this.tabControl.Location = new System.Drawing.Point(3, 574);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(327, 275);
            this.tabControl.TabIndex = 0;
            // 
            // tabPlayer
            // 
            this.tabPlayer.Controls.Add(this.btnDeletePlayer);
            this.tabPlayer.Controls.Add(this.btnCreatePlayer);
            this.tabPlayer.Location = new System.Drawing.Point(4, 34);
            this.tabPlayer.Name = "tabPlayer";
            this.tabPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayer.Size = new System.Drawing.Size(319, 237);
            this.tabPlayer.TabIndex = 0;
            this.tabPlayer.Text = "Players";
            this.tabPlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(224, 193);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(87, 36);
            this.btnDeletePlayer.TabIndex = 3;
            this.btnDeletePlayer.Text = "Delete";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Location = new System.Drawing.Point(3, 193);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(87, 36);
            this.btnCreatePlayer.TabIndex = 0;
            this.btnCreatePlayer.Text = "Create";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            // 
            // tabNPC
            // 
            this.tabNPC.Controls.Add(this.btnDeleteNPC);
            this.tabNPC.Controls.Add(this.btnCreateNPC);
            this.tabNPC.Location = new System.Drawing.Point(4, 34);
            this.tabNPC.Name = "tabNPC";
            this.tabNPC.Padding = new System.Windows.Forms.Padding(3);
            this.tabNPC.Size = new System.Drawing.Size(319, 237);
            this.tabNPC.TabIndex = 1;
            this.tabNPC.Text = "NPC\'s";
            this.tabNPC.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNPC
            // 
            this.btnDeleteNPC.Location = new System.Drawing.Point(224, 193);
            this.btnDeleteNPC.Name = "btnDeleteNPC";
            this.btnDeleteNPC.Size = new System.Drawing.Size(87, 36);
            this.btnDeleteNPC.TabIndex = 3;
            this.btnDeleteNPC.Text = "Delete";
            this.btnDeleteNPC.UseVisualStyleBackColor = true;
            // 
            // btnCreateNPC
            // 
            this.btnCreateNPC.Location = new System.Drawing.Point(3, 193);
            this.btnCreateNPC.Name = "btnCreateNPC";
            this.btnCreateNPC.Size = new System.Drawing.Size(87, 36);
            this.btnCreateNPC.TabIndex = 1;
            this.btnCreateNPC.Text = "Create";
            this.btnCreateNPC.UseVisualStyleBackColor = true;
            // 
            // tabBoss
            // 
            this.tabBoss.Controls.Add(this.btnDeleteBoss);
            this.tabBoss.Controls.Add(this.btnCreateBoss);
            this.tabBoss.Location = new System.Drawing.Point(4, 34);
            this.tabBoss.Name = "tabBoss";
            this.tabBoss.Size = new System.Drawing.Size(319, 237);
            this.tabBoss.TabIndex = 2;
            this.tabBoss.Text = "Bosses";
            this.tabBoss.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBoss
            // 
            this.btnDeleteBoss.Location = new System.Drawing.Point(224, 193);
            this.btnDeleteBoss.Name = "btnDeleteBoss";
            this.btnDeleteBoss.Size = new System.Drawing.Size(87, 36);
            this.btnDeleteBoss.TabIndex = 3;
            this.btnDeleteBoss.Text = "Delete";
            this.btnDeleteBoss.UseVisualStyleBackColor = true;
            // 
            // btnCreateBoss
            // 
            this.btnCreateBoss.Location = new System.Drawing.Point(3, 193);
            this.btnCreateBoss.Name = "btnCreateBoss";
            this.btnCreateBoss.Size = new System.Drawing.Size(87, 36);
            this.btnCreateBoss.TabIndex = 1;
            this.btnCreateBoss.Text = "Create";
            this.btnCreateBoss.UseVisualStyleBackColor = true;
            // 
            // tabEnemy
            // 
            this.tabEnemy.Controls.Add(this.btnDeleteEnemy);
            this.tabEnemy.Controls.Add(this.btnCreateEnemy);
            this.tabEnemy.Location = new System.Drawing.Point(4, 34);
            this.tabEnemy.Name = "tabEnemy";
            this.tabEnemy.Size = new System.Drawing.Size(319, 237);
            this.tabEnemy.TabIndex = 4;
            this.tabEnemy.Text = "Enemies";
            this.tabEnemy.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEnemy
            // 
            this.btnDeleteEnemy.Location = new System.Drawing.Point(224, 193);
            this.btnDeleteEnemy.Name = "btnDeleteEnemy";
            this.btnDeleteEnemy.Size = new System.Drawing.Size(87, 36);
            this.btnDeleteEnemy.TabIndex = 3;
            this.btnDeleteEnemy.Text = "Delete";
            this.btnDeleteEnemy.UseVisualStyleBackColor = true;
            // 
            // btnCreateEnemy
            // 
            this.btnCreateEnemy.Location = new System.Drawing.Point(3, 193);
            this.btnCreateEnemy.Name = "btnCreateEnemy";
            this.btnCreateEnemy.Size = new System.Drawing.Size(87, 36);
            this.btnCreateEnemy.TabIndex = 1;
            this.btnCreateEnemy.Text = "Create";
            this.btnCreateEnemy.UseVisualStyleBackColor = true;
            // 
            // tabNote
            // 
            this.tabNote.Controls.Add(this.btnDeleteNote);
            this.tabNote.Controls.Add(this.btnCreateNote);
            this.tabNote.Location = new System.Drawing.Point(4, 34);
            this.tabNote.Name = "tabNote";
            this.tabNote.Size = new System.Drawing.Size(319, 237);
            this.tabNote.TabIndex = 3;
            this.tabNote.Text = "Notes";
            this.tabNote.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Location = new System.Drawing.Point(224, 193);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(87, 36);
            this.btnDeleteNote.TabIndex = 2;
            this.btnDeleteNote.Text = "Delete";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.Location = new System.Drawing.Point(3, 193);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(87, 36);
            this.btnCreateNote.TabIndex = 1;
            this.btnCreateNote.Text = "Create";
            this.btnCreateNote.UseVisualStyleBackColor = true;
            // 
            // FrmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 849);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConsole";
            this.Text = "DM_Console";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPlayer.ResumeLayout(false);
            this.tabNPC.ResumeLayout(false);
            this.tabBoss.ResumeLayout(false);
            this.tabEnemy.ResumeLayout(false);
            this.tabNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPlayer;
        private System.Windows.Forms.Label lblNoteTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.TabPage tabNPC;
        private System.Windows.Forms.Button btnDeleteNPC;
        private System.Windows.Forms.Button btnCreateNPC;
        private System.Windows.Forms.TabPage tabBoss;
        private System.Windows.Forms.Button btnDeleteBoss;
        private System.Windows.Forms.Button btnCreateBoss;
        private System.Windows.Forms.TabPage tabEnemy;
        private System.Windows.Forms.Button btnDeleteEnemy;
        private System.Windows.Forms.Button btnCreateEnemy;
        private System.Windows.Forms.TabPage tabNote;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

