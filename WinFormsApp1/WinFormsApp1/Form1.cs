using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate int Errorrs(int i);
        delegate string Errorrs2(string s);
        event Errorrs2? Eror;
        public string Mess(string s)
        {
            return s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Eror += Mess;
            Errorrs er = new Errorrs(Meth1);
            er += Meth3;
            er += Meth2;
            er(10);
            MessageBox.Show(Eror("Duq Ashxatacreciq Meth1 Meth2 Meth3"));
        }
        public int Meth1(int i)
        {
            textBox1.Text = (i + 1).ToString();
            return i;
        }
        public int Meth2(int i)
        {
            textBox2.Text = (i + 2).ToString();
            return i;
        }
        public int Meth3(int i)
        {
            textBox3.Text = (i + 3).ToString();
            return i;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}