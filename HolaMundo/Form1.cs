using System.Text.RegularExpressions;   // Importamos Regex para validaciones de contraseñas

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        // Regex precompilado para validar contraseñas:
        // - (?=.*[A-Z])  --> al menos 1 letra mayúscula
        // - (?=.*[a-z])  --> al menos 1 letra minúscula
        // - (?=.*\d)     --> al menos 1 número
        // - (?=.*[^\w\s])--> al menos 1 carácter especial (ni letra, ni número, ni espacio)
        // - ^...$        --> aplica la validación a toda la cadena
        private static readonly Regex PasswordRegex =
            new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\w\s]).+$", RegexOptions.Compiled);

        public Form1()
        {
            InitializeComponent();   // Método que crea y coloca todos los controles (button, label, textbox, etc.)
        }

        // Evento que se ejecuta cada que se hace clic en el botón "Acceder"
        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Obtiene el texto de los recuadros de contraseña y confirmación
            // El operador ?? evita errores si es null, y Trim() elimina espacios de inicio/fin
            string pass = (txtPassword.Text ?? string.Empty).Trim();
            string confirm = (txtConfirm.Text ?? string.Empty).Trim();

            // Validación con Regex: ¿cumple con mayúscula, minúscula, número y símbolo?
            if (!PasswordRegex.IsMatch(pass))
            {
                // Si no cumple, mostramos advertencia y salimos del método con "return"
                MessageBox.Show(
                    "La contraseña debe contener al menos:\n" +
                    "• 1 letra mayúscula\n" +
                    "• 1 letra minúscula\n" +
                    "• 1 número\n" +
                    "• 1 símbolo",
                    "Contraseña no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Comprobamos si la confirmación coincide exactamente con la contraseña
            if (!string.Equals(pass, confirm, StringComparison.Ordinal))
            {
                // Si no coinciden, mostramos mensaje y terminamos
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Verificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Si cumple con los requisitos: contraseña válida y confirmada
            MessageBox.Show(
                "La contraseña ha sido validada",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}