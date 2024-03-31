using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using demo_webservice_csdl.webservice;

namespace demo_webservice_csdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        webservice.WebService1 websv = new webservice.WebService1();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void getdata(string cmds)
        {
            DataSet ds = new DataSet();
            ds = websv.getdata("SELECT * FROM SINHVIEN");
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            int i = 0;
            lsvdemo.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                lsvdemo.Items.Add(dr["ID"].ToString());
                lsvdemo.Items[i].SubItems.Add(dr["MSSV"].ToString());
                lsvdemo.Items[i].SubItems.Add(dr["HOTEN"].ToString());
                i++;
            }
        }

        private void btnTruyxuat_Click(object sender, EventArgs e)
        {
            getdata("");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = websv.getdata("SELECT * FROM SINHVIEN");
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                i++;
            }
            i++;
            string tb;
            int id = i;
            string mssv = txtMSSV.Text;
            string ten = txtTen.Text;
            tb = websv.excute("INSERT INTO SINHVIEN VALUES (N'"+id+"',N'"+mssv+"',N'"+ten+"')");
            if (tb == "Yes")
            {
                MessageBox.Show("Đã thêm dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                MessageBox.Show("Đã thêm dữ liệu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata("");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tb;
            string id = txtID.Text;
            tb = websv.excute("DELETE FROM SINHVIEN WHERE ID = '"+id+"'");
            if (tb == "Yes")
            {
                MessageBox.Show("Đã xóa dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã xóa dữ liệu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata("");
        }

        private void lsvdemo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem l in lsvdemo.SelectedItems)
            {
                txtID.Text = l.SubItems[0].Text;
                txtMSSV.Text = l.SubItems[1].Text;
                txtTen.Text = l.SubItems[2].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tb;
            string id = txtID.Text;
            string mssv = txtMSSV.Text;
            string ten = txtTen.Text;
            tb = websv.excute("UPDATE SINHVIEN SET MSSV = N'" + mssv + "', HOTEN = N'" + ten + "' WHERE ID = '" + id + "'");
            if (tb == "Yes")
            {
                MessageBox.Show("Đã sửa dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã sửa dữ liệu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata("");
        }
    }
}
