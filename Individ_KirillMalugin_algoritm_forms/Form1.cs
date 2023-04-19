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
            try
            {
                queue.Clear();
                listBox1.Items.Clear();
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string namefile = openFileDialog1.FileName;
                    int count = File.ReadAllText(namefile).Length;
                    if (count>0)
                    {
                       
                        listBox1.Items.Clear();
                        string[] st = File.ReadAllLines(namefile);
                        for (int i = 0; i < st.Length; i++)
                        {
                            if (int.Parse(st[i]) < 0)
                                queue.Enqueue(int.Parse(st[i]));
                            else listBox1.Items.Add(st[i]);
                        }
                        foreach (int lines in queue)
                        {
                            listBox1.Items.Add(lines);
                        }
                    }
                    else MessageBox.Show("Найден пустой файл", "Сообщение", MessageBoxButtons.OK);

                }
                else MessageBox.Show("Не был выбран файл", "Сообщение", MessageBoxButtons.OK);
            }
            catch { MessageBox.Show("Выбран некорректный файл", "Сообщение", MessageBoxButtons.OK);}
            
        }
    }
}
