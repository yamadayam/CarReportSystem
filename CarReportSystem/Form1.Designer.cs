﻿namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.CreateDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonToyota = new System.Windows.Forms.RadioButton();
            this.radioButtonNissan = new System.Windows.Forms.RadioButton();
            this.radioButtonHonda = new System.Windows.Forms.RadioButton();
            this.radioButtonSubaru = new System.Windows.Forms.RadioButton();
            this.radioButtonGaisha = new System.Windows.Forms.RadioButton();
            this.radioButtonSonota = new System.Windows.Forms.RadioButton();
            this.CarName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.TextBox();
            this.dgvCarData = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.CarGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.CarGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateDate
            // 
            this.CreateDate.Location = new System.Drawing.Point(75, 14);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(199, 19);
            this.CreateDate.TabIndex = 0;
            this.CreateDate.Value = new System.DateTime(2020, 7, 7, 14, 57, 7, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "日付";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "記録者";
            // 
            // Author
            // 
            this.Author.FormattingEnabled = true;
            this.Author.Location = new System.Drawing.Point(75, 62);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(121, 20);
            this.Author.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "メーカー";
            // 
            // radioButtonToyota
            // 
            this.radioButtonToyota.AutoSize = true;
            this.radioButtonToyota.Location = new System.Drawing.Point(10, 20);
            this.radioButtonToyota.Name = "radioButtonToyota";
            this.radioButtonToyota.Size = new System.Drawing.Size(59, 16);
            this.radioButtonToyota.TabIndex = 5;
            this.radioButtonToyota.TabStop = true;
            this.radioButtonToyota.Text = "トヨタ";
            this.radioButtonToyota.UseVisualStyleBackColor = true;
            // 
            // radioButtonNissan
            // 
            this.radioButtonNissan.AutoSize = true;
            this.radioButtonNissan.Location = new System.Drawing.Point(75, 20);
            this.radioButtonNissan.Name = "radioButtonNissan";
            this.radioButtonNissan.Size = new System.Drawing.Size(47, 16);
            this.radioButtonNissan.TabIndex = 6;
            this.radioButtonNissan.TabStop = true;
            this.radioButtonNissan.Text = "日産";
            this.radioButtonNissan.UseVisualStyleBackColor = true;
            // 
            // radioButtonHonda
            // 
            this.radioButtonHonda.AutoSize = true;
            this.radioButtonHonda.Location = new System.Drawing.Point(129, 20);
            this.radioButtonHonda.Name = "radioButtonHonda";
            this.radioButtonHonda.Size = new System.Drawing.Size(59, 16);
            this.radioButtonHonda.TabIndex = 7;
            this.radioButtonHonda.TabStop = true;
            this.radioButtonHonda.Text = "ホンダ";
            this.radioButtonHonda.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubaru
            // 
            this.radioButtonSubaru.AutoSize = true;
            this.radioButtonSubaru.Location = new System.Drawing.Point(194, 20);
            this.radioButtonSubaru.Name = "radioButtonSubaru";
            this.radioButtonSubaru.Size = new System.Drawing.Size(59, 16);
            this.radioButtonSubaru.TabIndex = 8;
            this.radioButtonSubaru.TabStop = true;
            this.radioButtonSubaru.Text = "スバル";
            this.radioButtonSubaru.UseVisualStyleBackColor = true;
            // 
            // radioButtonGaisha
            // 
            this.radioButtonGaisha.AutoSize = true;
            this.radioButtonGaisha.Location = new System.Drawing.Point(258, 20);
            this.radioButtonGaisha.Name = "radioButtonGaisha";
            this.radioButtonGaisha.Size = new System.Drawing.Size(47, 16);
            this.radioButtonGaisha.TabIndex = 9;
            this.radioButtonGaisha.TabStop = true;
            this.radioButtonGaisha.Text = "外車";
            this.radioButtonGaisha.UseVisualStyleBackColor = true;
            // 
            // radioButtonSonota
            // 
            this.radioButtonSonota.AutoSize = true;
            this.radioButtonSonota.Location = new System.Drawing.Point(310, 18);
            this.radioButtonSonota.Name = "radioButtonSonota";
            this.radioButtonSonota.Size = new System.Drawing.Size(59, 16);
            this.radioButtonSonota.TabIndex = 10;
            this.radioButtonSonota.TabStop = true;
            this.radioButtonSonota.Text = "その他";
            this.radioButtonSonota.UseVisualStyleBackColor = true;
            // 
            // CarName
            // 
            this.CarName.FormattingEnabled = true;
            this.CarName.Location = new System.Drawing.Point(75, 147);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(121, 20);
            this.CarName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(34, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "車名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(1, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "レポート：";
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(78, 194);
            this.Report.Multiline = true;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(382, 177);
            this.Report.TabIndex = 14;
            // 
            // dgvCarData
            // 
            this.dgvCarData.AllowUserToAddRows = false;
            this.dgvCarData.AllowUserToDeleteRows = false;
            this.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarData.Location = new System.Drawing.Point(78, 387);
            this.dgvCarData.MultiSelect = false;
            this.dgvCarData.Name = "dgvCarData";
            this.dgvCarData.ReadOnly = true;
            this.dgvCarData.RowTemplate.Height = 21;
            this.dgvCarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarData.Size = new System.Drawing.Size(656, 252);
            this.dgvCarData.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "記事一覧";
            // 
            // btOpen
            // 
            this.btOpen.Enabled = false;
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOpen.Location = new System.Drawing.Point(11, 420);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(57, 50);
            this.btOpen.TabIndex = 17;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Location = new System.Drawing.Point(11, 493);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(57, 50);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "画像：";
            // 
            // btImageOpen
            // 
            this.btImageOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImageOpen.Location = new System.Drawing.Point(506, 58);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(103, 36);
            this.btImageOpen.TabIndex = 21;
            this.btImageOpen.Text = "開く";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageDelete
            // 
            this.btImageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImageDelete.Location = new System.Drawing.Point(627, 58);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(101, 36);
            this.btImageDelete.TabIndex = 22;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Location = new System.Drawing.Point(466, 334);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(85, 47);
            this.btAdd.TabIndex = 23;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFix
            // 
            this.btFix.Enabled = false;
            this.btFix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFix.Location = new System.Drawing.Point(558, 334);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(85, 47);
            this.btFix.TabIndex = 24;
            this.btFix.Text = "修正";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDelete.Location = new System.Drawing.Point(650, 334);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(84, 47);
            this.btDelete.TabIndex = 25;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEnd
            // 
            this.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEnd.Location = new System.Drawing.Point(639, 644);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(95, 25);
            this.btEnd.TabIndex = 26;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // Picture
            // 
            this.Picture.AccessibleName = "";
            this.Picture.BackColor = System.Drawing.Color.Aqua;
            this.Picture.Location = new System.Drawing.Point(466, 100);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(267, 229);
            this.Picture.TabIndex = 27;
            this.Picture.TabStop = false;
            // 
            // CarGroup
            // 
            this.CarGroup.Controls.Add(this.radioButtonToyota);
            this.CarGroup.Controls.Add(this.radioButtonNissan);
            this.CarGroup.Controls.Add(this.radioButtonHonda);
            this.CarGroup.Controls.Add(this.radioButtonSubaru);
            this.CarGroup.Controls.Add(this.radioButtonGaisha);
            this.CarGroup.Controls.Add(this.radioButtonSonota);
            this.CarGroup.Location = new System.Drawing.Point(75, 88);
            this.CarGroup.Name = "CarGroup";
            this.CarGroup.Size = new System.Drawing.Size(385, 41);
            this.CarGroup.TabIndex = 28;
            this.CarGroup.TabStop = false;
            this.CarGroup.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 677);
            this.Controls.Add(this.CarGroup);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btFix);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCarData);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateDate);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.CarGroup.ResumeLayout(false);
            this.CarGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker CreateDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonToyota;
        private System.Windows.Forms.RadioButton radioButtonNissan;
        private System.Windows.Forms.RadioButton radioButtonHonda;
        private System.Windows.Forms.RadioButton radioButtonSubaru;
        private System.Windows.Forms.RadioButton radioButtonGaisha;
        private System.Windows.Forms.RadioButton radioButtonSonota;
        private System.Windows.Forms.ComboBox CarName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Report;
        private System.Windows.Forms.DataGridView dgvCarData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.GroupBox CarGroup;
    }
}

