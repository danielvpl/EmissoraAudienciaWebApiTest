using System.Text.RegularExpressions;

namespace Domain.Validators
{
    public class EmissoraValidator
    {
        public static bool ValidaNome(string texto)
        {
            texto = texto.ToLower();
            bool existeCaractereEspecial = Regex.IsMatch(texto, (@"[^a-zA-Z0-9- ]"));
            return !existeCaractereEspecial;
        }
    }
}
