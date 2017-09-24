namespace CIS2
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.About = new System.Windows.Forms.GroupBox();
            this._dGW = new System.Windows.Forms.DataGridView();
            this._btnFill = new System.Windows.Forms.Button();
            this._tbSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._TBtoken = new System.Windows.Forms.TextBox();
            this._btnGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._rTB = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dGW)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.About);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // About
            // 
            this.About.Controls.Add(this._dGW);
            this.About.Controls.Add(this._btnFill);
            this.About.Controls.Add(this._tbSize);
            this.About.Controls.Add(this.label1);
            this.About.Location = new System.Drawing.Point(6, 19);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(400, 429);
            this.About.TabIndex = 1;
            this.About.TabStop = false;
            this.About.Text = "About";
            // 
            // _dGW
            // 
            this._dGW.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this._dGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dGW.Location = new System.Drawing.Point(11, 46);
            this._dGW.Name = "_dGW";
            this._dGW.Size = new System.Drawing.Size(380, 370);
            this._dGW.TabIndex = 0;
            this._dGW.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._dGW_CellEndEdit);
            // 
            // _btnFill
            // 
            this._btnFill.Location = new System.Drawing.Point(147, 18);
            this._btnFill.Name = "_btnFill";
            this._btnFill.Size = new System.Drawing.Size(75, 23);
            this._btnFill.TabIndex = 2;
            this._btnFill.Text = "Fill Matrix";
            this._btnFill.UseVisualStyleBackColor = true;
            this._btnFill.Click += new System.EventHandler(this._btnFill_Click);
            // 
            // _tbSize
            // 
            this._tbSize.Location = new System.Drawing.Point(41, 20);
            this._tbSize.Name = "_tbSize";
            this._tbSize.Size = new System.Drawing.Size(100, 20);
            this._tbSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._TBtoken);
            this.groupBox3.Controls.Add(this._btnGo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(437, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HTTP";
            // 
            // _TBtoken
            // 
            this._TBtoken.Location = new System.Drawing.Point(53, 30);
            this._TBtoken.Name = "_TBtoken";
            this._TBtoken.Size = new System.Drawing.Size(276, 20);
            this._TBtoken.TabIndex = 4;
            // 
            // _btnGo
            // 
            this._btnGo.Location = new System.Drawing.Point(9, 56);
            this._btnGo.Name = "_btnGo";
            this._btnGo.Size = new System.Drawing.Size(320, 46);
            this._btnGo.TabIndex = 2;
            this._btnGo.Text = "GO";
            this._btnGo.UseVisualStyleBackColor = true;
            this._btnGo.Click += new System.EventHandler(this._btnGo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Token";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._rTB);
            this.groupBox2.Location = new System.Drawing.Point(437, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // _rTB
            // 
            this._rTB.Location = new System.Drawing.Point(7, 20);
            this._rTB.Name = "_rTB";
            this._rTB.Size = new System.Drawing.Size(322, 309);
            this._rTB.TabIndex = 0;
            this._rTB.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "MainWindow";
            this.Text = "Rest Client";
            this.groupBox1.ResumeLayout(false);
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dGW)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView _dGW;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox About;
        private System.Windows.Forms.Button _btnFill;
        private System.Windows.Forms.TextBox _tbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _TBtoken;
        private System.Windows.Forms.Button _btnGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox _rTB;

    }
}

