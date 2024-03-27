using System;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            Type T = Type.GetType(searchText);

            lstMethods.Items.Clear();
            lstProperties.Items.Clear();
            lstConstructors.Items.Clear();


            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                lstProperties.Items.Add(property);
            }

            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                lstMethods.Items.Add(method);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                lstConstructors.Items.Add(constructor);
            }
        }
    }
}
