using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Net;

namespace InstagramTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string token = textBoxAccessToken.Text.ToString();

            if (token=="")
            {
                MessageBox.Show("Bitte erst einen Access-Token eingeben!");
                return;
            }

            string targetUrl 
                = "https://api.instagram.com/v1/users/self/?access_token=" 
                + token;

            //WebClient anlegen
            WebClient myWebClient = new WebClient();

            //Except100 ausschalten, sonst gibt es u. U. Fehlermeldungen
            ServicePointManager.Expect100Continue = false;
            
            byte[] antwort = null;

            try
            {
                antwort = myWebClient.DownloadData(targetUrl);
                labelResponse.Text=System.Text.Encoding.ASCII.GetString(antwort);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
                return;
            }

            //JSON deserialisieren
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(InstagramProfile));
            MemoryStream ms = new MemoryStream(antwort);
            InstagramProfile ip = ser.ReadObject(ms) as InstagramProfile;
            MessageBox.Show("Username: " + ip.data.username 
                + " Anzahl Follower: " + ip.data.counts.followed_by);
        }
    }
}
