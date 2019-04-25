//Kozyriev Dmitry 2019-04-24 WMAD Jr b
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class btnSortArray : Form
    {
        ArrayList message = new ArrayList();
        bool reverse = true;
        public btnSortArray()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            message.Add("I");
            message.Add("love");
            message.Add("programming");
            message.Add("so");
            message.Add("much");

        }


        private void btnShowMsg_Click(object sender, EventArgs e)
        {

            {
                lblMessage.Text = string.Empty;
                string display = "";
                foreach (string item in message)
                {
                    display += item + " ";
                }
                lblMessage.Text = display;
                reverse = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSecondPos.Text != string.Empty && reverse == true)
            {
                string addWord = txtSecondPos.Text.Trim().ToString();
                message.Insert(1, addWord + " ");
            }

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            reverse = false;
            lblMessage.Text = "";

            message.Reverse();
            foreach (string item in message)
            {
                lblMessage.Text += item + " ";
            }
            message.Reverse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.RemoveAt(1);
            txtSecondPos.Focus();
        }

    }
}
