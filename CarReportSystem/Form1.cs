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
    public partial class Form1 : Form {
        BindingList<CarReport> _Cars = new BindingList<CarReport>();

        SaveFileDialog saveFile = new SaveFileDialog();
        OpenFileDialog openFile = new OpenFileDialog();
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
                CarName = CarName.Text,
                Report = Report.Text,
                Picture = Picture.Image
            };
            setComboBoxAutor(Author.Text);
            setComboBoxCarName(CarName.Text);
            _Cars.Insert(0,obj);
            intDeta();
            radioClear();
            dgvCarData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //次の入力に備えて各項目をクリア
            inputItemAllClear();
            initButtons();
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
        private void intImgButtons() {
            if (Picture.Image==null)
            {
                btImageDelete.Enabled = false;
            } else
            {
                btImageDelete.Enabled = true;
            }
        }
        private void intDeta() {
            if (_Cars.Count > 0)
            {
                btSave.Enabled = true;
            } else
            {
                btSave.Enabled = false;
            }
        }
        private void intOpen() {
            btOpen.Enabled = true;
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
            CarReport selectedCar = _Cars[dgvCarData.CurrentRow.Index];
            
            selectedCar.CreateDate = CreateDate.Value;
            selectedCar.Author = Author.Text;
            selectedCar.Maker = radiobt();
            selectedCar.CarName = CarName.Text;
            selectedCar.Report = Report.Text;
            selectedCar.Picture = Picture.Image;
            
            dgvCarData.Refresh();
        }

        private void btDelete_Click(object sender, EventArgs e) {
            _Cars.RemoveAt(dgvCarData.CurrentRow.Index);
            initButtons();
            inputItemAllClear();
            intDeta();
            dgvCarData.ClearSelection();
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                Picture.Image = Image.FromFile(openFileDialog.FileName);
                Picture.SizeMode = PictureBoxSizeMode.StretchImage;
                intImgButtons();
            }
            
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            if (Picture.Image == null)
                return;

            if (MessageBox.Show("削除してよいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                Picture.Image = null;
            }
        }

        private void btEnd_Click(object sender, EventArgs e) {
            Application.Exit();
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
                        throw;
                    }
                }
                intOpen();
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
                using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        _Cars = (BindingList<CarReport>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dgvCarData.DataSource = _Cars;
                        //選択されている箇所を各コントロールへ表示
                        dgvCarData_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }
        private void dgvCarData_Click(object sender, EventArgs e) {
            if (dgvCarData.CurrentRow == null)
                return;
            //選択したレコードを取り出す
            //データグリッドビューで選択した行のインデックスを元に
            //BindingListのデータを取得する
            CarReport selectedCar = _Cars[dgvCarData.CurrentRow.Index];
            CreateDate.Value = selectedCar.CreateDate;
            Author.Text = selectedCar.Author;
            CarName.Text = selectedCar.CarName;
            Report.Text = selectedCar.Report;
            Picture.Image = selectedCar.Picture;
        }
    }
}
