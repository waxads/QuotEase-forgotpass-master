using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

internal class Program
{
    private static void Main(string[] args)
    {
        sendCode sc = new sendCode();
        this.Hide();
        global::System.Object value = sc.Show();
using System.Net;
using System.Net.Mail;
string randomCode;
        string from, pass, messageBody;
        Random rand = new Random();
        randomCode = rand.Next(999999).ToString();
        MailMessage message = new MailMessage();
        to = txtEmail.Text.ToString();
        from = "YOUR_EMAIL";
        pass = "YOUR_EMAIL_PASSWORD";
        messageBody = "your reset code is " + randomCode;
        message.To.Add(to);
        message.From = new MailAddress(from);
        message.Body = messageBody;
        message.Subject = "password reseting code";
        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        smtp.EnableSsl = true;
        smtp.Port = 587;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.Credentials = new NetworkCredential(from, pass);
        try
        {
            smtp.Send(message);
            MessageBox.Show("code send successfully" + randomCode);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        if (randomCode == txtVerCode.Text.ToString())
        {
            to = txtEmail.Text;
            ResetPassword rp = new ResetPassword();
            this.Hide();
            rp.Show();
        }
        else
        {
            MessageBox.Show("wrong code");
        }
    }
}

public static string to;
