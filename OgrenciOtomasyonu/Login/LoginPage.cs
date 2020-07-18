using OgrenciOtomasyonu.ActionClass;
using OgrenciOtomasyonu.MainMenu;
using System;
using System.Data;
using System.Windows.Forms;

namespace OgrenciOtomasyonu.Login
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan Çıkış Yapılsın mı ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("İşleminiz İptal Edildi","Bilgilendirme Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void action_Click(object sender, EventArgs e)
        {
            ActionMetot action = new ActionMetot();
            DataTable dt = action.Login(username.Text, password.Text);
            {
                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Başarılı Giriş Yapıldı","Bilgilendirme Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    HomePage frm = new HomePage();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("İşlemde Hata Oluştu", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
