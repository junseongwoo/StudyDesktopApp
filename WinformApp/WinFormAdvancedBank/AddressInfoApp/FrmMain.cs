﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressInfoApp
{
    public partial class FrmMain : Form
    {
        String connString = "Data Source=127.0.0.1;Initial Catalog=PMS;Persist Security Info=True;" +
                        "User ID=sa;Password=mssql_p@ssw0rd!";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result > 0)
            {
                MessageBox.Show("초기화를 하십시오.");
                return;
            }

            if (string.IsNullOrEmpty(TxtFullName.Text) || string.IsNullOrEmpty(TxtMobile.Text))
            {
                MessageBox.Show("값을 입력하세요.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"INSERT INTO dbo.Address " +
                    $"( FullName, " +
                    $"  Mobile, " +
                    $"  Addr, " +
                    $"  RegId, " +
                    $"  RegDate) " +
                    $" VALUES " +
                    $"( '{TxtFullName.Text}' ," +
                    $"  '{TxtMobile.Text.Replace("-", "")}' ," +
                    $"  '{TxtAddr.Text}' ," +
                    $"  'admin' ," +
                    $"  GETDATE() ); ";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("입력 성공!");
                }
                else
                {
                    MessageBox.Show("입력 실패!");
                }
            }

            RefreshData();
            ClearInput();
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("데이터를 선택하세요");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"UPDATE Address " +
                    $" SET " +
                    $" FullName = '{TxtFullName.Text}', " +
                    $" Mobile = '{TxtMobile.Text.Replace("-", "")}', " +
                    $" Addr = '{TxtAddr.Text}', " +
                    $" ModId = 'admin', " +
                    $" ModDate = GETDATE()" +
                    $" WHERE Idx = {result} ";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("수정 성공!");
                }
                else
                {
                    MessageBox.Show("수정 실패!");
                }
            }

            RefreshData();
            ClearInput();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("삭제하려면 데이터를 선택하세요");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"DELETE FROM Address WHERE idx = {result}";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제 성공!");
                }
                else
                {
                    MessageBox.Show("삭제 실패!");
                }
            }

            RefreshData();
            ClearInput();
        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 13 = 엔터키
            {
                TxtMobile.Focus();
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtAddr.Focus();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshData();
            ClearInput();
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT Idx " +
                               "     , FullName " +
                               "     , Mobile " +
                               "     , Addr " +
                               "  FROM  Address ";

                // SqlCommand, SQLDataReader or Object 사용방법 1 
                // SqlDataAdapter, Dataset

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DgvAddress.DataSource = ds.Tables[0];
            }
        }

        private void ClearInput()
        {
            TxtIdx.Text = TxtFullName.Text = TxtMobile.Text = TxtAddr.Text = "";
        }

        private void DgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selData = DgvAddress.Rows[e.RowIndex].Cells;

            TxtIdx.Text = selData[0].Value.ToString();
            TxtFullName.Text = selData[1].Value.ToString();
            TxtMobile.Text = selData[2].Value.ToString();
            TxtAddr.Text = selData[3].Value.ToString();
        }
    }
}
