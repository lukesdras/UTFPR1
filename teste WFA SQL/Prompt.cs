﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//inputbox
namespace teste_WFA_SQL
{
    public class Promptt : IDisposable
    {
        private Form Prompt { get; set; }
        public string Result { get; }

        public Promptt(string text, string caption)
        {
            Result = ShowDialog(text, caption);
        }
        //use a using statement
        private string ShowDialog(string text, string caption)
        {
            Prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleCenter };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { Prompt.Close(); };
            Prompt.Controls.Add(textBox);
            Prompt.Controls.Add(confirmation);
            Prompt.Controls.Add(textLabel);
            Prompt.AcceptButton = confirmation;

            return Prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public void Dispose()
        {
            //See Marcus comment
            if (Prompt != null)
            {
                Prompt.Dispose();
            }
        }
    }
}
