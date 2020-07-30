using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class pbImage : Form {
        BindingList<CarReport> _Cars = new BindingList<CarReport>();
        SaveFileDialog saveFile = new SaveFileDialog();
        OpenFileDialog openFile = new OpenFileDialog();
        public pbImage() {
            InitializeComponent();
            //dgvCarData.DataSource = _Cars;
        }

        private void btAdd_Click(object sender, EventArgs e) {

            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202014DataSet);
            //次の入力に備えて各項目をクリア

            //initButtons();
            dgvCarData.ClearSelection();
        }
        private void inputItemAllClear() {
            Author.Text = "";
            CarName.Text = "";
            Report.Text = "";
            Picture.Image = null;

        }

        private void initButtons() {
            if (_Cars.Count > 0)
            {
                btFix.Enabled = true;
                btDelete.Enabled = true;
            } else
            {
                btFix.Enabled = false;
                btDelete.Enabled = false;
            }
        }
        private void setComboBoxAutor(string autor) {
            if (!Author.Items.Contains(autor) )
            {
                Author.Items.Add(autor);
            }
        }
        private void setComboBoxCarName(string name) {
            if (!CarName.Items.Contains(name))
            {
                CarName.Items.Add(name);
            }
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
        private void radioClear() {
            radioButtonToyota.Checked = false;
            radioButtonSubaru.Checked = false;
            radioButtonGaisha.Checked = false;
            radioButtonHonda.Checked = false;
            radioButtonSonota.Checked = false;
            radioButtonNissan.Checked = false;
        }
        private void btFix_Click(object sender, EventArgs e) {
            dgvCarData.CurrentRow.Cells[1].Value = CreateDate.Value;
            dgvCarData.CurrentRow.Cells[2].Value = Author.Text;
            serch();
            dgvCarData.CurrentRow.Cells[4].Value = CarName.Text;
            dgvCarData.CurrentRow.Cells[5].Value = Report.Text;
            if (Picture.Image == null)
            {
                dgvCarData.CurrentRow.Cells[6].Value = null;
            } else
            {
                dgvCarData.CurrentRow.Cells[6].Value = ImageToByteArray(Picture.Image);
            }

            //データベース更新（反映）
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202014DataSet);
        }
        public void serch() {
            if (radioButtonToyota.Checked==true)
            {
                dgvCarData.CurrentRow.Cells[3].Value = "トヨタ";
            } else if (radioButtonSubaru.Checked==true)
            {
                dgvCarData.CurrentRow.Cells[3].Value = "スバル";
            } else if (radioButtonNissan.Checked==true)
            {
                dgvCarData.CurrentRow.Cells[3].Value = "日産";
            } else if (radioButtonHonda.Checked==true)
            {
                dgvCarData.CurrentRow.Cells[3].Value = "ホンダ";
            } else if (radioButtonGaisha.Checked==true)
            {
                dgvCarData.CurrentRow.Cells[3].Value = "外車";
            } else
            {
                dgvCarData.CurrentRow.Cells[3].Value = "その他";
            }
        }

        private void btDelete_Click(object sender, EventArgs e) {
            
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                Picture.Image = Image.FromFile(openFileDialog.FileName);
                Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            if (Picture.Image != null)
            {
                Picture.Image.Dispose();
                Picture.Image = null;
            }
        }

        private void btEnd_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202014DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.carReportTableAdapter.Fill(this.infosys202014DataSet.CarReport);
            dgvCarData.Columns[0].Visible = false;

        }

        private void btSave_Click(object sender, EventArgs e) {
            if (saveFile.ShowDialog()==DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs=new FileStream(saveFile.FileName, FileMode.Create))
                {
                    try
                    {
                        formatter.Serialize(fs, _Cars);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        
                    }
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            this.carReportTableAdapter.Fill(this.infosys202014DataSet.CarReport);
            dgvCarData.Columns[0].Visible = false;
        }

        
        private void dgvCarData_Click(object sender, EventArgs e) {
            //var test = dgvCarData.CurrentRow.Cells[4].Value;
            if (dgvCarData.CurrentRow.Cells[4].Value.ToString()=="トヨタ")
            {
                radioButtonToyota.Checked = true;
            }
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            dgvCarData.CurrentRow.Cells[2].Value = Author.Text;

            //データベース更新（反映）
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202014DataSet);

        }

        private void dgvCarData_Click_1(object sender, EventArgs e) {
            CreateDate.Value = (DateTime)dgvCarData.CurrentRow.Cells[1].Value;
            Author.Text = dgvCarData.CurrentRow.Cells[2].Value.ToString();
            string maker = dgvCarData.CurrentRow.Cells[3].Value.ToString();
            setMakerButtonSet((string)maker);
            CarName.Text = dgvCarData.CurrentRow.Cells[4].Value.ToString();
            Report.Text = dgvCarData.CurrentRow.Cells[5].Value.ToString();
            try
            {
                if (dgvCarData.CurrentRow.Cells[6].Value != null)
                {
                    Picture.Image = ByteArrayToImage((byte[])dgvCarData.CurrentRow.Cells[6].Value);
                }                
            }
            catch (InvalidCastException)
            {
                Picture.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void setMakerButtonSet(string maker) {
            switch (maker)
            {
                case "トヨタ":
                    radioButtonToyota.Checked = true;
                    break;
                case "日産":
                    radioButtonNissan.Checked = true;
                    break;
                case "ホンダ":
                    radioButtonHonda.Checked = true;
                    break;
                case "スバル":
                    radioButtonSubaru.Checked = true;
                    break;
                case "外車":
                    radioButtonGaisha.Checked = true;
                    break;
                default:
                    radioButtonSonota.Checked = true;
                    break;
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        private void btSearchExe_Click(object sender, EventArgs e) {
            
            if (tbSearchCarMaker.Text=="" && tbSearchCarName.Text=="")
            {
                this.carReportTableAdapter.FillByCarDateCar(this.infosys202014DataSet.CarReport,
                    tbSearchCarDate.Text);
            } else
            {
                this.carReportTableAdapter.FillByCarMakerName(this.infosys202014DataSet.CarReport,
                    tbSearchCarMaker.Text, tbSearchCarName.Text);
            }
        }
    }
}
