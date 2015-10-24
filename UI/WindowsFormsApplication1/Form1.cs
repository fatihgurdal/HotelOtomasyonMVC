using System;
using System.Windows.Forms;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.IoC;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private readonly IServiceStudent _serviceStudent;

        public Form1(IServiceStudent serviceStudent)
        {
            _serviceStudent = serviceStudent;
            InitializeComponent();
        }

        //IServiceBase interface' inin hangi class ile calistigi resolve ediliyor.
        public Form1()
            : this(DependencyContainer.Current.Resolve<IServiceStudent>())
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.Firstname = textBox1.Text;
            student.Lastname = textBox2.Text;

            _serviceStudent.Insert(student);

            Clear();
            GetData();
        }

        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        void GetData()
        {
            dataGridView1.DataSource = _serviceStudent.GetAll();
        }

        private void btnIdyeGoreGetir_Click(object sender, EventArgs e)
        {
            var st = _serviceStudent.GetById((int)numericUpDown1.Value);
            if (st == null)
                MessageBox.Show("Kayıt yok");
            else
                MessageBox.Show(st.Firstname + " " + st.Lastname);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var st = _serviceStudent.GetById((int)numericUpDown1.Value);
            if (st == null)
                MessageBox.Show("Kayıt yok");
            else
              _serviceStudent.Delete(st);

            GetData();
        }
    }
}
