using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BlazorApp2.Components;

public class EmailSender: IEmailSender {

    private readonly string _appMail;
    private string _appPass;
    
    public EmailSender(string appMail, string appPass) {
        _appMail = appMail;
        _appPass = appPass;
    }
    
    public async Task SendEmailAsync(string email, string subject, string htmlMessage) {

        
        using var emailMessage = new MimeMessage();
 
        emailMessage.From.Add(new MailboxAddress("Администрация сайта", "john_1_1_1@mail.ru"));
        emailMessage.To.Add(new MailboxAddress(email,email));
        emailMessage.Subject = subject;
        emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        {
            Text = htmlMessage
        };
             
        using (var client = new SmtpClient())
        {
            client.Timeout = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;
            await client.ConnectAsync("smtp.mail.ru", 465, true);
            await client.AuthenticateAsync("john_1_1_1@mail.ru", "c6XtZpS66sk3bm5V1hxG");
            await client.SendAsync(emailMessage);
            await client.DisconnectAsync(true);
        }
    }
}