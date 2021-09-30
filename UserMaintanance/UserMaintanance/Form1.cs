using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            
            labelFullName.Text = Resource1.FullName;
            buttonAdd.Text = Resource1.Add;
            buttonfileadd.Text = Resource1.FileAdd;
            
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                
                FullName = textBoxFullName.Text
            };
            users.Add(u);
            textBoxFullName.Clear();
        }

        private void buttonfileadd_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sf.FilterIndex = 2;
            sf.DefaultExt = "txt";

            try
            {
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sf.FileName))
                    {
                        foreach (var item in users)
                        {
                            sw.Write("ID: ");
                            sw.Write(item.ID);
                            sw.Write("Teljes név:");
                            sw.Write(item.FullName);
                            sw.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
