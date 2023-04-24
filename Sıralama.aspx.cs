using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace Not_Sıralama
{
    public partial class Sıralama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] adlar = new string[3];
            int[] notlar = new int[3];
            for(int i = 0; i< adlar.Length; i++)
            {
                adlar[i] = Interaction.InputBox((i + 1) + ". öğrencinin adını giriniz:");
                notlar[i] = Convert.ToInt32(Interaction.InputBox(adlar[i] + " isimli öğrencinin "+ (i+1)+". notunu giriniz:"));
            }
            int ebn = notlar[0];
            string ebs = adlar[0];

            int ekn = notlar[0];
            string eks = adlar[0];

            for (int i =0; i < 3; i++)
            {
                if (ebn < notlar[i])
                {
                    ebn = notlar[i];
                    ebs =adlar[i];
                }

                if (ekn > notlar[i])
                {
                    ekn = notlar[i];
                    eks = adlar[i];
                }
            }
            string sonuc = "en büyük not " + ebs + " isimli öğrenciye ait " + ebn + " notdur. <br>"+
                "en küçük not " + eks + " isimli öğrenciye ait " + ekn + " notdur.";
            Response.Write(sonuc);
        }
    }
}