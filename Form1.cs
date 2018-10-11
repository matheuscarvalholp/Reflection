using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
       static Assembly testeAssembly = Assembly.LoadFile(@"C:\Users\mathe\source\repos\WindowsFormsApp5\ClassLibrary1\obj\Debug\netstandard2.0\ClassLibrary1.dll");
       static Type classe = testeAssembly.GetType("ClassLibrary1.Class1");
        object ClasseInstance = Activator.CreateInstance(classe);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
   
            
        }

        private void Somar_Click(object sender, EventArgs e)
        {
            


            object ClasseInstance = Activator.CreateInstance(classe);
            var somaa = classe.InvokeMember("Somar", BindingFlags.InvokeMethod
                | BindingFlags.Public
                | BindingFlags.Instance, null, ClasseInstance,
                new object[] {Convert.ToInt32(valor1.Text), Convert.ToInt32(valor2.Text) });
            resultado.Text = somaa.ToString();
            
        }

        private void Subtrair_Click(object sender, EventArgs e)
        {
            object ClasseInstance = Activator.CreateInstance(classe);
            var subtrairr= classe.InvokeMember("Subtrair", BindingFlags.InvokeMethod
                | BindingFlags.Public
                | BindingFlags.Instance, null, ClasseInstance,
                new object[] { Convert.ToInt32(valor1.Text), Convert.ToInt32(valor2.Text) });
            resultado.Text = subtrairr.ToString();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            object ClasseInstance = Activator.CreateInstance(classe);
            var multiplicarr = classe.InvokeMember("Multiplicar", BindingFlags.InvokeMethod
                | BindingFlags.Public
                | BindingFlags.Instance, null, ClasseInstance,
                new object[] { Convert.ToInt32(valor1.Text), Convert.ToInt32(valor2.Text) });
            resultado.Text = multiplicarr.ToString();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            object ClasseInstance = Activator.CreateInstance(classe);
            var dividirr = classe.InvokeMember("Dividir", BindingFlags.InvokeMethod
                | BindingFlags.Public
                | BindingFlags.Instance, null, ClasseInstance,
                new object[] { Convert.ToInt32(valor1.Text), Convert.ToInt32(valor2.Text) });
            resultado.Text = dividirr.ToString();
        }
    }
}
