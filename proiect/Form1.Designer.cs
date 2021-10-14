namespace proiect
{
    partial class Form1
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
            this.bfs = new System.Windows.Forms.Button();
            this.ucs = new System.Windows.Forms.Button();
            this.dfs = new System.Windows.Forms.Button();
            this.dls = new System.Windows.Forms.Button();
            this.ids = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mini = new System.Windows.Forms.Button();
            this.alpha = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bfs
            // 
            this.bfs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bfs.Location = new System.Drawing.Point(18, 83);
            this.bfs.Name = "bfs";
            this.bfs.Size = new System.Drawing.Size(289, 37);
            this.bfs.TabIndex = 0;
            this.bfs.Text = "Breadth First Search (Cautarea pe nivel)";
            this.bfs.UseVisualStyleBackColor = false;
            this.bfs.Click += new System.EventHandler(this.bfs_Click);
            // 
            // ucs
            // 
            this.ucs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ucs.Location = new System.Drawing.Point(18, 143);
            this.ucs.Name = "ucs";
            this.ucs.Size = new System.Drawing.Size(289, 37);
            this.ucs.TabIndex = 1;
            this.ucs.Text = "Uniform Cost Search";
            this.ucs.UseVisualStyleBackColor = false;
            this.ucs.Click += new System.EventHandler(this.ucs_Click);
            // 
            // dfs
            // 
            this.dfs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dfs.Location = new System.Drawing.Point(18, 206);
            this.dfs.Name = "dfs";
            this.dfs.Size = new System.Drawing.Size(289, 37);
            this.dfs.TabIndex = 2;
            this.dfs.Text = "Depth First Search (Cautarea in adancime)";
            this.dfs.UseVisualStyleBackColor = false;
            this.dfs.Click += new System.EventHandler(this.dfs_Click);
            // 
            // dls
            // 
            this.dls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dls.Location = new System.Drawing.Point(18, 264);
            this.dls.Name = "dls";
            this.dls.Size = new System.Drawing.Size(289, 37);
            this.dls.TabIndex = 3;
            this.dls.Text = "Depth Limited Search";
            this.dls.UseVisualStyleBackColor = false;
            this.dls.Click += new System.EventHandler(this.dls_Click);
            // 
            // ids
            // 
            this.ids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ids.Location = new System.Drawing.Point(18, 322);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(289, 37);
            this.ids.TabIndex = 4;
            this.ids.Text = "Iterated Deepening Search";
            this.ids.UseVisualStyleBackColor = false;
            this.ids.Click += new System.EventHandler(this.ids_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Strategii de cautare neinformate ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(475, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Algoritmi de căutare locală";
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mini.Location = new System.Drawing.Point(420, 83);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(289, 37);
            this.mini.TabIndex = 7;
            this.mini.Text = "Minimax";
            this.mini.UseVisualStyleBackColor = false;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // alpha
            // 
            this.alpha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.alpha.Location = new System.Drawing.Point(420, 143);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(289, 37);
            this.alpha.TabIndex = 8;
            this.alpha.Text = "Alpha-Beta Pruning";
            this.alpha.UseVisualStyleBackColor = false;
            this.alpha.Click += new System.EventHandler(this.alpha_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(579, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proiect.Properties.Resources.CJBg9I;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ids);
            this.Controls.Add(this.dls);
            this.Controls.Add(this.dfs);
            this.Controls.Add(this.ucs);
            this.Controls.Add(this.bfs);
            this.Name = "Form1";
            this.Text = "Proiect IA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bfs;
        private System.Windows.Forms.Button ucs;
        private System.Windows.Forms.Button dfs;
        private System.Windows.Forms.Button dls;
        private System.Windows.Forms.Button ids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mini;
        private System.Windows.Forms.Button alpha;
        private System.Windows.Forms.Button button1;
    }
}

