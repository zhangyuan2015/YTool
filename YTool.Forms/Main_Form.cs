using System;
using System.Linq;
using System.Windows.Forms;

namespace YTool.Forms
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void btn_Deduplication_Click(object sender, EventArgs e)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;

            var resArr = GetTextArr(text);
            resArr = resArr.Distinct().ToArray();

            txt_Main.Text = string.Join(Environment.NewLine, resArr);
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;

            var resArr = GetTextArr(text);

            var resInt = 0;
            foreach (var res in resArr)
            {
                var tmpInt = 0;
                if (int.TryParse(res, out tmpInt))
                    resInt += tmpInt;
            }

            txt_Main.Text = resInt.ToString();
        }

        private string[] GetTextArr(string text)
        {
            var resArr = text.Replace(Environment.NewLine, "^").Split(new[] { '^' }, StringSplitOptions.RemoveEmptyEntries);
            return resArr;
        }
    }
}
