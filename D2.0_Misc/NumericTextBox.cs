using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_13_25.D2._0_Misc
{
    public class NumericTextBox : TextBox
    {
        private bool _isFormatting;
        private string _PreviousText = "";

        public int MaxWholeNumberDigits { get; set; } = 12;
        public int MaxDecimalPlaces { get; set; } = 2;
        public int MaxTotalDigits { get; set; } = 15;
        public NumericTextBox()
        {
            this.KeyPress += NumericTextBox_KeyPress;
            this.TextChanged += NumericTextBox_TextChanged;
            this.Enter += NumericTextBox_Enter;
            this.Leave += NumericTextBox_Leave;
            //this.TextAlign = HorizontalAlignment.Right; // Align text to the right
            this.Text = "0.00"; // Default value
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            FormatText();
        }

        private void NumericTextBox_Enter(Object sender, EventArgs e)
        {
            _PreviousText = this.Text;

            //if (decimal.TryParse(this.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal value))
            //{
            //    this.Text = value.ToString("0.00");
            //}
            //else
            //{
            //    this.Text = "0.00";
            //}
            this.Text = this.Text.Replace(",", "");
        }

        private void NumericTextBox_Leave(Object sender, EventArgs e)
        {
            FormatText();
        }

        private void NumericTextBox_TextChanged(Object sender, EventArgs e)
        {
            if (_isFormatting) return;

            if (this.Text.Count(c => c == '.') > 1)
            {
                _isFormatting = true;
                this.Text = _PreviousText;
                this.SelectionStart = this.Text.Length;
                _isFormatting = false;
                return;
            }

            if (this.Text.Contains('.'))
            {
                string wholePart = this.Text.Split('.')[0];
                if (wholePart.Length > MaxWholeNumberDigits)
                {
                    _isFormatting = true;
                    this.Text = _PreviousText;
                    this.SelectionStart = this.Text.Length;
                    _isFormatting = false;
                    return;
                }
            }
            else if (this.Text.Length > MaxWholeNumberDigits)
            {
                _isFormatting = true;
                this.Text = _PreviousText;
                this.SelectionStart = this.Text.Length;
                _isFormatting = false;
                return;
            }

                _PreviousText = this.Text;
        }

        private void NumericTextBox_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && this.Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }

            if (this.Text.Contains('.'))
            {
                int decimalPosition = this.Text.IndexOf('.');
                string afterDecimal = this.Text.Substring(decimalPosition + 1);

                if (afterDecimal.Length >= 2 && this.SelectionStart > decimalPosition)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == '0' && this.Text == "0" && !this.Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }
        }

        private void FormatText()
        {
            if (_isFormatting) return;
            _isFormatting = true;

            string cleanText = new string(this.Text.Where(c => char.IsDigit(c) || c == '.').ToArray());

            if (string.IsNullOrWhiteSpace(cleanText))
            {
                this.Text = "0.00";
            }

            else if (decimal.TryParse(cleanText, out decimal value))
            {
                string formatString = "N" + MaxDecimalPlaces.ToString();
                this.Text = value.ToString(formatString, CultureInfo.CurrentCulture);

                string digitsOnly = new string(this.Text.Where(char.IsDigit).ToArray());
                if (digitsOnly.Length > MaxTotalDigits)
                {
                    string truncated = digitsOnly.Substring(0, MaxTotalDigits);
                    if (decimal.TryParse(truncated.Insert(truncated.Length - MaxDecimalPlaces, "."), out decimal truncatedValue))
                    {
                        this.Text = truncatedValue.ToString(formatString, CultureInfo.CurrentCulture);
                    }
                }
            }
            else
            {
                this.Text = "0.00";
            }

            _isFormatting = false;
        }

        public decimal NumericValue
        {
            get
            {
                string cleanText = new string(this.Text.Where(c => char.IsDigit(c) || c == '.').ToArray());

                if(decimal.TryParse(cleanText, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal value))
                {
                    return value;
                }
                return 0m;
            }
            set
            {
                string formatString = "N" + MaxDecimalPlaces.ToString();
                this.Text = value.ToString(formatString, CultureInfo.CurrentCulture);
            }
        }
    }
}
