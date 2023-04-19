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

namespace Individ_KirillMalugin_algoritm_forms
{
    public partial class Form1 : Form
    {
        Queue<int> queue = new Queue<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queue.Clear();
            listBox1.Items.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\Users\\305-3\\Desktop\\Kirill Malugin\\Individ_KirillMalugin_algoritm_forms";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string namefile = openFileDialog1.FileName;
                listBox1.Items.Clear();
                string[] st = File.ReadAllLines(namefile);
                for (int i = 0; i < st.Length; i++)
                {
                    if (int.Parse(st[i])<0)
                   queue.Enqueue(int.Parse(st[i]));
                    else listBox1.Items.Add(st[i]);
                }
                foreach (int lines in queue)
                {
                    listBox1.Items.Add(lines);
                }
            }
            
        }
    }
}
