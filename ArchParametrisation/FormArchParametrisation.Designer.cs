
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
            buttonCancel = new System.Windows.Forms.Button();
            buttonOk = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtbxMirroredParameter = new System.Windows.Forms.TextBox();
            txtbxMirroredText = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            chkbxActivateMirrored = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            chkBoxCalculateOneRoomOpenings = new System.Windows.Forms.CheckBox();
            txtbxOpeningsAreaParam = new System.Windows.Forms.TextBox();
            txtbxOpeningHeightParam = new System.Windows.Forms.TextBox();
            txtbxOpeningWidthParam = new System.Windows.Forms.TextBox();
            chkbxActivateOpeningsArea = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            checkBoxUseRoomNames = new System.Windows.Forms.CheckBox();
            chkbxFloorsIncludeInFinishing = new System.Windows.Forms.CheckBox();
            chkboxRoomFinishingSequenceNumbers = new System.Windows.Forms.CheckBox();
            label8 = new System.Windows.Forms.Label();
            txtbxWallNumbers = new System.Windows.Forms.TextBox();
            txtbxFloorNumbers = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtbxFinishingRoomNumberParam = new System.Windows.Forms.TextBox();
            label19 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            txtbxFlatNumber = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            RommName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoomCoeff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RoomIsLiving = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            chkbxActivateFlatography = new System.Windows.Forms.CheckBox();
            label18 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            txtbxIsLivingParam = new System.Windows.Forms.TextBox();
            txtbxAreaCoeff = new System.Windows.Forms.TextBox();
            txtbxRoomCount = new System.Windows.Forms.TextBox();
            txtbxFlatLivingArea = new System.Windows.Forms.TextBox();
            txtbxFlatSumArea = new System.Windows.Forms.TextBox();
            txtbxFlatArea = new System.Windows.Forms.TextBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            chxbxRoomNumberToFinishing = new System.Windows.Forms.CheckBox();
            label20 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.Location = new System.Drawing.Point(441, 1067);
            buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(88, 27);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonOk.Location = new System.Drawing.Point(346, 1067);
            buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(88, 27);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtbxMirroredParameter);
            groupBox1.Controls.Add(txtbxMirroredText);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chkbxActivateMirrored);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(514, 103);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Отзеркаленные элементы";
            // 
            // txtbxMirroredParameter
            // 
            txtbxMirroredParameter.Location = new System.Drawing.Point(265, 48);
            txtbxMirroredParameter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxMirroredParameter.Name = "txtbxMirroredParameter";
            txtbxMirroredParameter.Size = new System.Drawing.Size(242, 23);
            txtbxMirroredParameter.TabIndex = 3;
            txtbxMirroredParameter.Text = "Комментарии";
            // 
            // txtbxMirroredText
            // 
            txtbxMirroredText.Location = new System.Drawing.Point(105, 48);
            txtbxMirroredText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxMirroredText.Name = "txtbxMirroredText";
            txtbxMirroredText.Size = new System.Drawing.Size(66, 23);
            txtbxMirroredText.TabIndex = 3;
            txtbxMirroredText.Text = "Л";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 78);
            label3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(416, 15);
            label3.TabIndex = 2;
            label3.Text = "Будут обработаны все экземпляры семейств со свойством Mirrored = true";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(178, 52);
            label2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "в параметр:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 52);
            label1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Вписать текст:";
            // 
            // chkbxActivateMirrored
            // 
            chkbxActivateMirrored.AutoSize = true;
            chkbxActivateMirrored.Checked = true;
            chkbxActivateMirrored.CheckState = System.Windows.Forms.CheckState.Checked;
            chkbxActivateMirrored.Location = new System.Drawing.Point(7, 22);
            chkbxActivateMirrored.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkbxActivateMirrored.Name = "chkbxActivateMirrored";
            chkbxActivateMirrored.Size = new System.Drawing.Size(102, 19);
            chkbxActivateMirrored.TabIndex = 2;
            chkbxActivateMirrored.Text = "Активировать";
            chkbxActivateMirrored.UseVisualStyleBackColor = true;
            chkbxActivateMirrored.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkBoxCalculateOneRoomOpenings);
            groupBox2.Controls.Add(txtbxOpeningsAreaParam);
            groupBox2.Controls.Add(txtbxOpeningHeightParam);
            groupBox2.Controls.Add(txtbxOpeningWidthParam);
            groupBox2.Controls.Add(chkbxActivateOpeningsArea);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new System.Drawing.Point(14, 123);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(514, 152);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Площадь проёмов";
            // 
            // chkBoxCalculateOneRoomOpenings
            // 
            chkBoxCalculateOneRoomOpenings.AutoSize = true;
            chkBoxCalculateOneRoomOpenings.Location = new System.Drawing.Point(181, 20);
            chkBoxCalculateOneRoomOpenings.Name = "chkBoxCalculateOneRoomOpenings";
            chkBoxCalculateOneRoomOpenings.Size = new System.Drawing.Size(306, 19);
            chkBoxCalculateOneRoomOpenings.TabIndex = 4;
            chkBoxCalculateOneRoomOpenings.Text = "Учитывать проемы в пределах одного помещения";
            chkBoxCalculateOneRoomOpenings.UseVisualStyleBackColor = true;
            // 
            // txtbxOpeningsAreaParam
            // 
            txtbxOpeningsAreaParam.Location = new System.Drawing.Point(265, 75);
            txtbxOpeningsAreaParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxOpeningsAreaParam.Name = "txtbxOpeningsAreaParam";
            txtbxOpeningsAreaParam.Size = new System.Drawing.Size(242, 23);
            txtbxOpeningsAreaParam.TabIndex = 3;
            txtbxOpeningsAreaParam.Text = "АР_ПлощадьПроёмов";
            // 
            // txtbxOpeningHeightParam
            // 
            txtbxOpeningHeightParam.Location = new System.Drawing.Point(384, 45);
            txtbxOpeningHeightParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxOpeningHeightParam.Name = "txtbxOpeningHeightParam";
            txtbxOpeningHeightParam.Size = new System.Drawing.Size(123, 23);
            txtbxOpeningHeightParam.TabIndex = 3;
            txtbxOpeningHeightParam.Text = "Высота";
            // 
            // txtbxOpeningWidthParam
            // 
            txtbxOpeningWidthParam.Location = new System.Drawing.Point(180, 45);
            txtbxOpeningWidthParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxOpeningWidthParam.Name = "txtbxOpeningWidthParam";
            txtbxOpeningWidthParam.Size = new System.Drawing.Size(122, 23);
            txtbxOpeningWidthParam.TabIndex = 3;
            txtbxOpeningWidthParam.Text = "Ширина";
            // 
            // chkbxActivateOpeningsArea
            // 
            chkbxActivateOpeningsArea.AutoSize = true;
            chkbxActivateOpeningsArea.Checked = true;
            chkbxActivateOpeningsArea.CheckState = System.Windows.Forms.CheckState.Checked;
            chkbxActivateOpeningsArea.Location = new System.Drawing.Point(7, 22);
            chkbxActivateOpeningsArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkbxActivateOpeningsArea.Name = "chkbxActivateOpeningsArea";
            chkbxActivateOpeningsArea.Size = new System.Drawing.Size(102, 19);
            chkbxActivateOpeningsArea.TabIndex = 0;
            chkbxActivateOpeningsArea.Text = "Активировать";
            chkbxActivateOpeningsArea.UseVisualStyleBackColor = true;
            chkbxActivateOpeningsArea.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(4, 105);
            label4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(500, 40);
            label4.TabIndex = 2;
            label4.Text = "Будут найдены проёмы (окна/двери) в стенах, ограничивающих помещение, и площадь проёмов будет вписана в соответствующий параметр в помещении.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(309, 48);
            label6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 15);
            label6.TabIndex = 2;
            label6.Text = "и высоты:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(4, 78);
            label7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(193, 15);
            label7.TabIndex = 2;
            label7.Text = "Параметр для прощади проёмов:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(4, 48);
            label5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(161, 15);
            label5.TabIndex = 2;
            label5.Text = "Параметр ширины проёма:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxUseRoomNames);
            groupBox3.Controls.Add(chkbxFloorsIncludeInFinishing);
            groupBox3.Controls.Add(chkboxRoomFinishingSequenceNumbers);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtbxWallNumbers);
            groupBox3.Controls.Add(txtbxFloorNumbers);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new System.Drawing.Point(14, 283);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(514, 193);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Помещения по типу отделки";
            // 
            // checkBoxUseRoomNames
            // 
            checkBoxUseRoomNames.AutoSize = true;
            checkBoxUseRoomNames.Location = new System.Drawing.Point(50, 164);
            checkBoxUseRoomNames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxUseRoomNames.Name = "checkBoxUseRoomNames";
            checkBoxUseRoomNames.Size = new System.Drawing.Size(286, 19);
            checkBoxUseRoomNames.TabIndex = 5;
            checkBoxUseRoomNames.Text = "Использовать Имя помещения вместо номера";
            checkBoxUseRoomNames.UseVisualStyleBackColor = true;
            // 
            // chkbxFloorsIncludeInFinishing
            // 
            chkbxFloorsIncludeInFinishing.AutoSize = true;
            chkbxFloorsIncludeInFinishing.Location = new System.Drawing.Point(50, 100);
            chkbxFloorsIncludeInFinishing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkbxFloorsIncludeInFinishing.Name = "chkbxFloorsIncludeInFinishing";
            chkbxFloorsIncludeInFinishing.Size = new System.Drawing.Size(172, 19);
            chkbxFloorsIncludeInFinishing.TabIndex = 5;
            chkbxFloorsIncludeInFinishing.Text = "Учитывать полы в отделке";
            chkbxFloorsIncludeInFinishing.UseVisualStyleBackColor = true;
            // 
            // chkboxRoomFinishingSequenceNumbers
            // 
            chkboxRoomFinishingSequenceNumbers.AutoSize = true;
            chkboxRoomFinishingSequenceNumbers.Checked = true;
            chkboxRoomFinishingSequenceNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            chkboxRoomFinishingSequenceNumbers.Location = new System.Drawing.Point(7, 22);
            chkboxRoomFinishingSequenceNumbers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkboxRoomFinishingSequenceNumbers.Name = "chkboxRoomFinishingSequenceNumbers";
            chkboxRoomFinishingSequenceNumbers.Size = new System.Drawing.Size(102, 19);
            chkboxRoomFinishingSequenceNumbers.TabIndex = 4;
            chkboxRoomFinishingSequenceNumbers.Text = "Активировать";
            chkboxRoomFinishingSequenceNumbers.UseVisualStyleBackColor = true;
            chkboxRoomFinishingSequenceNumbers.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(4, 127);
            label8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(497, 30);
            label8.TabIndex = 2;
            label8.Text = "В каждое помещение будут прописаны номера помещений, имеющих тот же тип отделки.";
            // 
            // txtbxWallNumbers
            // 
            txtbxWallNumbers.Location = new System.Drawing.Point(265, 75);
            txtbxWallNumbers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxWallNumbers.Name = "txtbxWallNumbers";
            txtbxWallNumbers.Size = new System.Drawing.Size(242, 23);
            txtbxWallNumbers.TabIndex = 3;
            txtbxWallNumbers.Text = "АР_НомераПоТипуСтен";
            // 
            // txtbxFloorNumbers
            // 
            txtbxFloorNumbers.Location = new System.Drawing.Point(265, 45);
            txtbxFloorNumbers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxFloorNumbers.Name = "txtbxFloorNumbers";
            txtbxFloorNumbers.Size = new System.Drawing.Size(242, 23);
            txtbxFloorNumbers.TabIndex = 3;
            txtbxFloorNumbers.Text = "АР_НомераПоТипуПола";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(4, 78);
            label11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(183, 15);
            label11.TabIndex = 2;
            label11.Text = "Перечисление по типу отделки:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(4, 48);
            label10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(166, 15);
            label10.TabIndex = 2;
            label10.Text = "Перечисление по типу пола:";
            // 
            // txtbxFinishingRoomNumberParam
            // 
            txtbxFinishingRoomNumberParam.Location = new System.Drawing.Point(265, 45);
            txtbxFinishingRoomNumberParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxFinishingRoomNumberParam.Name = "txtbxFinishingRoomNumberParam";
            txtbxFinishingRoomNumberParam.Size = new System.Drawing.Size(242, 23);
            txtbxFinishingRoomNumberParam.TabIndex = 3;
            txtbxFinishingRoomNumberParam.Text = "АР_НомерПомещения";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(7, 48);
            label19.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(179, 15);
            label19.TabIndex = 2;
            label19.Text = "Параметр номера помещения:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(4, 48);
            label9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(166, 15);
            label9.TabIndex = 2;
            label9.Text = "Параметр номера квартиры:";
            // 
            // txtbxFlatNumber
            // 
            txtbxFlatNumber.Location = new System.Drawing.Point(265, 45);
            txtbxFlatNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxFlatNumber.Name = "txtbxFlatNumber";
            txtbxFlatNumber.Size = new System.Drawing.Size(242, 23);
            txtbxFlatNumber.TabIndex = 3;
            txtbxFlatNumber.Text = "АР_НомерКвартиры";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(chkbxActivateFlatography);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtbxIsLivingParam);
            groupBox4.Controls.Add(txtbxAreaCoeff);
            groupBox4.Controls.Add(txtbxRoomCount);
            groupBox4.Controls.Add(txtbxFlatLivingArea);
            groupBox4.Controls.Add(txtbxFlatSumArea);
            groupBox4.Controls.Add(txtbxFlatArea);
            groupBox4.Controls.Add(txtbxFlatNumber);
            groupBox4.Location = new System.Drawing.Point(14, 609);
            groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Size = new System.Drawing.Size(514, 451);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Квартирография";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { RommName, RoomCoeff, RoomIsLiving });
            dataGridView1.Location = new System.Drawing.Point(7, 280);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridView1.Size = new System.Drawing.Size(500, 164);
            dataGridView1.TabIndex = 4;
            dataGridView1.EnabledChanged += dataGridView1_EnabledChanged;
            // 
            // RommName
            // 
            RommName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            RommName.HeaderText = "Имя помещения";
            RommName.Name = "RommName";
            RommName.ReadOnly = true;
            // 
            // RoomCoeff
            // 
            RoomCoeff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            RoomCoeff.FillWeight = 50F;
            RoomCoeff.HeaderText = "Коэффициент площади";
            RoomCoeff.Name = "RoomCoeff";
            // 
            // RoomIsLiving
            // 
            RoomIsLiving.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            RoomIsLiving.FillWeight = 30F;
            RoomIsLiving.HeaderText = "Жилое";
            RoomIsLiving.Name = "RoomIsLiving";
            // 
            // chkbxActivateFlatography
            // 
            chkbxActivateFlatography.AutoSize = true;
            chkbxActivateFlatography.Checked = true;
            chkbxActivateFlatography.CheckState = System.Windows.Forms.CheckState.Checked;
            chkbxActivateFlatography.Location = new System.Drawing.Point(7, 22);
            chkbxActivateFlatography.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkbxActivateFlatography.Name = "chkbxActivateFlatography";
            chkbxActivateFlatography.Size = new System.Drawing.Size(102, 19);
            chkbxActivateFlatography.TabIndex = 0;
            chkbxActivateFlatography.Text = "Активировать";
            chkbxActivateFlatography.UseVisualStyleBackColor = true;
            chkbxActivateFlatography.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(4, 258);
            label18.Margin = new System.Windows.Forms.Padding(4, 12, 4, 3);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(123, 15);
            label18.TabIndex = 2;
            label18.Text = "Данные помещений:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(4, 228);
            label12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(158, 15);
            label12.TabIndex = 2;
            label12.Text = "Метка жилого помещения:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(4, 198);
            label17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(204, 15);
            label17.TabIndex = 2;
            label17.Text = "Параметр коэффициента площади:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(4, 168);
            label16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(196, 15);
            label16.TabIndex = 2;
            label16.Text = "Параметр для количества комнат:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(4, 138);
            label15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(156, 15);
            label15.TabIndex = 2;
            label15.Text = "Площадь квартиры жилая:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(4, 108);
            label14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(158, 15);
            label14.TabIndex = 2;
            label14.Text = "Общая площадь квартиры:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(4, 78);
            label13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(175, 15);
            label13.TabIndex = 2;
            label13.Text = "Параметр площади квартиры:";
            // 
            // txtbxIsLivingParam
            // 
            txtbxIsLivingParam.Location = new System.Drawing.Point(265, 225);
            txtbxIsLivingParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxIsLivingParam.Name = "txtbxIsLivingParam";
            txtbxIsLivingParam.Size = new System.Drawing.Size(242, 23);
            txtbxIsLivingParam.TabIndex = 3;
            txtbxIsLivingParam.Text = "Помещение жилое";
            // 
            // txtbxAreaCoeff
            // 
            txtbxAreaCoeff.Location = new System.Drawing.Point(265, 195);
            txtbxAreaCoeff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxAreaCoeff.Name = "txtbxAreaCoeff";
            txtbxAreaCoeff.Size = new System.Drawing.Size(242, 23);
            txtbxAreaCoeff.TabIndex = 3;
            txtbxAreaCoeff.Text = "АР_КоэффПлощади";
            // 
            // txtbxRoomCount
            // 
            txtbxRoomCount.Location = new System.Drawing.Point(265, 165);
            txtbxRoomCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxRoomCount.Name = "txtbxRoomCount";
            txtbxRoomCount.Size = new System.Drawing.Size(242, 23);
            txtbxRoomCount.TabIndex = 3;
            txtbxRoomCount.Text = "АР_КолвоКомнат";
            // 
            // txtbxFlatLivingArea
            // 
            txtbxFlatLivingArea.Location = new System.Drawing.Point(265, 135);
            txtbxFlatLivingArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxFlatLivingArea.Name = "txtbxFlatLivingArea";
            txtbxFlatLivingArea.Size = new System.Drawing.Size(242, 23);
            txtbxFlatLivingArea.TabIndex = 3;
            txtbxFlatLivingArea.Text = "АР_ПлощадьКвартирыЖилая";
            // 
            // txtbxFlatSumArea
            // 
            txtbxFlatSumArea.Location = new System.Drawing.Point(265, 105);
            txtbxFlatSumArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxFlatSumArea.Name = "txtbxFlatSumArea";
            txtbxFlatSumArea.Size = new System.Drawing.Size(242, 23);
            txtbxFlatSumArea.TabIndex = 3;
            txtbxFlatSumArea.Text = "АР_ПлощадьКвартирыОбщая";
            // 
            // txtbxFlatArea
            // 
            txtbxFlatArea.Location = new System.Drawing.Point(265, 75);
            txtbxFlatArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbxFlatArea.Name = "txtbxFlatArea";
            txtbxFlatArea.Size = new System.Drawing.Size(242, 23);
            txtbxFlatArea.TabIndex = 3;
            txtbxFlatArea.Text = "АР_ПлощадьКвартиры";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(chxbxRoomNumberToFinishing);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(txtbxFinishingRoomNumberParam);
            groupBox5.Location = new System.Drawing.Point(14, 482);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Size = new System.Drawing.Size(514, 120);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Принадлежность 3D-отделки к помещениям";
            // 
            // chxbxRoomNumberToFinishing
            // 
            chxbxRoomNumberToFinishing.AutoSize = true;
            chxbxRoomNumberToFinishing.Checked = true;
            chxbxRoomNumberToFinishing.CheckState = System.Windows.Forms.CheckState.Checked;
            chxbxRoomNumberToFinishing.Location = new System.Drawing.Point(7, 22);
            chxbxRoomNumberToFinishing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxbxRoomNumberToFinishing.Name = "chxbxRoomNumberToFinishing";
            chxbxRoomNumberToFinishing.Size = new System.Drawing.Size(102, 19);
            chxbxRoomNumberToFinishing.TabIndex = 4;
            chxbxRoomNumberToFinishing.Text = "Активировать";
            chxbxRoomNumberToFinishing.UseVisualStyleBackColor = true;
            chxbxRoomNumberToFinishing.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // label20
            // 
            label20.Location = new System.Drawing.Point(4, 75);
            label20.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(497, 40);
            label20.TabIndex = 2;
            label20.Text = "В отделку, выполненную \"Стенами\", будет прописан номер помещения, которое они окружают.";
            // 
            // FormArchParametrisation
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new System.Drawing.Size(542, 1108);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormArchParametrisation";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "АР Параметризация";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox checkBoxUseRoomNames;
        private System.Windows.Forms.CheckBox chkBoxCalculateOneRoomOpenings;
    }
}