
namespace ArchParametrisation
{
    partial class FormArchParametrisation
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxMirroredParameter = new System.Windows.Forms.TextBox();
            this.txtbxMirroredText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbxActivateMirrored = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbxOpeningsAreaParam = new System.Windows.Forms.TextBox();
            this.txtbxOpeningHeightParam = new System.Windows.Forms.TextBox();
            this.txtbxOpeningWidthParam = new System.Windows.Forms.TextBox();
            this.chkbxActivateOpeningsArea = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkboxRoomFinishingSequenceNumbers = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxWallNumbers = new System.Windows.Forms.TextBox();
            this.txtbxFinishingRoomNumberParam = new System.Windows.Forms.TextBox();
            this.txtbxFloorNumbers = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxFlatNumber = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RommName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCoeff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomIsLiving = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkbxActivateFlatography = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbxAreaCoeff = new System.Windows.Forms.TextBox();
            this.txtbxRoomCount = new System.Windows.Forms.TextBox();
            this.txtbxFlatLivingArea = new System.Windows.Forms.TextBox();
            this.txtbxFlatSumArea = new System.Windows.Forms.TextBox();
            this.txtbxFlatArea = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chxbxRoomNumberToFinishing = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkbxFloorsIncludeInFinishing = new System.Windows.Forms.CheckBox();
            this.txtbxIsLivingParam = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(378, 923);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(297, 923);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbxMirroredParameter);
            this.groupBox1.Controls.Add(this.txtbxMirroredText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkbxActivateMirrored);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отзеркаленные элементы";
            // 
            // txtbxMirroredParameter
            // 
            this.txtbxMirroredParameter.Location = new System.Drawing.Point(227, 42);
            this.txtbxMirroredParameter.Name = "txtbxMirroredParameter";
            this.txtbxMirroredParameter.Size = new System.Drawing.Size(208, 20);
            this.txtbxMirroredParameter.TabIndex = 3;
            this.txtbxMirroredParameter.Text = "Комментарии";
            // 
            // txtbxMirroredText
            // 
            this.txtbxMirroredText.Location = new System.Drawing.Point(90, 42);
            this.txtbxMirroredText.Name = "txtbxMirroredText";
            this.txtbxMirroredText.Size = new System.Drawing.Size(57, 20);
            this.txtbxMirroredText.TabIndex = 3;
            this.txtbxMirroredText.Text = "Л";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Будут обработаны все экземпляры семейств со свойством Mirrored = true";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "в параметр:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вписать текст:";
            // 
            // chkbxActivateMirrored
            // 
            this.chkbxActivateMirrored.AutoSize = true;
            this.chkbxActivateMirrored.Checked = true;
            this.chkbxActivateMirrored.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxActivateMirrored.Location = new System.Drawing.Point(6, 19);
            this.chkbxActivateMirrored.Name = "chkbxActivateMirrored";
            this.chkbxActivateMirrored.Size = new System.Drawing.Size(97, 17);
            this.chkbxActivateMirrored.TabIndex = 2;
            this.chkbxActivateMirrored.Text = "Активировать";
            this.chkbxActivateMirrored.UseVisualStyleBackColor = true;
            this.chkbxActivateMirrored.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbxOpeningsAreaParam);
            this.groupBox2.Controls.Add(this.txtbxOpeningHeightParam);
            this.groupBox2.Controls.Add(this.txtbxOpeningWidthParam);
            this.groupBox2.Controls.Add(this.chkbxActivateOpeningsArea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Площадь проёмов";
            // 
            // txtbxOpeningsAreaParam
            // 
            this.txtbxOpeningsAreaParam.Location = new System.Drawing.Point(227, 65);
            this.txtbxOpeningsAreaParam.Name = "txtbxOpeningsAreaParam";
            this.txtbxOpeningsAreaParam.Size = new System.Drawing.Size(208, 20);
            this.txtbxOpeningsAreaParam.TabIndex = 3;
            this.txtbxOpeningsAreaParam.Text = "АР_ПлощадьПроёмов";
            // 
            // txtbxOpeningHeightParam
            // 
            this.txtbxOpeningHeightParam.Location = new System.Drawing.Point(329, 39);
            this.txtbxOpeningHeightParam.Name = "txtbxOpeningHeightParam";
            this.txtbxOpeningHeightParam.Size = new System.Drawing.Size(106, 20);
            this.txtbxOpeningHeightParam.TabIndex = 3;
            this.txtbxOpeningHeightParam.Text = "Высота";
            // 
            // txtbxOpeningWidthParam
            // 
            this.txtbxOpeningWidthParam.Location = new System.Drawing.Point(154, 39);
            this.txtbxOpeningWidthParam.Name = "txtbxOpeningWidthParam";
            this.txtbxOpeningWidthParam.Size = new System.Drawing.Size(105, 20);
            this.txtbxOpeningWidthParam.TabIndex = 3;
            this.txtbxOpeningWidthParam.Text = "Ширина";
            // 
            // chkbxActivateOpeningsArea
            // 
            this.chkbxActivateOpeningsArea.AutoSize = true;
            this.chkbxActivateOpeningsArea.Checked = true;
            this.chkbxActivateOpeningsArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxActivateOpeningsArea.Location = new System.Drawing.Point(6, 19);
            this.chkbxActivateOpeningsArea.Name = "chkbxActivateOpeningsArea";
            this.chkbxActivateOpeningsArea.Size = new System.Drawing.Size(97, 17);
            this.chkbxActivateOpeningsArea.TabIndex = 0;
            this.chkbxActivateOpeningsArea.Text = "Активировать";
            this.chkbxActivateOpeningsArea.UseVisualStyleBackColor = true;
            this.chkbxActivateOpeningsArea.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Будут найдены проёмы (окна/двери) в стенах, ограничивающих помещение, и площадь п" +
    "роёмов будет вписана в соответствующий параметр в помещении.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "и высоты:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Параметр для прощади проёмов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Параметр ширины проёма:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkbxFloorsIncludeInFinishing);
            this.groupBox3.Controls.Add(this.chkboxRoomFinishingSequenceNumbers);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtbxWallNumbers);
            this.groupBox3.Controls.Add(this.txtbxFloorNumbers);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 148);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Номера помещений по типу отделки";
            // 
            // chkboxRoomFinishingSequenceNumbers
            // 
            this.chkboxRoomFinishingSequenceNumbers.AutoSize = true;
            this.chkboxRoomFinishingSequenceNumbers.Checked = true;
            this.chkboxRoomFinishingSequenceNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxRoomFinishingSequenceNumbers.Location = new System.Drawing.Point(6, 19);
            this.chkboxRoomFinishingSequenceNumbers.Name = "chkboxRoomFinishingSequenceNumbers";
            this.chkboxRoomFinishingSequenceNumbers.Size = new System.Drawing.Size(97, 17);
            this.chkboxRoomFinishingSequenceNumbers.TabIndex = 4;
            this.chkboxRoomFinishingSequenceNumbers.Text = "Активировать";
            this.chkboxRoomFinishingSequenceNumbers.UseVisualStyleBackColor = true;
            this.chkboxRoomFinishingSequenceNumbers.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(426, 35);
            this.label8.TabIndex = 2;
            this.label8.Text = "В каждое помещение будут прописаны номера помещений, имеющих тот же тип отделки.";
            // 
            // txtbxWallNumbers
            // 
            this.txtbxWallNumbers.Location = new System.Drawing.Point(227, 65);
            this.txtbxWallNumbers.Name = "txtbxWallNumbers";
            this.txtbxWallNumbers.Size = new System.Drawing.Size(208, 20);
            this.txtbxWallNumbers.TabIndex = 3;
            this.txtbxWallNumbers.Text = "АР_НомераПоТипуСтен";
            // 
            // txtbxFinishingRoomNumberParam
            // 
            this.txtbxFinishingRoomNumberParam.Location = new System.Drawing.Point(227, 39);
            this.txtbxFinishingRoomNumberParam.Name = "txtbxFinishingRoomNumberParam";
            this.txtbxFinishingRoomNumberParam.Size = new System.Drawing.Size(208, 20);
            this.txtbxFinishingRoomNumberParam.TabIndex = 3;
            this.txtbxFinishingRoomNumberParam.Text = "АР_НомерПомещения";
            // 
            // txtbxFloorNumbers
            // 
            this.txtbxFloorNumbers.Location = new System.Drawing.Point(227, 39);
            this.txtbxFloorNumbers.Name = "txtbxFloorNumbers";
            this.txtbxFloorNumbers.Size = new System.Drawing.Size(208, 20);
            this.txtbxFloorNumbers.TabIndex = 3;
            this.txtbxFloorNumbers.Text = "АР_НомераПоТипуПола";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Перечисление номеров по типу отделки:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 42);
            this.label19.Margin = new System.Windows.Forms.Padding(3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Параметр номера помещения:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Перечисление номеров по типу пола:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Параметр номера квартиры:";
            // 
            // txtbxFlatNumber
            // 
            this.txtbxFlatNumber.Location = new System.Drawing.Point(227, 39);
            this.txtbxFlatNumber.Name = "txtbxFlatNumber";
            this.txtbxFlatNumber.Size = new System.Drawing.Size(208, 20);
            this.txtbxFlatNumber.TabIndex = 3;
            this.txtbxFlatNumber.Text = "АР_НомерКвартиры";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.chkbxActivateFlatography);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtbxIsLivingParam);
            this.groupBox4.Controls.Add(this.txtbxAreaCoeff);
            this.groupBox4.Controls.Add(this.txtbxRoomCount);
            this.groupBox4.Controls.Add(this.txtbxFlatLivingArea);
            this.groupBox4.Controls.Add(this.txtbxFlatSumArea);
            this.groupBox4.Controls.Add(this.txtbxFlatArea);
            this.groupBox4.Controls.Add(this.txtbxFlatNumber);
            this.groupBox4.Location = new System.Drawing.Point(12, 506);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(441, 411);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Квартирография";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RommName,
            this.RoomCoeff,
            this.RoomIsLiving});
            this.dataGridView1.Location = new System.Drawing.Point(6, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(429, 162);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.EnabledChanged += new System.EventHandler(this.dataGridView1_EnabledChanged);
            // 
            // RommName
            // 
            this.RommName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RommName.HeaderText = "Имя помещения";
            this.RommName.Name = "RommName";
            this.RommName.ReadOnly = true;
            // 
            // RoomCoeff
            // 
            this.RoomCoeff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomCoeff.FillWeight = 50F;
            this.RoomCoeff.HeaderText = "Коэффициент площади";
            this.RoomCoeff.Name = "RoomCoeff";
            // 
            // RoomIsLiving
            // 
            this.RoomIsLiving.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomIsLiving.FillWeight = 30F;
            this.RoomIsLiving.HeaderText = "Жилое";
            this.RoomIsLiving.Name = "RoomIsLiving";
            // 
            // chkbxActivateFlatography
            // 
            this.chkbxActivateFlatography.AutoSize = true;
            this.chkbxActivateFlatography.Checked = true;
            this.chkbxActivateFlatography.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxActivateFlatography.Location = new System.Drawing.Point(6, 19);
            this.chkbxActivateFlatography.Name = "chkbxActivateFlatography";
            this.chkbxActivateFlatography.Size = new System.Drawing.Size(97, 17);
            this.chkbxActivateFlatography.TabIndex = 0;
            this.chkbxActivateFlatography.Text = "Активировать";
            this.chkbxActivateFlatography.UseVisualStyleBackColor = true;
            this.chkbxActivateFlatography.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 224);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Данные помещений:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 172);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Параметр коэффициента площади:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 146);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Параметр для количества комнат:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 120);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Площадь квартиры жилая:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 94);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Общая площадь квартиры:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Параметр площади квартиры:";
            // 
            // txtbxAreaCoeff
            // 
            this.txtbxAreaCoeff.Location = new System.Drawing.Point(227, 169);
            this.txtbxAreaCoeff.Name = "txtbxAreaCoeff";
            this.txtbxAreaCoeff.Size = new System.Drawing.Size(208, 20);
            this.txtbxAreaCoeff.TabIndex = 3;
            this.txtbxAreaCoeff.Text = "АР_КоэффПлощади";
            // 
            // txtbxRoomCount
            // 
            this.txtbxRoomCount.Location = new System.Drawing.Point(227, 143);
            this.txtbxRoomCount.Name = "txtbxRoomCount";
            this.txtbxRoomCount.Size = new System.Drawing.Size(208, 20);
            this.txtbxRoomCount.TabIndex = 3;
            this.txtbxRoomCount.Text = "АР_КолвоКомнат";
            // 
            // txtbxFlatLivingArea
            // 
            this.txtbxFlatLivingArea.Location = new System.Drawing.Point(227, 117);
            this.txtbxFlatLivingArea.Name = "txtbxFlatLivingArea";
            this.txtbxFlatLivingArea.Size = new System.Drawing.Size(208, 20);
            this.txtbxFlatLivingArea.TabIndex = 3;
            this.txtbxFlatLivingArea.Text = "АР_ПлощадьКвартирыЖилая";
            // 
            // txtbxFlatSumArea
            // 
            this.txtbxFlatSumArea.Location = new System.Drawing.Point(227, 91);
            this.txtbxFlatSumArea.Name = "txtbxFlatSumArea";
            this.txtbxFlatSumArea.Size = new System.Drawing.Size(208, 20);
            this.txtbxFlatSumArea.TabIndex = 3;
            this.txtbxFlatSumArea.Text = "АР_ПлощадьКвартирыОбщая";
            // 
            // txtbxFlatArea
            // 
            this.txtbxFlatArea.Location = new System.Drawing.Point(227, 65);
            this.txtbxFlatArea.Name = "txtbxFlatArea";
            this.txtbxFlatArea.Size = new System.Drawing.Size(208, 20);
            this.txtbxFlatArea.TabIndex = 3;
            this.txtbxFlatArea.Text = "АР_ПлощадьКвартиры";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chxbxRoomNumberToFinishing);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txtbxFinishingRoomNumberParam);
            this.groupBox5.Location = new System.Drawing.Point(12, 396);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(441, 104);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Принадлежность 3D-отделки к помещениям";
            // 
            // chxbxRoomNumberToFinishing
            // 
            this.chxbxRoomNumberToFinishing.AutoSize = true;
            this.chxbxRoomNumberToFinishing.Checked = true;
            this.chxbxRoomNumberToFinishing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxbxRoomNumberToFinishing.Location = new System.Drawing.Point(6, 19);
            this.chxbxRoomNumberToFinishing.Name = "chxbxRoomNumberToFinishing";
            this.chxbxRoomNumberToFinishing.Size = new System.Drawing.Size(97, 17);
            this.chxbxRoomNumberToFinishing.TabIndex = 4;
            this.chxbxRoomNumberToFinishing.Text = "Активировать";
            this.chxbxRoomNumberToFinishing.UseVisualStyleBackColor = true;
            this.chxbxRoomNumberToFinishing.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(3, 65);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(426, 35);
            this.label20.TabIndex = 2;
            this.label20.Text = "В отделку, выполненную \"Стенами\", будет прописан номер помещения, которое они окр" +
    "ужают.";
            // 
            // chkbxFloorsIncludeInFinishing
            // 
            this.chkbxFloorsIncludeInFinishing.AutoSize = true;
            this.chkbxFloorsIncludeInFinishing.Location = new System.Drawing.Point(43, 87);
            this.chkbxFloorsIncludeInFinishing.Name = "chkbxFloorsIncludeInFinishing";
            this.chkbxFloorsIncludeInFinishing.Size = new System.Drawing.Size(163, 17);
            this.chkbxFloorsIncludeInFinishing.TabIndex = 5;
            this.chkbxFloorsIncludeInFinishing.Text = "Учитывать полы в отделке";
            this.chkbxFloorsIncludeInFinishing.UseVisualStyleBackColor = true;
            // 
            // txtbxIsLivingParam
            // 
            this.txtbxIsLivingParam.Location = new System.Drawing.Point(227, 195);
            this.txtbxIsLivingParam.Name = "txtbxIsLivingParam";
            this.txtbxIsLivingParam.Size = new System.Drawing.Size(208, 20);
            this.txtbxIsLivingParam.TabIndex = 3;
            this.txtbxIsLivingParam.Text = "Помещение жилое";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 198);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Метка жилого помещения:";
            // 
            // FormArchParametrisation
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(465, 958);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormArchParametrisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АР Параметризация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxMirroredParameter;
        private System.Windows.Forms.TextBox txtbxMirroredText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbxActivateMirrored;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbxOpeningsAreaParam;
        private System.Windows.Forms.TextBox txtbxOpeningHeightParam;
        private System.Windows.Forms.TextBox txtbxOpeningWidthParam;
        private System.Windows.Forms.CheckBox chkbxActivateOpeningsArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkboxRoomFinishingSequenceNumbers;
        private System.Windows.Forms.TextBox txtbxWallNumbers;
        private System.Windows.Forms.TextBox txtbxFloorNumbers;
        private System.Windows.Forms.TextBox txtbxFlatNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkbxActivateFlatography;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbxAreaCoeff;
        private System.Windows.Forms.TextBox txtbxRoomCount;
        private System.Windows.Forms.TextBox txtbxFlatLivingArea;
        private System.Windows.Forms.TextBox txtbxFlatSumArea;
        private System.Windows.Forms.TextBox txtbxFlatArea;
        private System.Windows.Forms.TextBox txtbxFinishingRoomNumberParam;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn RommName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCoeff;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RoomIsLiving;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chxbxRoomNumberToFinishing;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkbxFloorsIncludeInFinishing;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbxIsLivingParam;
    }
}