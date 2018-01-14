namespace GUI.Home
{
    partial class ucQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuiz));
            this.lbMenuTitle = new System.Windows.Forms.Label();
            this.btnTab2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTab1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.pcMenuIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pcMenuIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMenuTitle
            // 
            this.lbMenuTitle.AutoSize = true;
            this.lbMenuTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMenuTitle.Location = new System.Drawing.Point(63, 25);
            this.lbMenuTitle.Name = "lbMenuTitle";
            this.lbMenuTitle.Size = new System.Drawing.Size(108, 21);
            this.lbMenuTitle.TabIndex = 10;
            this.lbMenuTitle.Text = "Quiz Manager";
            // 
            // btnTab2
            // 
            this.btnTab2.BackColor = System.Drawing.SystemColors.Control;
            this.btnTab2.color = System.Drawing.SystemColors.Control;
            this.btnTab2.colorActive = System.Drawing.Color.Gainsboro;
            this.btnTab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTab2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnTab2.Image = ((System.Drawing.Image)(resources.GetObject("btnTab2.Image")));
            this.btnTab2.ImagePosition = 18;
            this.btnTab2.ImageZoom = 30;
            this.btnTab2.LabelPosition = 36;
            this.btnTab2.LabelText = "Quiz Manager";
            this.btnTab2.Location = new System.Drawing.Point(157, 66);
            this.btnTab2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTab2.Name = "btnTab2";
            this.btnTab2.Size = new System.Drawing.Size(142, 99);
            this.btnTab2.TabIndex = 12;
            // 
            // btnTab1
            // 
            this.btnTab1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTab1.color = System.Drawing.SystemColors.Control;
            this.btnTab1.colorActive = System.Drawing.Color.Gainsboro;
            this.btnTab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTab1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnTab1.Image = ((System.Drawing.Image)(resources.GetObject("btnTab1.Image")));
            this.btnTab1.ImagePosition = 18;
            this.btnTab1.ImageZoom = 30;
            this.btnTab1.LabelPosition = 36;
            this.btnTab1.LabelText = "Create Quiz";
            this.btnTab1.Location = new System.Drawing.Point(-1, 66);
            this.btnTab1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTab1.Name = "btnTab1";
            this.btnTab1.Size = new System.Drawing.Size(150, 99);
            this.btnTab1.TabIndex = 11;
            // 
            // pcMenuIcon
            // 
            this.pcMenuIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcMenuIcon.Image")));
            this.pcMenuIcon.Location = new System.Drawing.Point(27, 20);
            this.pcMenuIcon.Name = "pcMenuIcon";
            this.pcMenuIcon.Size = new System.Drawing.Size(30, 30);
            this.pcMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcMenuIcon.TabIndex = 9;
            this.pcMenuIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTab2);
            this.panel1.Controls.Add(this.pcMenuIcon);
            this.panel1.Controls.Add(this.btnTab1);
            this.panel1.Controls.Add(this.lbMenuTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 165);
            this.panel1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1014, 445);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // ucQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ucQuiz";
            this.Size = new System.Drawing.Size(1014, 610);
            ((System.ComponentModel.ISupportInitialize)(this.pcMenuIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnTab2;
        private Bunifu.Framework.UI.BunifuTileButton btnTab1;
        private System.Windows.Forms.Label lbMenuTitle;
        private System.Windows.Forms.PictureBox pcMenuIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
