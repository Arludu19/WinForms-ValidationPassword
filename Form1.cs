namespace HolaMundo
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Obtenemos el texto ingresado en el primer campo de contraseña
            string pass = txtPassword.Text;

            // Obtenemos el texto ingresado en el campo de confirmación
            string confirm = txtConfirm.Text;

            // Definimos el patrón de validación con Regex:
            // - (?=.*[A-Z])  → al menos una letra mayúscula
            // - (?=.*[a-z])  → al menos una letra minúscula
            // - (?=.*\d)     → al menos un número
            // - (?=.*[^\w\s])→ al menos un símbolo (no letra, no número y no espacio)
            // - ^...$        → asegura que la validación se aplique a toda la cadena
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\w\s]).+$";

            // Validamos si la contraseña cumple con el patrón
            if (!System.Text.RegularExpressions.Regex.IsMatch(pass, pattern))
            {
                // Si no cumple, mostramos un mensaje de advertencia
                MessageBox.Show(
                    "La contraseña debe contener al menos:\n" +
                    "• 1 letra mayúscula\n" +
                    "• 1 letra minúscula\n" +
                    "• 1 número\n" +
                    "• 1 símbolo",
                    "Contraseña no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Detenemos la ejecución aquí para no continuar con más validaciones
                return;
            }

            // Validamos si ambas contraseñas coinciden
            if (pass != confirm)
            {
                // Si no coinciden, mostramos un mensaje
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Verificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Terminamos la ejecución de este evento
                return;
            }

            // Esta parte significa que la contraseña es válida y coincide, saldrá un mensaje confirmando
            MessageBox.Show(
                "La contraseña ha sido validada",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
