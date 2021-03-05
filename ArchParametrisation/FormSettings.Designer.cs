
namespace ArchParametrisation
{
    partial class FormSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableNumbersOfFinishings = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableNumbersOfFloorTypes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumbersOfFinishingsParamName = new System.Windows.Forms.TextBox();
            this.textBoxNumbersOfFloorTypesParamName = new System.Windows.Forms.TextBox();
            this.textBoxOpeningsAreaParamName = new System.Windows.Forms.TextBox();
            this.checkBoxEnableOpeningsArea = new System.Windows.Forms.CheckBox();
            this.textBoxMirroredParamName = new System.Windows.Forms.TextBox();
            this.checkBoxEnableMirrored = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewFlatParameters = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxEnableFlatography = new System.Windows.Forms.CheckBox();
            this.dataGridViewRoomTypes = new System.Windows.Forms.DataGridView();
            this.rooomInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlatParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooomInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxEnableNumbersOfFinishings);
            this.groupBox1.Controls.Add(this.checkBoxEnableNumbersOfFloorTypes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNumbersOfFinishingsParamName);
            this.groupBox1.Controls.Add(this.textBoxNumbersOfFloorTypesParamName);
            this.groupBox1.Controls.Add(this.textBoxOpeningsAreaParamName);
            this.groupBox1.Controls.Add(this.checkBoxEnableOpeningsArea);
            this.groupBox1.Controls.Add(this.textBoxMirroredParamName);
            this.groupBox1.Controls.Add(this.checkBoxEnableMirrored);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отделка";
            // 
            // checkBoxEnableNumbersOfFinishings
            // 
            this.checkBoxEnableNumbersOfFinishings.AutoSize = true;
            this.checkBoxEnableNumbersOfFinishings.Location = new System.Drawing.Point(6, 152);
            this.checkBoxEnableNumbersOfFinishings.Name = "checkBoxEnableNumbersOfFinishings";
            this.checkBoxEnableNumbersOfFinishings.Size = new System.Drawing.Size(356, 17);
            this.checkBoxEnableNumbersOfFinishings.TabIndex = 5;
            this.checkBoxEnableNumbersOfFinishings.Text = "Перечисление номеров помещений по типу отделки в параметр:";
            this.checkBoxEnableNumbersOfFinishings.UseVisualStyleBackColor = true;
            this.checkBoxEnableNumbersOfFinishings.CheckedChanged += new System.EventHandler(this.checkBoxEnableNumbersOfFinishings_CheckedChanged);
            // 
            // checkBoxEnableNumbersOfFloorTypes
            // 
            this.checkBoxEnableNumbersOfFloorTypes.AutoSize = true;
            this.checkBoxEnableNumbersOfFloorTypes.Location = new System.Drawing.Point(6, 104);
            this.checkBoxEnableNumbersOfFloorTypes.Name = "checkBoxEnableNumbersOfFloorTypes";
            this.checkBoxEnableNumbersOfFloorTypes.Size = new System.Drawing.Size(339, 17);
            this.checkBoxEnableNumbersOfFloorTypes.TabIndex = 2;
            this.checkBoxEnableNumbersOfFloorTypes.Text = "Перечисление номеров помещений по типу пола в параметр:";
            this.checkBoxEnableNumbersOfFloorTypes.UseVisualStyleBackColor = true;
            this.checkBoxEnableNumbersOfFloorTypes.CheckedChanged += new System.EventHandler(this.checkBoxEnableNumbersOfFloorTypes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Группировка по параметру \"Отделка пола\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Обрабатываются Двери и Окна, параметры Ширина и Высота";
            // 
            // textBoxNumbersOfFinishingsParamName
            // 
            this.textBoxNumbersOfFinishingsParamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumbersOfFinishingsParamName.Enabled = false;
            this.textBoxNumbersOfFinishingsParamName.Location = new System.Drawing.Point(378, 150);
            this.textBoxNumbersOfFinishingsParamName.Name = "textBoxNumbersOfFinishingsParamName";
            this.textBoxNumbersOfFinishingsParamName.Size = new System.Drawing.Size(176, 20);
            this.textBoxNumbersOfFinishingsParamName.TabIndex = 3;
            // 
            // textBoxNumbersOfFloorTypesParamName
            // 
            this.textBoxNumbersOfFloorTypesParamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumbersOfFloorTypesParamName.Enabled = false;
            this.textBoxNumbersOfFloorTypesParamName.Location = new System.Drawing.Point(378, 102);
            this.textBoxNumbersOfFloorTypesParamName.Name = "textBoxNumbersOfFloorTypesParamName";
            this.textBoxNumbersOfFloorTypesParamName.Size = new System.Drawing.Size(176, 20);
            this.textBoxNumbersOfFloorTypesParamName.TabIndex = 3;
            // 
            // textBoxOpeningsAreaParamName
            // 
            this.textBoxOpeningsAreaParamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpeningsAreaParamName.Enabled = false;
            this.textBoxOpeningsAreaParamName.Location = new System.Drawing.Point(378, 56);
            this.textBoxOpeningsAreaParamName.Name = "textBoxOpeningsAreaParamName";
            this.textBoxOpeningsAreaParamName.Size = new System.Drawing.Size(176, 20);
            this.textBoxOpeningsAreaParamName.TabIndex = 3;
            // 
            // checkBoxEnableOpeningsArea
            // 
            this.checkBoxEnableOpeningsArea.AutoSize = true;
            this.checkBoxEnableOpeningsArea.Location = new System.Drawing.Point(6, 58);
            this.checkBoxEnableOpeningsArea.Name = "checkBoxEnableOpeningsArea";
            this.checkBoxEnableOpeningsArea.Size = new System.Drawing.Size(310, 17);
            this.checkBoxEnableOpeningsArea.TabIndex = 2;
            this.checkBoxEnableOpeningsArea.Text = "Заполнить площадь проёмов в помещение в параметр:";
            this.checkBoxEnableOpeningsArea.UseVisualStyleBackColor = true;
            this.checkBoxEnableOpeningsArea.CheckedChanged += new System.EventHandler(this.checkBoxEnableOpeningsArea_CheckedChanged);
            // 
            // textBoxMirroredParamName
            // 
            this.textBoxMirroredParamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMirroredParamName.Enabled = false;
            this.textBoxMirroredParamName.Location = new System.Drawing.Point(378, 17);
            this.textBoxMirroredParamName.Name = "textBoxMirroredParamName";
            this.textBoxMirroredParamName.Size = new System.Drawing.Size(176, 20);
            this.textBoxMirroredParamName.TabIndex = 1;
            // 
            // checkBoxEnableMirrored
            // 
            this.checkBoxEnableMirrored.AutoSize = true;
            this.checkBoxEnableMirrored.Location = new System.Drawing.Point(6, 19);
            this.checkBoxEnableMirrored.Name = "checkBoxEnableMirrored";
            this.checkBoxEnableMirrored.Size = new System.Drawing.Size(313, 17);
            this.checkBoxEnableMirrored.TabIndex = 0;
            this.checkBoxEnableMirrored.Text = "Вписать \"Л\" в отзеркаленные окна и двери в параметр:";
            this.checkBoxEnableMirrored.UseVisualStyleBackColor = true;
            this.checkBoxEnableMirrored.CheckedChanged += new System.EventHandler(this.checkBoxEnableMirrored_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewFlatParameters);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBoxEnableFlatography);
            this.groupBox2.Controls.Add(this.dataGridViewRoomTypes);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 515);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Квартирография";
            // 
            // dataGridViewFlatParameters
            // 
            this.dataGridViewFlatParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlatParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlatParameters.Location = new System.Drawing.Point(6, 59);
            this.dataGridViewFlatParameters.Name = "dataGridViewFlatParameters";
            this.dataGridViewFlatParameters.RowHeadersVisible = false;
            this.dataGridViewFlatParameters.Size = new System.Drawing.Size(548, 197);
            this.dataGridViewFlatParameters.TabIndex = 5;
            this.dataGridViewFlatParameters.EnabledChanged += new System.EventHandler(this.dataGridView_EnabledChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Данные помещений:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Используемые параметры:";
            // 
            // checkBoxEnableFlatography
            // 
            this.checkBoxEnableFlatography.AutoSize = true;
            this.checkBoxEnableFlatography.Location = new System.Drawing.Point(6, 19);
            this.checkBoxEnableFlatography.Name = "checkBoxEnableFlatography";
            this.checkBoxEnableFlatography.Size = new System.Drawing.Size(97, 17);
            this.checkBoxEnableFlatography.TabIndex = 2;
            this.checkBoxEnableFlatography.Text = "Активировать";
            this.checkBoxEnableFlatography.UseVisualStyleBackColor = true;
            this.checkBoxEnableFlatography.CheckedChanged += new System.EventHandler(this.checkBoxEnableFlatography_CheckedChanged);
            // 
            // dataGridViewRoomTypes
            // 
            this.dataGridViewRoomTypes.AllowUserToAddRows = false;
            this.dataGridViewRoomTypes.AllowUserToDeleteRows = false;
            this.dataGridViewRoomTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRoomTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomTypes.Location = new System.Drawing.Point(6, 292);
            this.dataGridViewRoomTypes.Name = "dataGridViewRoomTypes";
            this.dataGridViewRoomTypes.RowHeadersVisible = false;
            this.dataGridViewRoomTypes.Size = new System.Drawing.Size(548, 217);
            this.dataGridViewRoomTypes.TabIndex = 0;
            this.dataGridViewRoomTypes.EnabledChanged += new System.EventHandler(this.dataGridView_EnabledChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(497, 721);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(416, 721);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(584, 756);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 1000);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АР Параметризация - Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlatParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooomInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOpeningsAreaParamName;
        private System.Windows.Forms.CheckBox checkBoxEnableOpeningsArea;
        private System.Windows.Forms.TextBox textBoxMirroredParamName;
        private System.Windows.Forms.CheckBox checkBoxEnableMirrored;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxEnableNumbersOfFinishings;
        private System.Windows.Forms.CheckBox checkBoxEnableNumbersOfFloorTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumbersOfFinishingsParamName;
        private System.Windows.Forms.TextBox textBoxNumbersOfFloorTypesParamName;
        private System.Windows.Forms.DataGridView dataGridViewRoomTypes;
        private System.Windows.Forms.CheckBox checkBoxEnableFlatography;
        private System.Windows.Forms.BindingSource rooomInfoBindingSource;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewFlatParameters;
    }
}