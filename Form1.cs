using System;
using System.Text;
using System.Windows.Forms;
using ArcTest.DiceRolls;
using System.Net.Http;
using JR.Utils.GUI.Forms;
namespace ArcTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private async void refreshdata()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://coreservice.xyz/arc/api.php");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("?min=" + textBoxUserMin.Text + "&max=" + textBoxUserMax.Text + "&count=" + textBoxUserCount.Text + "");

            if (response.IsSuccessStatusCode)
            {
                var rolls = await response.Content.ReadAsAsync<DiceRolled>();

                StringBuilder resultText = new StringBuilder();
                for (int i = 0; i < rolls.Dice.Count; i++)
                {
                    resultText.AppendLine($"Roll {i + 1}:  {rolls.Dice[i]} {" "}");
                }

                FlexibleMessageBox.Show(resultText.ToString(), "Dice Rolls");

                textBoxPreviousResults.Text += resultText.ToString();
            }
            else
            {
                FlexibleMessageBox.Show("Please input numbers e.g. 18 or 999");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshdata();
        }


        private void textBoxUserMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string hyperlinkUrl = "https://www.arc.net.nz/";
            System.Diagnostics.Process.Start(hyperlinkUrl);
            
        }
    }
}
