using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MediaAritmetca
{
    static class Utils
    {
       public static void LimparCampos(params Control[] controles)
        {
            foreach (var controle in controles)
            {
                if (controle is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (controle is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                // Adicione outros tipos de controles conforme necessário
            }
        }
    }
}
