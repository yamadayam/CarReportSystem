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
        }

        private void btAdd_Click(object sender, EventArgs e) {
            CarReport obj = new CarReport
            {
                CreateDate = CreateDate.Value,
                Author = Author.Text,
                Name = Name.Text,
                Report = Report.Text,
                Picture = Picture.Image
            };
        }
    }
}
