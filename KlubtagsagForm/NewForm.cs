using Klubtagság;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlubtagsagForm
{
    

    public partial class NewForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = Form1.ReadSetting("endpointUrl");
        public NewForm()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button_save_Click(object sender, EventArgs e)
        {
            if (NewForm_textBox_FullName.Text == "" || NewForm_numericUpDown_Rating.Value == 0  || NewForm_textBox_Interest.Text == "" || NewForm_dateTimePicker_Entry.Value == null)
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
            }
            else
            {   
                Member selectedMember = new  Member();
                selectedMember.Fullname = NewForm_textBox_FullName.Text;
                selectedMember.Interest = NewForm_textBox_Interest.Text;
                selectedMember.Rating = (int)NewForm_numericUpDown_Rating.Value;
                selectedMember.Entry = NewForm_dateTimePicker_Entry.Value.ToString("MMM d, yyyy h:mm tt");

                var json = JsonConvert.SerializeObject(selectedMember);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(endPoint,data);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres felvétel!");
                    
                }
                else
                {
                    MessageBox.Show("Sikertelen felvétel!");
                }
            }
            {
            }
        }
    }
}
