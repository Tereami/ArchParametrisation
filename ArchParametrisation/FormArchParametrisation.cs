#region License
/*Данный код опубликован под лицензией Creative Commons Attribution-ShareAlike.
Разрешено использовать, распространять, изменять и брать данный код за основу для производных в коммерческих и
некоммерческих целях, при условии указания авторства и если производные лицензируются на тех же условиях.
Код поставляется "как есть". Автор не несет ответственности за возможные последствия использования.
Зуев Александр, 2020, все права защищены.
This code is listed under the Creative Commons Attribution-ShareAlike license.
You may use, redistribute, remix, tweak, and build upon this work non-commercially and commercially,
as long as you credit the author by linking back and license your new creations under the same terms.
This code is provided 'as is'. Author disclaims any implied warranty.
Zuev Aleksandr, 2020, all rigths reserved.*/
#endregion
#region Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace ArchParametrisation
{
    public partial class FormArchParametrisation : Form
    {
        public Settings curSettings;

        public FormArchParametrisation(Settings s)
        {
            InitializeComponent();

            curSettings = s;

            chkbxActivateMirrored.Checked = s.enableMirrored;
            txtbxMirroredText.Text = s.mirroredText;
            txtbxMirroredParameter.Text = s.mirroredParamName;

            chkbxActivateOpeningsArea.Checked = s.enableOpeningsArea;
            txtbxOpeningWidthParam.Text = s.openingsWidthParamName;
            txtbxOpeningHeightParam.Text = s.openingsHeightParamName;
            txtbxOpeningsAreaParam.Text = s.openingsAreaParamName;

            chkboxActivateRoomFinishing.Checked = s.enableNumbersOfFinishings;
            txtbxRoomNumberParam.Text = s.roomNumberParamName;
            txtbxFloorNumbers.Text = s.numbersOfFloorTypesParamName;
            txtbxWallNumbers.Text = s.numbersOfWallsParamName;
            txtbxCeilingNumbers.Text = s.numbersOfCeilingTypesParamName;

            chkbxActivateFlatography.Checked = s.enableFlatography;
            txtbxFlatNumber.Text = s.flatNumberParamName;
            txtbxFlatArea.Text = s.flatAreaParamName;
            txtbxFlatSumArea.Text = s.flatSumAreaParamName;
            txtbxFlatLivingArea.Text = s.flatLivingAreaParamName;
            txtbxRoomCount.Text = s.flatRoomsCountParamName;
            txtbxAreaCoeff.Text = s.flatRoomAreaCoeffParamName;

            foreach (RoomInfo ri in s.RoomInfos)
            {
                dataGridView1.Rows.Add(ri.Name, ri.Coeff, ri.IsLiving);
            }
        }

        private void chkbxInGroup_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox curChkBox = sender as CheckBox;
            GroupBox grbx = curChkBox.Parent as GroupBox;
            foreach (Control child in grbx.Controls)
            {
                if (child is CheckBox) continue;
                child.Enabled = curChkBox.Checked;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool someCheckboxesOn = chkbxActivateMirrored.Checked
                || chkbxActivateOpeningsArea.Checked
                || chkboxActivateRoomFinishing.Checked
                || chkbxActivateFlatography.Checked;

            if (!someCheckboxesOn)
            {
                MessageBox.Show("Не активирована ни одна функция");
                return;
            }

            curSettings.RoomInfos = new List<RoomInfo>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                DataGridViewCellCollection cells = row.Cells;

                string roomName = cells[0].Value.ToString();
                double roomCoeff = 1.0;
                string coeffString = cells[1].Value.ToString();
                bool checkCoeffPars = double.TryParse(coeffString, out roomCoeff);
                if (!checkCoeffPars)
                {
                    MessageBox.Show("Неверный коэффициент " + coeffString);
                    return;
                }
                bool isLiving = (bool)cells[2].Value;

                RoomInfo ri = new RoomInfo(roomName, roomCoeff, isLiving);
                curSettings.RoomInfos.Add(ri);
            }

            curSettings.enableMirrored = chkbxActivateMirrored.Checked;
            curSettings.mirroredText = txtbxMirroredText.Text;
            curSettings.mirroredParamName = txtbxMirroredParameter.Text;

            curSettings.enableOpeningsArea = chkbxActivateOpeningsArea.Checked;
            curSettings.openingsWidthParamName = txtbxOpeningWidthParam.Text;
            curSettings.openingsHeightParamName = txtbxOpeningHeightParam.Text;
            curSettings.openingsAreaParamName = txtbxOpeningsAreaParam.Text;

            curSettings.enableNumbersOfFinishings = chkboxActivateRoomFinishing.Checked;
            curSettings.roomNumberParamName = txtbxRoomNumberParam.Text;
            curSettings.numbersOfFloorTypesParamName = txtbxFloorNumbers.Text;
            curSettings.numbersOfWallsParamName = txtbxWallNumbers.Text;
            curSettings.numbersOfCeilingTypesParamName = txtbxCeilingNumbers.Text;

            curSettings.enableFlatography = chkbxActivateFlatography.Checked;
            curSettings.flatNumberParamName = txtbxFlatNumber.Text;
            curSettings.flatAreaParamName = txtbxFlatArea.Text;
            curSettings.flatSumAreaParamName = txtbxFlatSumArea.Text;
            curSettings.flatLivingAreaParamName = txtbxFlatLivingArea.Text;
            curSettings.flatRoomsCountParamName = txtbxRoomCount.Text;
            curSettings.flatRoomAreaCoeffParamName = txtbxAreaCoeff.Text;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dataGridView1_EnabledChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (!dgv.Enabled)
            {
                dgv.DefaultCellStyle.BackColor = SystemColors.Control;
                dgv.DefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgv.CurrentCell = null;
                dgv.ReadOnly = true;
                dgv.EnableHeadersVisualStyles = false;
            }
            else
            {
                dgv.DefaultCellStyle.BackColor = SystemColors.Window;
                dgv.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Window;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgv.ReadOnly = false;
                dgv.EnableHeadersVisualStyles = true;
            }
        }
    }
}
