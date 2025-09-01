using System;
using System.Net.Http;
using System.Threading.Tasks;

public partial class SendSMS : System.Web.UI.Page
{
    protected async void btnSend_Click(object sender, EventArgs e)
    {
        string phone = txtPhone.Text.Trim();
        string message = txtMessage.Text.Trim();

        if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(message))
        {
            lblResult.Text = "Please enter phone number and message.";
            lblResult.ForeColor = System.Drawing.Color.Red;
            return;
        }

        try
        {
            using (HttpClient client = new HttpClient())
            {
                // Replace with your SMS gateway URL
                string gatewayUrl = "http://YOUR-GATEWAY-IP/send";
                
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("number", phone),
                    new KeyValuePair<string, string>("message", message)
                });

                HttpResponseMessage response = await client.PostAsync(gatewayUrl, content);
                string result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    lblResult.Text = "SMS sent successfully! Response: " + result;
                    lblResult.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResult.Text = "Failed to send SMS. Response: " + result;
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
        catch (Exception ex)
        {
            lblResult.Text = "Error: " + ex.Message;
            lblResult.ForeColor = System.Drawing.Color.Red;
        }
    }
}
