﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    class Veriler
    {
        public static List<Kullanici> uyeler = new List<Kullanici>();
        public static List<Talep> AlisTalepleri = new List<Talep>();
        public static List<Islem> Islemler = new List<Islem>();
        public static Admin yonetici = new Admin("admin", "admin", "admin", "admin", "admin", "admin", "admin", "admin");
        public static bool UyeVarmi(string TC,string Kullaniciadi)
        {
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.TC==TC||kullanici.KullaniciAdi==Kullaniciadi)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool KayitOl(Kullanici uye)
        {
            if (UyeVarmi(uye.TC,uye.KullaniciAdi)==false&&uyeler.Contains(uye)==false)
            {
                uyeler.Add(uye);
                return true;
            }
            return false;
        }
        public static Kullanici GirisYap(string kadi,string sifre)
        {
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.KullaniciAdi == kadi && kullanici.Sifre == sifre)
                {
                    return kullanici;
                }
            }
            return null;
        }
        public static Nesne EnUcuzNesneBul(Talep talep)
        {
            Nesne enUcuz = null;
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.KullaniciAdi!=talep.Alici.KullaniciAdi)
                {
                    foreach (Nesne nesne in kullanici.Esyalar)
                    {
                        if (nesne.Ad == talep.Urun && nesne.Onay)
                        {
                            if (enUcuz == null)
                            {
                                enUcuz = nesne;
                            }
                            else if (nesne.Fiyat < enUcuz.Fiyat)
                            {
                                enUcuz = nesne;
                            }
                        }
                    }
                }
            }
            return enUcuz;
        }
        public static List<Talep> KullaniciTalepleri(Kullanici kullanici)
        {
            List<Talep> talepler = new List<Talep>();
            foreach (Talep talep in AlisTalepleri)
            {
                if (talep.Alici==kullanici)
                {
                    talepler.Add(talep);
                }
            }
            return talepler;
        }
        public static Kullanici kullaniciBul(string kullaniciadi)
        {
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.KullaniciAdi==kullaniciadi)
                {
                    return kullanici;
                }
            }
            return null;
        }
        public static void TalepKontrol()
        {
            List<Talep> tamamlananTalepler = new List<Talep>();
            foreach (Talep talep in AlisTalepleri)
            {
                Nesne alinacakNesne;
                do
                {
                    alinacakNesne = EnUcuzNesneBul(talep);
                    if (alinacakNesne != null)
                    {
                        talep.AlimiGerceklestir(alinacakNesne);
                        NesneTemizle();
                        if (talep.Tamamlandimi())
                        {
                            tamamlananTalepler.Add(talep);
                            break;
                        }
                        else if (talep.Alici.Bakiye < alinacakNesne.Fiyat || alinacakNesne.Miktar <= 0)
                        {
                            break;
                        }
                    }
                    else break;
                } while (alinacakNesne!=null&&talep.Alici.Bakiye>=alinacakNesne.Fiyat);
            }
            foreach (Talep talep1 in tamamlananTalepler)
            {
                AlisTalepleri.Remove(talep1);
            }
            NesneTemizle();
        }
        public static void NesneTemizle()
        {
            List<Nesne> silinecekler;
            foreach (Kullanici kullanici in uyeler)
            {
                silinecekler = new List<Nesne>();
                foreach (Nesne nesne in kullanici.Esyalar)
                {
                    if (nesne.Miktar == 0)
                    {
                        silinecekler.Add(nesne);
                    }
                }
                foreach (Nesne silinecek in silinecekler)
                {
                    kullanici.Esyalar.Remove(silinecek);
                }
            }

        }
    }
}
