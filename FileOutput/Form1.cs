using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Formatting = Newtonsoft.Json.Formatting;

namespace FileOutput
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        string str ="\"";//2重引用符
        private void button1_Click(object sender, EventArgs e)
        {
            //ファイル出力
            string filename = "test.json";
            StreamWriter writer = new StreamWriter(filename,false,Encoding.GetEncoding("UTF-8"));
            //config出力
            writer.WriteLine("{");
            writer.WriteLine(" "+str+"niconico"+str+":{");
            //アバター出力
            writer.WriteLine("  "+str+ "character_models"+str+":[");
            writer.WriteLine("   "+42621);
            writer.WriteLine("  ]");
            writer.WriteLine(" }");
            //背景画像出力
            //ホワイトボード画像出力
            //カンペ画像出力
            writer.WriteLine("}");
            writer.Close();
        }
    }
}
