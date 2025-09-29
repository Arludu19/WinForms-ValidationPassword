# WinForms-ValidationPassword
Aplicación en Windows Forms para validar contraseña con Regex.

## WinForms - Validación de Contraseña con Regex
Este proyecto es una **aplicación de escritorio en Windows Forms (C#)** que valida contraseñas utilizando **expresiones regulares (Regex)**.  

El programa cumple con los siguientes requisitos:  
- Al menos **una letra mayúscula**  
- Al menos **una letra minúscula**  
- Al menos **un número**  
- Al menos **un símbolo especial**  
- Confirmación de contraseña (los dos campos deben coincidir)  
---
## Capturas de pantalla 
### 1. Interfaz inicial
<img src="/Interfaz/Interfaz.png" alt="Interfaz inicial" width="400"/>

### 2. Error de validación
<img src="/Interfaz/error.png" alt="Error de validación" width="400"/>

### 3. Contraseñas no coinciden
<img src="/Interfaz/no.png" alt="Contraseñas no coinciden" width="400"/>

### 4. Éxito
<img src="/Interfaz/exito.png" alt="Éxito" width="400"/>

---
## Autor
   Proyecto desarrollado por **Luis Dueñas** (Arludu19) como práctica para Ciberinfraestructura.
   
## Instrucciones de uso
### Requisitos
- **Visual Studio 2022** (Community Edition es suficiente).  
- **.NET 6.0 / 7.0 / 8.0** (cualquier versión funciona).  
- Windows 10/11.  
### Código principal (btnValidar_Click)
Este es el método que valida la contraseña y confirma que ambas coincidan:

```csharp
private void btnValidar_Click(object sender, EventArgs e)
{
    string pass = (txtPassword.Text ?? string.Empty).Trim();
    string confirm = (txtConfirm.Text ?? string.Empty).Trim();

    if (!PasswordRegex.IsMatch(pass))
    {
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

    if (!string.Equals(pass, confirm, StringComparison.Ordinal))
    {
        MessageBox.Show(
            "Las contraseñas no coinciden.",
            "Verificación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        return;
    }

    MessageBox.Show(
        "La contraseña ha sido validada",
        "Éxito",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
}
```
1. Clona este repositorio o descárgalo.  
   ```bash
   git clone https://github.com/Arludu19/WinForms-ValidationPassword.git
   ```
