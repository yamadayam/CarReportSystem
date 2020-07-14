namespace CarReportSystem {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label makerLabel;
            System.Windows.Forms.Label carNameLabel;
            System.Windows.Forms.Label reportLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateDate = new System.Windows.Forms.DateTimePicker();
            this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202014DataSet = new CarReportSystem.infosys202014DataSet();
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
            this.carReportTableAdapter = new CarReportSystem.infosys202014DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202014DataSetTableAdapters.TableAdapterManager();
            this.carReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvCarData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.makerTextBox = new System.Windows.Forms.TextBox();
            this.carNameTextBox = new System.Windows.Forms.TextBox();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            makerLabel = new System.Windows.Forms.Label();
            carNameLabel = new System.Windows.Forms.Label();
            reportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202014DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.CarGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingNavigator)).BeginInit();
            this.carReportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(903, 165);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(16, 12);
            idLabel.TabIndex = 29;
            idLabel.Text = "id:";
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(903, 191);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(69, 12);
            createDateLabel.TabIndex = 31;
            createDateLabel.Text = "Create Date:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(903, 215);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(41, 12);
            authorLabel.TabIndex = 33;
            authorLabel.Text = "Author:";
            // 
            // makerLabel
            // 
            makerLabel.AutoSize = true;
            makerLabel.Location = new System.Drawing.Point(903, 240);
            makerLabel.Name = "makerLabel";
            makerLabel.Size = new System.Drawing.Size(38, 12);
            makerLabel.TabIndex = 35;
            makerLabel.Text = "Maker:";
            // 
            // carNameLabel
            // 
            carNameLabel.AutoSize = true;
            carNameLabel.Location = new System.Drawing.Point(903, 265);
            carNameLabel.Name = "carNameLabel";
            carNameLabel.Size = new System.Drawing.Size(58, 12);
            carNameLabel.TabIndex = 37;
            carNameLabel.Text = "Car Name:";
            // 
            // reportLabel
            // 
            reportLabel.AutoSize = true;
            reportLabel.Location = new System.Drawing.Point(903, 290);
            reportLabel.Name = "reportLabel";
            reportLabel.Size = new System.Drawing.Size(41, 12);
            reportLabel.TabIndex = 39;
            reportLabel.Text = "Report:";
            // 
            // CreateDate
            // 
            this.CreateDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "CreateDate", true));
            this.CreateDate.Location = new System.Drawing.Point(92, 83);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(200, 19);
            this.CreateDate.TabIndex = 0;
            this.CreateDate.Value = new System.DateTime(2020, 7, 7, 14, 57, 7, 0);
            // 
            // carReportBindingSource
            // 
            this.carReportBindingSource.DataMember = "CarReport";
            this.carReportBindingSource.DataSource = this.infosys202014DataSet;
            // 
            // infosys202014DataSet
            // 
            this.infosys202014DataSet.DataSetName = "infosys202014DataSet";
            this.infosys202014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日付";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "記録者";
            // 
            // Author
            // 
            this.Author.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Author", true));
            this.Author.FormattingEnabled = true;
            this.Author.Location = new System.Drawing.Point(92, 131);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(121, 20);
            this.Author.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "メーカー";
            // 
            // radioButtonToyota
            // 
            this.radioButtonToyota.AutoSize = true;
            this.radioButtonToyota.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.carReportBindingSource, "Maker", true));
            this.radioButtonToyota.Location = new System.Drawing.Point(16, 18);
            this.radioButtonToyota.Name = "radioButtonToyota";
            this.radioButtonToyota.Size = new System.Drawing.Size(47, 16);
            this.radioButtonToyota.TabIndex = 5;
            this.radioButtonToyota.TabStop = true;
            this.radioButtonToyota.Text = "トヨタ";
            this.radioButtonToyota.UseVisualStyleBackColor = true;
            // 
            // radioButtonNissan
            // 
            this.radioButtonNissan.AutoSize = true;
            this.radioButtonNissan.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.carReportBindingSource, "Maker", true));
            this.radioButtonNissan.Location = new System.Drawing.Point(70, 18);
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
            this.radioButtonHonda.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.carReportBindingSource, "Maker", true));
            this.radioButtonHonda.Location = new System.Drawing.Point(123, 18);
            this.radioButtonHonda.Name = "radioButtonHonda";
            this.radioButtonHonda.Size = new System.Drawing.Size(51, 16);
            this.radioButtonHonda.TabIndex = 7;
            this.radioButtonHonda.TabStop = true;
            this.radioButtonHonda.Text = "ホンダ";
            this.radioButtonHonda.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubaru
            // 
            this.radioButtonSubaru.AutoSize = true;
            this.radioButtonSubaru.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.carReportBindingSource, "Maker", true));
            this.radioButtonSubaru.Location = new System.Drawing.Point(180, 18);
            this.radioButtonSubaru.Name = "radioButtonSubaru";
            this.radioButtonSubaru.Size = new System.Drawing.Size(52, 16);
            this.radioButtonSubaru.TabIndex = 8;
            this.radioButtonSubaru.TabStop = true;
            this.radioButtonSubaru.Text = "スバル";
            this.radioButtonSubaru.UseVisualStyleBackColor = true;
            // 
            // radioButtonGaisha
            // 
            this.radioButtonGaisha.AutoSize = true;
            this.radioButtonGaisha.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.carReportBindingSource, "Maker", true));
            this.radioButtonGaisha.Location = new System.Drawing.Point(238, 18);
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
            this.radioButtonSonota.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.carReportBindingSource, "Maker", true));
            this.radioButtonSonota.Location = new System.Drawing.Point(291, 18);
            this.radioButtonSonota.Name = "radioButtonSonota";
            this.radioButtonSonota.Size = new System.Drawing.Size(54, 16);
            this.radioButtonSonota.TabIndex = 10;
            this.radioButtonSonota.TabStop = true;
            this.radioButtonSonota.Text = "その他";
            this.radioButtonSonota.UseVisualStyleBackColor = true;
            // 
            // CarName
            // 
            this.CarName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "CarName", true));
            this.CarName.FormattingEnabled = true;
            this.CarName.Location = new System.Drawing.Point(92, 204);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(121, 20);
            this.CarName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "車名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "レポート：";
            // 
            // Report
            // 
            this.Report.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Report", true));
            this.Report.Location = new System.Drawing.Point(96, 263);
            this.Report.Multiline = true;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(456, 174);
            this.Report.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "記事一覧";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(27, 488);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(58, 29);
            this.btOpen.TabIndex = 17;
            this.btOpen.Text = "接続";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(29, 544);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(56, 26);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "画像：";
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(661, 127);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 23);
            this.btImageOpen.TabIndex = 21;
            this.btImageOpen.Text = "開く";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageDelete
            // 
            this.btImageDelete.Enabled = false;
            this.btImageDelete.Location = new System.Drawing.Point(768, 127);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 23);
            this.btImageDelete.TabIndex = 22;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(581, 414);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 23;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFix
            // 
            this.btFix.Enabled = false;
            this.btFix.Location = new System.Drawing.Point(675, 414);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(75, 23);
            this.btFix.TabIndex = 24;
            this.btFix.Text = "修正";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(768, 414);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 25;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(783, 744);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(75, 23);
            this.btEnd.TabIndex = 26;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // Picture
            // 
            this.Picture.AccessibleName = "";
            this.Picture.BackColor = System.Drawing.Color.Aqua;
            this.Picture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.carReportBindingSource, "Picture", true));
            this.Picture.Location = new System.Drawing.Point(581, 157);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(262, 229);
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
            this.CarGroup.Location = new System.Drawing.Point(92, 157);
            this.CarGroup.Name = "CarGroup";
            this.CarGroup.Size = new System.Drawing.Size(385, 41);
            this.CarGroup.TabIndex = 28;
            this.CarGroup.TabStop = false;
            this.CarGroup.Text = "groupBox1";
            // 
            // carReportTableAdapter
            // 
            this.carReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202014DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carReportBindingNavigator
            // 
            this.carReportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carReportBindingNavigator.BindingSource = this.carReportBindingSource;
            this.carReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carReportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carReportBindingNavigatorSaveItem});
            this.carReportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carReportBindingNavigator.Name = "carReportBindingNavigator";
            this.carReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carReportBindingNavigator.Size = new System.Drawing.Size(1306, 25);
            this.carReportBindingNavigator.TabIndex = 29;
            this.carReportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carReportBindingNavigatorSaveItem
            // 
            this.carReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carReportBindingNavigatorSaveItem.Image")));
            this.carReportBindingNavigatorSaveItem.Name = "carReportBindingNavigatorSaveItem";
            this.carReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carReportBindingNavigatorSaveItem.Text = "データの保存";
            this.carReportBindingNavigatorSaveItem.Click += new System.EventHandler(this.carReportBindingNavigatorSaveItem_Click);
            // 
            // dgvCarData
            // 
            this.dgvCarData.AutoGenerateColumns = false;
            this.dgvCarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.dgvCarData.DataSource = this.carReportBindingSource;
            this.dgvCarData.Location = new System.Drawing.Point(92, 476);
            this.dgvCarData.MultiSelect = false;
            this.dgvCarData.Name = "dgvCarData";
            this.dgvCarData.RowTemplate.Height = 21;
            this.dgvCarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarData.Size = new System.Drawing.Size(761, 251);
            this.dgvCarData.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreateDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(978, 162);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 19);
            this.idTextBox.TabIndex = 30;
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carReportBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Location = new System.Drawing.Point(978, 187);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.createDateDateTimePicker.TabIndex = 32;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(978, 212);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(200, 19);
            this.authorTextBox.TabIndex = 34;
            // 
            // makerTextBox
            // 
            this.makerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Maker", true));
            this.makerTextBox.Location = new System.Drawing.Point(978, 237);
            this.makerTextBox.Name = "makerTextBox";
            this.makerTextBox.Size = new System.Drawing.Size(200, 19);
            this.makerTextBox.TabIndex = 36;
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "CarName", true));
            this.carNameTextBox.Location = new System.Drawing.Point(978, 262);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.carNameTextBox.TabIndex = 38;
            // 
            // reportTextBox
            // 
            this.reportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReportBindingSource, "Report", true));
            this.reportTextBox.Location = new System.Drawing.Point(978, 287);
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(200, 19);
            this.reportTextBox.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 787);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(createDateLabel);
            this.Controls.Add(this.createDateDateTimePicker);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(makerLabel);
            this.Controls.Add(this.makerTextBox);
            this.Controls.Add(carNameLabel);
            this.Controls.Add(this.carNameTextBox);
            this.Controls.Add(reportLabel);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.dgvCarData);
            this.Controls.Add(this.carReportBindingNavigator);
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
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateDate);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202014DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.CarGroup.ResumeLayout(false);
            this.CarGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingNavigator)).EndInit();
            this.carReportBindingNavigator.ResumeLayout(false);
            this.carReportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarData)).EndInit();
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
        private infosys202014DataSet infosys202014DataSet;
        private System.Windows.Forms.BindingSource carReportBindingSource;
        private infosys202014DataSetTableAdapters.CarReportTableAdapter carReportTableAdapter;
        private infosys202014DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carReportBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carReportBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvCarData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox makerTextBox;
        private System.Windows.Forms.TextBox carNameTextBox;
        private System.Windows.Forms.TextBox reportTextBox;
    }
}

