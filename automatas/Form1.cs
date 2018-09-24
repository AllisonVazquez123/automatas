using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automatas
{
    public partial class Form1 : Form
    {
        Stack<char> pila = new Stack<char>();
        Stack<char> palabras = new Stack<char>();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
            pb5.Visible = false;
            pb6.Visible = false;
        }

        private void cblenguaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckop1.Checked = false;
            ckop2.Checked = false;
            ckop3.Checked = false;
            ckop4.Checked = false;
            ckop5.Checked = false;
            ckop6.Checked = false;
            if (cblenguaje.SelectedIndex == 0)
            {
                pb1.Visible = true;
            }
            else
            {
                pb1.Visible = false;
            }
            if (cblenguaje.SelectedIndex == 1)
            {
                pb2.Visible = true;
            }
            else
            {
                pb2.Visible = false;
            }
            if (cblenguaje.SelectedIndex == 2)
            {
                pb3.Visible = true;
            }
            else
            {
                pb3.Visible = false;
            }
            if (cblenguaje.SelectedIndex == 3)
            {
                pb4.Visible = true;
            }
            else
            {
                pb4.Visible = false;
            }
            if (cblenguaje.SelectedIndex == 4)
            {
                pb5.Visible = true;
            }
            else
            {
                pb5.Visible = false;
            }
            if (cblenguaje.SelectedIndex == 5)
            {
                pb6.Visible = true;
            }
            else
            {
                pb6.Visible = false;
            }
        }

        private bool automata1(string palabra)
        {
            bool resultado = false; 
            if (palabra.Length > 0)
                for (int i = palabra.Length - 1; i >= 0; i--)
                    palabras.Push(palabra[i]);

            pila.Push('Z');
            try
            {
                if (palabras.Peek().Equals('a') && pila.Peek().Equals('Z'))
                {
                    palabras.Pop();
                    pila.Pop();
                    pila.Push('A');
                }

                while (palabras.Peek().Equals('a') && pila.Peek().Equals('A'))
                {
                    palabras.Pop();
                    pila.Pop();
                    pila.Push('A');
                    pila.Push('A');
                }

                if (palabras.Peek().Equals('b') && pila.Peek().Equals('A'))
                {
                    palabras.Pop();
                    pila.Pop();
                }

                while (palabras.Peek().Equals('b') && pila.Peek().Equals('A'))
                {
                    palabras.Pop();
                    pila.Pop();
                }
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                resultado = pila.Count == 0 && palabras.Count == 0 ? true : false;
            }

            pila.Clear();
            palabras.Clear();

            return resultado;
        }

        private bool automata2(string palabra)
        {
            bool resultado = false;
            if (palabra.Length > 0)
                for (int i = palabra.Length - 1; i >= 0; i--)
                    palabras.Push(palabra[i]);

            pila.Push('Z');
            try
            {
                if (palabras.Count > 0)
                {
                    if (palabras.Peek().Equals('a') && pila.Peek().Equals('Z'))
                    {
                        palabras.Pop();
                        pila.Pop();
                        pila.Push('A');
                    }

                    while (palabras.Peek().Equals('a') && pila.Peek().Equals('A'))
                    {
                        palabras.Pop();
                        pila.Pop();
                        pila.Push('A');
                        pila.Push('A');
                    }

                    if (palabras.Peek().Equals('b') && pila.Peek().Equals('A'))
                    {
                        palabras.Pop();
                        pila.Pop();
                    }

                    while (palabras.Peek().Equals('b') && pila.Peek().Equals('A'))
                    {
                        palabras.Pop();
                        pila.Pop();
                    }
                }
                else
                {
                    pila.Pop();
                }
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                resultado = pila.Count == 0 && palabras.Count == 0 ? true : false;
            }

            pila.Clear();
            palabras.Clear();

            return resultado;
        }

        private bool automata3(string palabra)
        {
            bool resultado = false;
            for (int i = palabra.Length - 1; i >= 0; i--)
                palabras.Push(palabra[i]);

            pila.Push('Z');

            try
            {
                if (palabras.Peek().Equals('a') && pila.Peek().Equals('Z'))
                {
                    palabras.Pop();
                    pila.Pop();
                    pila.Push('A');
                    pila.Push('A');
                }

                while (palabras.Peek().Equals('a') && pila.Peek().Equals('A'))
                {
                    palabras.Pop();
                    pila.Pop();
                    pila.Push('A');
                    pila.Push('A');
                    pila.Push('A');
                }

                if (palabras.Peek().Equals('b') && pila.Peek().Equals('A'))
                {
                    palabras.Pop();
                    pila.Pop();
                }

                while (palabras.Peek().Equals('b') && pila.Peek().Equals('A'))
                {
                    palabras.Pop();
                    pila.Pop();
                }
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                resultado = pila.Count == 0 && palabras.Count == 0 ? true : false;
            }
            pila.Clear();
            palabras.Clear();

            return resultado;
        }

        private bool automata4(string palabra)
        {
            bool resultado =false;
            for (int i = palabra.Length - 1; i >= 0; i--)
                palabras.Push(palabra[i]);

            pila.Push('Z');

            try
            {
                if (palabras.Peek().Equals('a') && pila.Peek().Equals('Z'))
                {
                    palabras.Pop();
                    pila.Pop();
                    pila.Push('A');
                }

                while (palabras.Count > 1 && palabras.Peek().Equals('a'))
                {
                    if (pila.Peek().Equals('A'))
                    {
                        palabras.Pop();
                        pila.Pop();
                        pila.Push('B');
                    }
                    else if (pila.Peek().Equals('B'))
                    {
                        palabras.Pop();
                        pila.Pop();
                        pila.Push('B');
                        pila.Push('A');
                    }
                }

                if (pila.Count > 0 && palabras.Count > 0 && palabras.Peek().Equals('b') && pila.Peek().Equals('Z'))
                {
                    palabras.Pop();
                    pila.Pop();
                }

                if (pila.Count > 0 && palabras.Count > 0 && palabras.Peek().Equals('b') && pila.Peek().Equals('B'))
                {
                    palabras.Pop();
                    pila.Pop();
                }

                while (palabras.Count == 0 && pila.Peek().Equals('B'))
                {
                    pila.Pop();
                }

            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                resultado = pila.Count == 0 && palabras.Count == 0 ? true : false;
            }
            pila.Clear();
            palabras.Clear();

            return resultado;
        }

        private bool automata5(string palabra)
        {
            bool resultado = false;
            for (int i = palabra.Length - 1; i >= 0; i--)
                palabras.Push(palabra[i]);

            pila.Push('Z');

            try
            {
                if (palabras.Peek().Equals('a') && pila.Peek().Equals('Z'))
                {
                    palabras.Pop();
                    pila.Pop();
                    pila.Push('A');
                }

                while (palabras.Count > 0 && palabras.Peek().Equals('a'))
                {
                    if (pila.Peek().Equals('A'))
                    {
                        palabras.Pop();
                        pila.Pop();
                        pila.Push('B');
                    }
                    else if (pila.Peek().Equals('B'))
                    {
                        palabras.Pop();
                        pila.Pop();
                        pila.Push('B');
                        pila.Push('A');
                    }
                }

                if (pila.Count > 0 && palabras.Count > 0 && palabras.Peek().Equals('b') && pila.Peek().Equals('B'))
                {
                    palabras.Pop();
                    pila.Pop();
                }

                while (palabras.Peek().Equals('b') && pila.Peek().Equals('B'))
                {
                    palabras.Pop();
                    pila.Pop();
                }
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                resultado = pila.Count == 0 && palabras.Count == 0 ? true : false;
            }
            pila.Clear();
            palabras.Clear();

            return resultado;
        }

        private bool automata6(string palabra)
        {
            bool resultado = false;
            for (int i = palabra.Length - 1; i >= 0; i--)
                palabras.Push(palabra[i]);

            pila.Push('Z');
            try
            {
                if (palabras.Peek().Equals('a') && pila.Peek().Equals('Z'))
                {
                    palabras.Pop();
                    pila.Pop();
                    pila.Push('A');
                    pila.Push('A');
                    pila.Push('A');
                    pila.Push('A');
                }
                while (palabras.Peek().Equals('a') && pila.Peek().Equals('A'))
                {
                    palabras.Pop();
                    pila.Pop();
                    pila.Push('A');
                    pila.Push('A');
                }
                if (palabras.Peek().Equals('b') && pila.Peek().Equals('A'))
                {
                    palabras.Pop();
                    pila.Pop();
                }
                while (palabras.Peek().Equals('b') && pila.Peek().Equals('A'))
                {
                    palabras.Pop();
                    pila.Pop();
                }
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                resultado = pila.Count == 0 && palabras.Count == 0 ? true : false;
            }
            pila.Clear();
            palabras.Clear();

            return resultado;
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            if (cblenguaje.SelectedIndex==0)
            {
                ckop1.Checked = automata1(txtop1.Text);
                ckop2.Checked = automata1(txtop2.Text);
                ckop3.Checked = automata1(txtop3.Text);
                ckop4.Checked = automata1(txtop4.Text);
                ckop5.Checked = automata1(txtop5.Text);
                ckop6.Checked = automata1(txtop6.Text);
            }else if (cblenguaje.SelectedIndex == 1)
            {
                ckop1.Checked = automata2(txtop1.Text);
                ckop2.Checked = automata2(txtop2.Text);
                ckop3.Checked = automata2(txtop3.Text);
                ckop4.Checked = automata2(txtop4.Text);
                ckop5.Checked = automata2(txtop5.Text);
                ckop6.Checked = automata2(txtop6.Text);
            }
            else if (cblenguaje.SelectedIndex == 2)
            {
                ckop1.Checked = automata3(txtop1.Text);
                ckop2.Checked = automata3(txtop2.Text);
                ckop3.Checked = automata3(txtop3.Text);
                ckop4.Checked = automata3(txtop4.Text);
                ckop5.Checked = automata3(txtop5.Text);
                ckop6.Checked = automata3(txtop6.Text);
            }
            else if (cblenguaje.SelectedIndex == 3)
            {
                ckop1.Checked = automata4(txtop1.Text);
                ckop2.Checked = automata4(txtop2.Text);
                ckop3.Checked = automata4(txtop3.Text);
                ckop4.Checked = automata4(txtop4.Text);
                ckop5.Checked = automata4(txtop5.Text);
                ckop6.Checked = automata4(txtop6.Text);
            }
            else if (cblenguaje.SelectedIndex == 4)
            {
                ckop1.Checked = automata5(txtop1.Text);
                ckop2.Checked = automata5(txtop2.Text);
                ckop3.Checked = automata5(txtop3.Text);
                ckop4.Checked = automata5(txtop4.Text);
                ckop5.Checked = automata5(txtop5.Text);
                ckop6.Checked = automata5(txtop6.Text);
            }
            else if (cblenguaje.SelectedIndex == 5)
            {
                ckop1.Checked = automata6(txtop1.Text);
                ckop2.Checked = automata6(txtop2.Text);
                ckop3.Checked = automata6(txtop3.Text);
                ckop4.Checked = automata6(txtop4.Text);
                ckop5.Checked = automata6(txtop5.Text);
                ckop6.Checked = automata6(txtop6.Text);
            }


        }

        private void ckop1_Click(object sender, EventArgs e)
        {
            bool estado = !ckop1.Checked;
            ckop1.Checked = estado;
        }

        private void ckop2_Click(object sender, EventArgs e)
        {
            bool estado = !ckop2.Checked;
            ckop2.Checked = estado;
        }

        private void ckop3_Click(object sender, EventArgs e)
        {
            bool estado = !ckop3.Checked;
            ckop3.Checked = estado;
        }

        private void ckop4_Click(object sender, EventArgs e)
        {
            bool estado = !ckop4.Checked;
            ckop4.Checked = estado;
        }

        private void ckop5_Click(object sender, EventArgs e)
        {
            bool estado = !ckop5.Checked;
            ckop5.Checked = estado;
        }

        private void ckop6_Click(object sender, EventArgs e)
        {
            bool estado = !ckop6.Checked;
            ckop6.Checked = estado;
        }
    }
}
