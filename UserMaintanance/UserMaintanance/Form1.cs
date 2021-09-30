﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintanance.Entities;

namespace UserMaintanance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            labelFirstName.Text = Resource1.FirstName;
            labelLastname.Text = Resource1.LastName;
            buttonAdd.Text = Resource1.Add;
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FirstName = textBoxFirst.Text,
                LastName = textBoxLast.Text
            };
            users.Add(u);
        }
    }
}
