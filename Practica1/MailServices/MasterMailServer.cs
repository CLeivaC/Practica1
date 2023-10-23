using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;
using System.Data;

namespace Practica1.MailServices
{
    public class MasterMailServer
    {
        //MySqlConnection connection = new MySqlConnection($"Server={"localhost"};Database={"lol"};User Id={"root"};Password={"admin"}");

        MySqlConnection connection = new MySqlConnection($"Server={"bf9zwbmdmtlptaymlaot-mysql.services.clever-cloud.com"};Database={"bf9zwbmdmtlptaymlaot"};User Id={"usjhj42ycmnv1wjk"};Password={"6aVyqZUKG2PdZoSfVL4f"}");

        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmptClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;


        }

        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);

                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            } catch (Exception ex)
            {

            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }


        public string recoverPasssword(string userRequesting)
        {
            connection.Open();
            using (var command = new MySqlCommand())
            {

                command.Connection = connection;
                command.CommandText = "select * from login where username=@user or email=@email";
                command.Parameters.AddWithValue("@user", userRequesting);
                command.Parameters.AddWithValue("@email", userRequesting);
                command.CommandType = CommandType.Text;
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read() == true)
                {
                    string userName = reader.GetString("nombre") + ", " + reader.GetString("apellidos");
                    string userMail = reader.GetString("email");
                    string password = reader.GetString("password");

                    var mailService = new SystemSupportMail();
                    mailService.sendMail(
                        subject: "System: Recuperacion de contraseña",
                        body: "Hola, " + userName + "\nSolicitaste recuperar la contraseña.\n" +
                        "Tu contraseña actual is " + password +
                        "\nNo obstante, deberás cambiar la contraseña una vez inicies sesion.",
                        recipientMail: new List<string> { userMail }
                        );
                    connection.Close();
                    return "Hola, " + userName + "\nSolicitaste recuperar la contraseña.\n" +
                        "Por favor, revisa tu correo electronico: " + userMail +
                        "\n.No obstante, deberás cambiar la contraseña una vez inicies sesion.";
                }
                else { connection.Close(); return "Lo sentimos, no tiene una cuenta con ese usuario o correo electronico. "; }
            }
        

        }

       
    }
}
