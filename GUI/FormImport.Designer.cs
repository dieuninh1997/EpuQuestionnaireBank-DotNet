namespace GUI
{
    partial class FormImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMinus = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.dgvSimpleQuestion = new System.Windows.Forms.DataGridView();
            this.dgvMultiQuestion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtView = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimpleQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbMinus);
            this.panel1.Controls.Add(this.lbExit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 37);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbMinus
            // 
            this.lbMinus.Image = ((System.Drawing.Image)(resources.GetObject("lbMinus.Image")));
            this.lbMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMinus.Location = new System.Drawing.Point(1153, 6);
            this.lbMinus.Name = "lbMinus";
            this.lbMinus.Size = new System.Drawing.Size(29, 26);
            this.lbMinus.TabIndex = 2;
            this.lbMinus.Click += new System.EventHandler(this.lbMinus_Click);
            // 
            // lbExit
            // 
            this.lbExit.Image = ((System.Drawing.Image)(resources.GetObject("lbExit.Image")));
            this.lbExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbExit.Location = new System.Drawing.Point(1190, 6);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(27, 26);
            this.lbExit.TabIndex = 1;
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(49, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(389, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Questionnaire Bank - Question Manager - Data Importer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select A Subject";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(15, 66);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(182, 21);
            this.cmbSubject.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(640, 67);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(489, 20);
            this.txtPath.TabIndex = 12;
            // 
            // btnBrower
            // 
            this.btnBrower.BackColor = System.Drawing.Color.Orchid;
            this.btnBrower.Location = new System.Drawing.Point(1132, 56);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(75, 38);
            this.btnBrower.TabIndex = 13;
            this.btnBrower.Text = "Brower";
            this.btnBrower.UseVisualStyleBackColor = false;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // dgvSimpleQuestion
            // 
            this.dgvSimpleQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimpleQuestion.Location = new System.Drawing.Point(15, 118);
            this.dgvSimpleQuestion.Name = "dgvSimpleQuestion";
            this.dgvSimpleQuestion.Size = new System.Drawing.Size(642, 191);
            this.dgvSimpleQuestion.TabIndex = 14;
            this.dgvSimpleQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSimpleQuestion_CellClick);
            // 
            // dgvMultiQuestion
            // 
            this.dgvMultiQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultiQuestion.Location = new System.Drawing.Point(15, 340);
            this.dgvMultiQuestion.Name = "dgvMultiQuestion";
            this.dgvMultiQuestion.Size = new System.Drawing.Size(642, 191);
            this.dgvMultiQuestion.TabIndex = 15;
            this.dgvMultiQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMultiQuestion_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Single Question List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Multi Question List";
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(675, 118);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtView.Size = new System.Drawing.Size(532, 342);
            this.txtView.TabIndex = 18;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Orchid;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(801, 479);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(147, 38);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "Import To Database";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(988, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 543);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMultiQuestion);
            this.Controls.Add(this.dgvSimpleQuestion);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.Load += new System.EventHandler(this.FormImport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimpleQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbMinus;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.DataGridView dgvSimpleQuestion;
        private System.Windows.Forms.DataGridView dgvMultiQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}