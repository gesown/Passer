using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Passer
{
    public partial class Passer : Form
    {
        private string g_MerchSearch = "";
        private List<Store> g_lsMerchList = new List<Store>();
        public Passer()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_uname.Text = "UserName: ";
            lbl_pass.Text = "Password: ";
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            lb_StoreOptions.Items.Clear();
            g_MerchSearch = tb_MerchSearch.Text;
            GetMerchant();
            lb_StoreOptions.Visible = true;
            tb_Pass.Visible = false;
            tb_Uname.Visible = false;
        }

        private void GetMerchant()
        {
            MySql.Data.MySqlClient.MySqlConnection l_MerchReturnVal = null;
            MySqlDataReader l_MerchReader;
            string l_strConnection = "Server=www.cybercoupons.com;Database=CBQMaster;Uid=Primo;Pwd=@2ThisRocksPRIMO#3;Pooling=false;";
            string l_MerchSQLSearch = "select storeNames, LoginName, Password, storeNames from storemanagers where storeNames like '%" + g_MerchSearch +"%';";
            l_MerchReturnVal = new MySqlConnection(l_strConnection);
            MySqlCommand l_MerchCommand = l_MerchReturnVal.CreateCommand();
            l_MerchCommand.CommandText = l_MerchSQLSearch;
            
            try
            {
                l_MerchReturnVal.Open();
                l_MerchReader = l_MerchCommand.ExecuteReader();
                while (l_MerchReader.Read())
                {
                    Store l_TempStore = new Store(l_MerchReader.GetString("storeNames"), l_MerchReader.GetString("Password"), l_MerchReader.GetString("LoginName"));
                    g_lsMerchList.Add(l_TempStore);                    
                }
            }
            catch (Exception ex)
            {
                lbl_uname.Text = "Error: " + ex.Message;
            }

            foreach (Store store in g_lsMerchList)
            {
                lb_StoreOptions.Items.Add(store.StoreName);
            }
            lbl_uname.Visible = true;
            lbl_pass.Visible = true;


        }
        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void Tb_MerchSearch_TextChanged(object sender, EventArgs e)
        {
            lb_StoreOptions.Items.Clear();
            tb_Uname.Clear();
            tb_Pass.Clear();
            g_lsMerchList.Clear();                     
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lb_StoreOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_uname.Text = "UserName: ";
            lbl_pass.Text = "Password: ";
            //clb_StoreOptions.SetItemChecked(clb_StoreOptions.SelectedIndex, true);

            foreach (Store store in g_lsMerchList)
            {
                if (store.StoreName == lb_StoreOptions.SelectedItem.ToString())
                {
                    tb_Uname.Text = store.Uname;
                    tb_Pass.Text = store.Pswd;
                    tb_Uname.Visible = true;
                    tb_Pass.Visible = true;
                }

            }
        }
    }
    public class Store
    {
        public string StoreName { get; set; }
        public string Pswd { get; set; }
        public string Uname { get; set; }
        public Store(string name, string pass, string user)
        {
            StoreName = name;
            Pswd = pass;
            Uname = user;
        }        
    }
}
