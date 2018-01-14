namespace GUI.Home
{
    partial class ucReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReport));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuizManager = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCreateQuiz = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1014, 445);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuizManager);
            this.panel1.Controls.Add(this.btnCreateQuiz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 165);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Report";
            // 
            // btnQuizManager
            // 
            this.btnQuizManager.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuizManager.color = System.Drawing.SystemColors.Control;
            this.btnQuizManager.colorActive = System.Drawing.Color.Gainsboro;
            this.btnQuizManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuizManager.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnQuizManager.Image = ((System.Drawing.Image)(resources.GetObject("btnQuizManager.Image")));
            this.btnQuizManager.ImagePosition = 15;
            this.btnQuizManager.ImageZoom = 50;
            this.btnQuizManager.LabelPosition = 29;
            this.btnQuizManager.LabelText = "Result";
            this.btnQuizManager.Location = new System.Drawing.Point(164, 66);
            this.btnQuizManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuizManager.Name = "btnQuizManager";
            this.btnQuizManager.Size = new System.Drawing.Size(152, 99);
            this.btnQuizManager.TabIndex = 12;
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateQuiz.color = System.Drawing.SystemColors.Control;
            this.btnCreateQuiz.colorActive = System.Drawing.Color.Gainsboro;
            this.btnCreateQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateQuiz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnCreateQuiz.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateQuiz.Image")));
            this.btnCreateQuiz.ImagePosition = 14;
            this.btnCreateQuiz.ImageZoom = 35;
            this.btnCreateQuiz.LabelPosition = 29;
            this.btnCreateQuiz.LabelText = "Question ";
            this.btnCreateQuiz.Location = new System.Drawing.Point(0, 66);
            this.btnCreateQuiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(156, 99);
            this.btnCreateQuiz.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ucReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ucReport";
            this.Size = new System.Drawing.Size(1014, 610);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton btnQuizManager;
        private Bunifu.Framework.UI.BunifuTileButton btnCreateQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
