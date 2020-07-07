using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> _Cars = new BindingList<CarReport>();
        
        public Form1() {
            InitializeComponent();
            dgvCarData.DataSource = _Cars;
        }

        private void btAdd_Click(object sender, EventArgs e) {

            CarReport obj = new CarReport
            {
                CreateDate = CreateDate.Value,
                Author = Author.Text,
                Maker = radiobt(),
                Name = Name.Text,
                Report = Report.Text,
                Picture = Picture.Image
            };

            _Cars.Insert(0,obj);

            dgvCarData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //次の入力に備えて各項目をクリア
            //inputItemAllClear();
            //initButtons();
            dgvCarData.ClearSelection();
        }

        private void radioButtonToyota_CheckedChanged(object sender, EventArgs e) {

        }
        private CarMaker radiobt() {
            if (radioButtonToyota.Checked==true)
            {
                return CarMaker.トヨタ;
            } else if (radioButtonNissan.Checked==true)
            {
                return CarMaker.日産;
            } else if (radioButtonHonda.Checked==true)
            {
                return CarMaker.ホンダ;
            } else if (radioButtonSubaru.Checked==true)
            {
                return CarMaker.スバル;
            } else if (radioButtonGaisha.Checked==true)
            {
                return CarMaker.外車;
            } else if (radioButtonSonota.Checked==true)
            {
                return CarMaker.その他;
            }
            return default;
        }

        private void btFix_Click(object sender, EventArgs e) {
            CarReport selectedCar = _Cars[dgvCarData.CurrentRow.Index];
            selectedCar.CreateDate = CreateDate.Value;
            selectedCar.Author = Author.Text;
            //selectedCar.
        }
    }
        
        
    
}
