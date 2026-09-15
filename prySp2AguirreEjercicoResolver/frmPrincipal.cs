namespace prySp2AguirreEjercicoResolver
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se agrega char.IsControl(e.KeyChar) para permitir el uso de la tecla Backspace (borrar)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cboTipoBoleto.Items.Add("Normal");
            cboTipoBoleto.Items.Add("VIP");
            cboTipoBoleto.Items.Add("Platinum");
            cboTipoBoleto.DropDownStyle = ComboBoxStyle.DropDownList;
            rbCorta.Checked = true;
        }

        private void btnRegistrar_Click_1 (object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            if (cboTipoBoleto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de boleto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipoBoleto.Focus();
                return;
            }

            string tipoBoleto = cboTipoBoleto.SelectedItem.ToString();
            string distancia = rbCorta.Checked ? "Corta" : "Larga";
            DateTime fecha = dtpFecha.Value;

            MessageBox.Show($"Código: {txtCodigo.Text}\nTipo de Boleto: {tipoBoleto}\nDistancia: {distancia}\nFecha: {fecha.ToShortDateString()}",
                            "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            // Si está vacío se pinta rojo, de lo contrario vuelve a su color blanco predeterminado
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.BackColor = Color.LightPink;
            }
            else
            {
                txtCodigo.BackColor = Color.White;
            }
        }
    }
}