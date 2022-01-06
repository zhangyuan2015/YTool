using System;

namespace YTool.Forms.Service.Model
{
    public class BingfaTestModel
    {
        public Guid Id { get; set; }

        public int Index { get; set; }

        public string Url { get; set; }

        public string Result { get; set; }

        public TimeSpan Time { get; set; }
    }
}