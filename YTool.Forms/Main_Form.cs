using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using YTool.Forms.Service.Model;

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

            var resInt = 0m;
            foreach (var res in resArr)
            {
                var tmpInt = 0m;
                if (decimal.TryParse(res, out tmpInt))
                    resInt += tmpInt;
                else
                {
                    MessageBox.Show("数字转换失败：" + res, "错误");
                    return;
                }
            }

            txt_Main.Text = resInt.ToString();
        }

        private string[] GetTextArr(string text)
        {
            var resArr = text.Replace("\n", "^").Split(new[] { '^' }, StringSplitOptions.RemoveEmptyEntries);
            return resArr;
        }

        private void Main_Form_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //不在系统任务栏显示主窗口图标
                this.ShowInTaskbar = false;
            }
        }

        private void nfi_MinWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Activate_Main_Form();
            }
        }

        private void tsm_Deduplication_Click(object sender, EventArgs e)
        {
            try
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    var text = (string)iData.GetData(DataFormats.UnicodeText);
                    if (string.IsNullOrWhiteSpace(text))
                        return;

                    var resArr = GetTextArr(text);
                    resArr = resArr.Distinct().ToArray();

                    txt_Main.Text = string.Join(Environment.NewLine, resArr);

                    Activate_Main_Form();
                }
                else
                {
                    MessageBox.Show("目前剪贴板中数据不可转换为文本", "错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void Activate_Main_Form()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //还原窗体
                this.WindowState = FormWindowState.Normal;
                //系统任务栏显示图标
                this.ShowInTaskbar = true;
            }
            //激活窗体并获取焦点
            this.Activate();
        }

        private void tsm_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btn_json_format_Click(object sender, EventArgs e)
        {
            JsonWriter(Formatting.Indented);
        }

        private void btn_json_compression_Click(object sender, EventArgs e)
        {
            JsonWriter(Formatting.None);
        }

        private void JsonWriter(Formatting formatting)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("请输入Json文本");
                return;
            }

            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(text);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = formatting,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                txt_Main.Text = textWriter.ToString();
            }
        }

        private void btnImg2Base64_Click(object sender, EventArgs e)
        {
            try
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    var text = (string)iData.GetData(DataFormats.UnicodeText);
                    if (string.IsNullOrWhiteSpace(text))
                        return;

                    txt_Main.Text = text;

                    Activate_Main_Form();
                }
                else
                {
                    MessageBox.Show("目前剪贴板中数据不可转换为文本", "错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;

            txt_Main.Text = string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.ToUpper()));
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;

            txt_Main.Text = string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.ToLower()));
        }

        private void btnDY_Click(object sender, EventArgs e)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;
            if (cbxFX.Checked)
                txt_Main.Text = string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.Trim('\'')));
            else
                txt_Main.Text = string.Join(Environment.NewLine, GetTextArr(text).Select(a => "'" + a.Trim('\'') + "'"));
        }

        private void btnSY_Click(object sender, EventArgs e)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;
            if (cbxFX.Checked)
            {
                txt_Main.Text = string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.Trim('"')));
            }
            else
            {
                txt_Main.Text = string.Join(Environment.NewLine, GetTextArr(text).Select(a => "\"" + a.Trim('"') + "\""));
            }
        }

        private void btnDH_Click(object sender, EventArgs e)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;
            if (cbxFX.Checked)
                txt_Main.Text = string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.TrimEnd(',')));
            else
            {
                txt_Main.Text = string.Join(Environment.NewLine, GetTextArr(text).Select(a => a.TrimEnd(',') + ","));
            }

        }

        private void btnBF_Click(object sender, EventArgs e)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;
            var urlModelList = GetTextArr(text).Select(a => new BingfaTestModel { Id = Guid.NewGuid(), Url = a }).ToList();

            List<Task> tasks = new List<Task>();
            int index = 1;
            foreach (var urlModel in urlModelList)
            {
                tasks.Add(
                    Task.Run(() =>
                    {
                        var sw = new Stopwatch();
                        sw.Start();
                        var getResp = new HttpClient().GetStringAsync(urlModel.Url);
                        getResp.Wait();

                        urlModel.Index = index;
                        index++;
                        urlModel.Result = getResp.Result;
                        urlModel.Time = sw.Elapsed;
                    })
                );
            }
            Task.WaitAll(tasks.ToArray());
            txt_Main.Text = string.Join(Environment.NewLine, urlModelList.OrderBy(a => a.Index).Select(a => a.Index + " - " + a.Url + " - " + a.Result + " - " + a.Time.TotalSeconds));
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var text = txt_Main.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;

            int groupNum = 0;
            int.TryParse(txtGroupCount.Text, out groupNum);
            if (groupNum <= 0)
                return;

            var textList = GetTextArr(text).ToList();

            List<string> listGroup = new List<string>();
            for (int i = 0; i < textList.Count; i += groupNum)
            {
                listGroup.Add("Group-" + (i + 1));
                listGroup.AddRange(textList.Skip(i).Take(groupNum).ToList());
            }
            txt_Main.Text = string.Join(Environment.NewLine, listGroup);
        }

        private void updateLabelRowIndex()
        {
            //we get index of first visible char and number of first visible line
            Point pos = new Point(0, 0);
            int firstIndex = this.txt_Main.GetCharIndexFromPosition(pos);
            int firstLine = this.txt_Main.GetLineFromCharIndex(firstIndex);

            //now we get index of last visible char and number of last visible line
            pos.X += this.txt_Main.ClientRectangle.Width;
            pos.Y += this.txt_Main.ClientRectangle.Height;
            int lastIndex = this.txt_Main.GetCharIndexFromPosition(pos);
            int lastLine = this.txt_Main.GetLineFromCharIndex(lastIndex);

            //this is point position of last visible char,
            //we'll use its Y value for calculating numberLabel size
            pos = this.txt_Main.GetPositionFromCharIndex(lastIndex);

            /*labelRowIndex.Text = "";
            for (int i = firstLine; i <= lastLine + 1; i++)
            {
                labelRowIndex.Text += i + 1 + "\r\n";
            }*/
        }
    }
}