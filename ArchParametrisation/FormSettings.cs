using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchParametrisation
{
    public partial class FormSettings : Form
    {
        List<RoomInfo> _rooms;
        DataTable roomTypesTable;
        DataTable roomParametersTable;

        public FormSettings(List<RoomInfo> rooms)
        {
            InitializeComponent();
            _rooms = rooms;

            roomTypesTable = new DataTable();
            roomTypesTable.Columns.Add(new DataColumn("Имя", typeof(string)));
            roomTypesTable.Columns.Add(new DataColumn("Коэффициент площади", typeof(double)));
            roomTypesTable.Columns.Add(new DataColumn("Жилое", typeof(bool)));

            foreach(RoomInfo ri in rooms)
            {
                roomTypesTable.Rows.Add(ri.Name, ri.Coeff, ri.IsLive);
            }
            dataGridViewRoomTypes.DataSource = roomTypesTable;
            dataGridViewRoomTypes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewRoomTypes.Columns[0].ReadOnly = true;
            dataGridViewRoomTypes.Enabled = checkBoxEnableFlatography.Checked;

            roomParametersTable = new DataTable();
            roomParametersTable.Columns.Add(new DataColumn("Назначение", typeof(string)));
            roomParametersTable.Columns.Add(new DataColumn("Параметр", typeof(string)));
            roomParametersTable.Rows.Add("Номер квартиры", "АР_НомерКвартиры");
            roomParametersTable.Rows.Add("Площадь квартиры", "АР_ПлощКвартиры");
            roomParametersTable.Rows.Add("Площадь квартиры общая", "АР_ПлощКвОбщая");
            roomParametersTable.Rows.Add("Площадь квартиры жилая", "АР_ПлощКвЖилая");
            roomParametersTable.Rows.Add("Количество комнат", "АР_КолвоКомнат");
            roomParametersTable.Rows.Add("Коэффициент площади", "АР_КоэффПлощади");
            dataGridViewFlatParameters.DataSource = roomParametersTable;
            dataGridViewFlatParameters.Columns[0].ReadOnly = true;
            dataGridViewFlatParameters.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFlatParameters.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFlatParameters.Enabled = checkBoxEnableFlatography.Checked;
        }

        private void checkBoxEnableMirrored_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMirroredParamName.Enabled = checkBoxEnableMirrored.Checked;
        }

        private void checkBoxEnableOpeningsArea_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOpeningsAreaParamName.Enabled = checkBoxEnableOpeningsArea.Checked;
        }

        private void checkBoxEnableNumbersOfFloorTypes_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumbersOfFloorTypesParamName.Enabled = checkBoxEnableNumbersOfFloorTypes.Checked;
        }

        private void checkBoxEnableNumbersOfFinishings_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumbersOfFinishingsParamName.Enabled = checkBoxEnableNumbersOfFinishings.Checked;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBoxEnableFlatography_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewFlatParameters.Enabled = checkBoxEnableFlatography.Checked;
            dataGridViewRoomTypes.Enabled = checkBoxEnableFlatography.Checked;
        }

        private void dataGridView_EnabledChanged(object sender, EventArgs e)
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
