using OgrenciOtomasyonu.Login;
using OgrenciOtomasyonu.Student;
using OgrenciOtomasyonu.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyonu.MainMenu
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan Çıkış Yapılsın mı ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("İşleminiz İptal Edildi", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            userAdd.ShowDialog();
        }

        private void kullanıcıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserUpdate userUpdate = new UserUpdate();
            userUpdate.ShowDialog();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAdd studentAdd = new StudentAdd();
            studentAdd.ShowDialog();
        }

        private void öğrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsUpdate studentsUpdate = new StudentsUpdate();
            studentsUpdate.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDelete studentDelete = new StudentDelete();
            studentDelete.ShowDialog();
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciTablo listele = new OgrenciTablo();
            listele.ShowDialog();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablo listele = new Tablo();
            listele.ShowDialog();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDelete userDelete = new UserDelete();
            userDelete.ShowDialog();
        }
    }
}
