using System;
using System.Windows.Forms;

namespace Javier Prieto
{
    public partial class FormularioHDV : Form 
    {
        public FormularioHDV() 
        {
            InitializeComponent();
        }

        private void FormularioHDV_load(object sender, EventArgs e)
        {
            this.Text ="HDV";

            Label lblNombre = new Label();
            lblNombre.Text = "Name: ";
            lblNombre.Location = new Point(10, 10);
            lblNombre.AutoSize = true;
            this.Controls.Add(lblNombre);

            TextBox txtNombre = new TextBox();
            txtNombre.Location = new Point(lblNombre.Right + 5, lblNombre.Top);
            txtNombre.Width = 200;
            this.Controls.Add(txtNombre);

            Label lblEmail = new Label();
            lblEmail.Text = "Email: ";
            lblEmail.Location = new Point(10, lblNombre.Bottom + 10);
            lblEmail.AutoSize = true;
            this.Controls.Add(lblEmail);

            TextBox txtEmail = new TextBox();
            txtEmail.Location = new Point(lblEmail.Left, lblEmail.Top);
            txtEmail.Width = 200;
            this.Controls.Add(txtEmail);

            this.ClientSize = new Size(400, 150)
        }
    }
}