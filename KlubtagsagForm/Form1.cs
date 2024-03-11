using System;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json;
using Klubtagság;

namespace KlubtagsagForm
{
    public partial class Form1 : Form
    {

        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrl");

        public static string ReadSetting(string keyName)
        {
            string result = null;
            try
            {
                var value = ConfigurationManager.AppSettings;
                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();
            listBox_tagok.SelectedIndexChanged += listbox_tagok_SelectedIndexChanged;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listboxFrissites();
        }

        private async void listboxFrissites()
        {
            listBox_tagok.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var member = Member.FromJson(jsonString);
                    foreach (Member item in member)
                    {
                        listBox_tagok.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listbox_tagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Member selectedMember = (Member)listBox_tagok.SelectedItem;
            textBox_FullName.Text = selectedMember.Fullname.ToString();
            textBox_Interest.Text = selectedMember.Interest.ToString();
            numericUpDown_Rating.Value = selectedMember.Rating;
            dateTimePicker_Entry.Value = DateTime.Parse(selectedMember.Entry);
            numericUpDown_ID.Value = selectedMember.Id;

        }

        private async void button_update_Click(object sender, EventArgs e)
        {
            if (listBox_tagok.SelectedIndex != -1)
            {
                Member selectedMember = (Member)listBox_tagok.SelectedItem;
                selectedMember.Fullname = textBox_FullName.Text;
                selectedMember.Interest = textBox_Interest.Text;
                selectedMember.Rating = (int)numericUpDown_Rating.Value;
                selectedMember.Entry = dateTimePicker_Entry.Value.ToString("MMM d, yyyy h:mm tt");
                selectedMember.Id = (int)numericUpDown_ID.Value;

                var json = JsonConvert.SerializeObject(selectedMember);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{endPoint}/{selectedMember.Id}", data);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres módosítás!");
                    listboxFrissites();
                }
                else
                {
                    MessageBox.Show("Sikertelen módosítás!");
                }

                // Clear controls after update
                numericUpDown_ID.Value = 0;
                textBox_FullName.Text = "";
                textBox_Interest.Text = "";
                numericUpDown_Rating.Value = 0;
                dateTimePicker_Entry.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott tag!");
            }
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_tagok.SelectedIndex != -1)
            {
                Member selectedMember = (Member)listBox_tagok.SelectedItem;
                selectedMember.Fullname = textBox_FullName.Text;
                selectedMember.Interest = textBox_Interest.Text;
                selectedMember.Rating = (int)numericUpDown_Rating.Value;
                selectedMember.Entry = dateTimePicker_Entry.Value.ToString("MMM d, yyyy h:mm tt");
                selectedMember.Id = (int)numericUpDown_ID.Value;

                var json = JsonConvert.SerializeObject(selectedMember);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.DeleteAsync($"{endPoint}/{selectedMember.Id}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés!");
                    listboxFrissites();
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés!");
                }

                numericUpDown_ID.Value = 0;
                textBox_FullName.Text = "";
                textBox_Interest.Text = "";
                numericUpDown_Rating.Value = 0;
                dateTimePicker_Entry.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott tag!");
            }
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.ShowDialog();
        }
    }
}

