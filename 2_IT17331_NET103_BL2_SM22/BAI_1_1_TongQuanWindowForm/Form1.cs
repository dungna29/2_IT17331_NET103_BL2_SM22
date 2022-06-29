using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_1_TongQuanWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblHienThi.Text = "Chào mừng các bạn";
            LoadNamSinh();
        }

        void LoadNamSinh()
        {
            int temp = 1600;
            for (int i = 0; i < 2023-1600; i++)
            {
                cbx_NamSinh.Items.Add(temp);
                temp++;
            }

            //cbx_NamSinh.SelectedIndex = 0;//Hiển thị giá trị index 0 lên giao diện
            //cbx_NamSinh.SelectedIndex = cbx_NamSinh.FindStringExact("2019");
            //Hiển thị được năm 2022 không dùng 2 cách tren
            cbx_NamSinh.SelectedIndex = 2022 - 1600;
        }

        private void btn_ClickVaoDay_MouseDown(object sender, MouseEventArgs e)
        {
            lblHienThi.Text = "Bạn đang bấm chuột..";
        }

        private void btn_ClickVaoDay_MouseUp(object sender, MouseEventArgs e)
        {
            lblHienThi.Text = "Kết thúc bấm";
        }

        private void btn_ClickVaoDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Chào bạn {txt_Name.Text} đến với C#3");
        }
    }

    #region Cách đặt tên các control
    /*
     *Assembly                                asm
Boolean                                 bln
Button                                  btn
Char                                    ch
CheckBox                                cbx
ComboBox                                cmb
Container                               ctr
DataColumn                              dcol
DataGrid                                dgrid
DataGridDateTimePickerColumn            dgdtpc
DataGridTableStyle                      dgts
DataGridTextBoxColumn                   dgtbc
DataReader                              dreader
DataRow                                 drow
DataSet                                 dset
DataTable                               dtable
DateTime                                date
Dialog                                  dialog
DialogResult                            dr
Double                                  dbl
Exception                               ex
GroupBox                                gbx
HashTable                               htbl
ImageList                               iml
Integer                                 int
Label                                   lbl
ListBox                                 lbx
ListView                                lv
MarshallByRefObject                     rmt
Mainmenu                                mm
MenuItem                                mi
MDI-Frame                               frame
MDI-Sheet                               sheet
NumericUpDown                           nud
Panel                                   pnl
PictureBox                              pbx
RadioButton                             rbtn
SDI-Form                                form
SqlCommand                              sqlcom
SqlCommandBuilder                       sqlcomb
SqlConnection                           sqlcon
SqlDataAdapter                          sqlda
StatusBar                               stb
String                                  str
StringBuilder                           strb
TabControl                              tabctrl
TabPage                                 tabpage
TextBox                                 tbx
ToolBar                                 tbr
ToolBarButton                           tbb
Timer                                   tmr
UserControl                             usr
WindowsPrincipal                        wpl
     */


    #endregion
}
