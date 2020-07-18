using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyonu.ActionClass
{
    public class ActionMetot
    {
        #region Giriş İşlemleri
        public DataTable Login(string username, string password)
        {
            string kod = "Select *  From Tbl_User where Username=@username and Password=@password";
            string[] parametre = { "@username", "@password" };
            string[] deger = { username, password };
            return ActionConnection.ExecuteReader(kod, parametre, deger);
        }
        #endregion
        #region Kullanıcı İşlemleri
        public static int userAdd(string KulAdi,string KulSifre,string Adi,string Soyadi)
        {
            string kod = "Insert Into Tbl_User(Username,Password,Name,Surname) Values(@username,@password,@name,@surname)";
            string[] parametre = { "@username", "@password", "@name", "@surname" };
            string[] deger = { KulAdi, KulSifre, Adi, Soyadi };
            return ActionConnection.ExecuteNonQuery(kod, parametre, deger);
        }
        public static int userUpdate(string Username, string Password, string Name, string Surname, string Username2)
        {
            string kod = "Update Tbl_User Set Username=@username,Password=@password,Name=@name,Surname=@surname Where Username=@username2";
            string[] parametre = { "@username", "@password", "@name", "@surname", "@username2" };
            string[] deger = { Username, Password, Name, Surname, Username2 };
            return ActionConnection.ExecuteNonQuery(kod, parametre, deger);
        }
        public static int userDelete(string kuladi1, string ksifre1)
        {
            string kod = "delete from dbo.Tbl_User where Username=@username and Password=@password";
            string[] parametre = { "@username", "@password" };
            string[] deger = { kuladi1, ksifre1 };
            return ActionConnection.ExecuteNonQuery(kod, parametre, deger);
        }
        #endregion
        #region Öğrenci İşlemleri
        public static int studentAdd(string NameSurname, string IdentityKey,string StudentNumber, string PhoneNumber, string Address,string CuratorNameSurname,string CuratorPhoneNumber)
        {
            string kod = "Insert Into Tbl_Ogrenci(OgrenciAdiSoyadi,TcKimlik,OgrenciNo,Telefon,Adres,VeliAdiSoyadi,VeliTel) Values(@OgrenciAdiSoyadi,@TcKimlik,@OgrenciNo,@Telefon,@Adres,@VeliAdiSoyadi,@VeliTel)";
            string[] parametre = { "@OgrenciAdiSoyadi", "@TcKimlik", "@OgrenciNo", "@Telefon", "@Adres", "@VeliAdiSoyadi", "@VeliTel" };
            string[] deger = { NameSurname, IdentityKey, StudentNumber, PhoneNumber, Address, CuratorNameSurname, CuratorPhoneNumber};
            return ActionConnection.ExecuteNonQuery(kod, parametre, deger);
        }
        public static int studentUpdate(string NameSurname, string IdentityKey, string StudentNumber, string PhoneNumber, string Address, string CuratorNameSurname, string CuratorPhoneNumber, string NameSurname2)
        {
            string kod = "Update Tbl_Ogrenci Set NameSurname=@OgrenciAdiSoyadi,IdentityKey=@TcKimlik,StudentNumber=@OgrenciNo,PhoneNumber=@Telefon,Address=@Adres ,CuratorNameSurname=@VeliAdiSoyadi ,CuratorPhoneNumber=@VeliTel   Where NameSurname=@NameSurname2";
            string[] parametre = { "@OgrenciAdiSoyadi", "@TcKimlik", "@OgrenciNo", "@Telefon", "@Adres", "@VeliAdiSoyadi", "@VeliTel" };
            string[] deger = { NameSurname, IdentityKey, StudentNumber, PhoneNumber, Address, CuratorNameSurname, CuratorPhoneNumber};
            return ActionConnection.ExecuteNonQuery(kod, parametre, deger);
        }
        public static int StudentDelete(string OgrNo, string OgrAdiSoyadi)
        {
            string kod = "delete from dbo.Tbl_Ogrenci where OgrenciNo = @ogrencino and OgrenciAdiSoyadi=@ogrenciAdiSoyadi";
            string[] parametre = { "@ogrencino", "@ogrenciAdiSoyadi" };
            string[] deger = { OgrNo, OgrAdiSoyadi };
            return ActionConnection.ExecuteNonQuery(kod, parametre, deger);
        }
        #endregion
    }
}
