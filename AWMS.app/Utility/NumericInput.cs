
namespace AWMS.app.Utility
{
    public static class NumericInput
    {
        public static void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            // متن
            string text = ((Control)sender).Text;

            // عدد منفی
            if (e.KeyChar == '-' && text.Length == 0)
            {
                e.Handled = false;
                return;
            }

            // عدد اعشاری
            if (e.KeyChar == ',' && text.Length > 0 && !text.Contains(","))
            {
                e.Handled = false;
                return;
            }

            // عدد
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
    }
}
