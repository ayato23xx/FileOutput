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

        string str ="\"";//2�d���p��
        private void button1_Click(object sender, EventArgs e)
        {

            //�t�@�C���o��
            //string output = JsonConvert.SerializeObject(json);
            //string json = JsonConvert.SerializeObject(date2, Formatting.Indented);
            string filename = "test.json";
            StreamWriter writer = new StreamWriter(filename,false,Encoding.GetEncoding("UTF-8"));
            //writer.WriteLine(format_json(output));
            //config�o��
            writer.WriteLine("{");
            writer.WriteLine(" "+str+"niconico"+str+":{");
            //�A�o�^�[�o��
            writer.WriteLine("  "+str+ "character_models"+str+":[");
            writer.WriteLine("   "+42621);
            writer.WriteLine("  ]");
            writer.WriteLine(" }");
            //�w�i�摜�o��
            //�z���C�g�{�[�h�摜�o��
            //�J���y�摜�o��
            writer.WriteLine("}");
            writer.Close();
        }

        //json�̐��`
        private static string format_json(string json)
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }
    }
}
