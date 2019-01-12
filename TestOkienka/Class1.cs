using System;
using System.Data.SQLite;
using System.Diagnostics.PerformanceData;
using System.Dynamic;
using System.Linq;
using System.Windows;


namespace TestOkienka
{
    class PasswordChecker

    {

        String passConst = "Zupa Pomidorowa";
        String[] passArray = new String[3]
               {"kupa" , "gowno" , "sraka"};


        public void EqualMethod(string passWrittenEM)
       

        {
            while (true)
            {

                if (passWrittenEM.Equals(passConst))
                {
                    MessageBox.Show("jestes super odgadles haslo");
                    break;
                }
                else
                {
                    MessageBox.Show("jestes Baran spróbuj ponownie:");
                    break;
                }

            }
        }

        public void ArrayMethod(string passWrittenAM)
            {
                
                while (true)
                {
                    
                    if (passArray.Contains(passWrittenAM))
                    {
                        MessageBox.Show("Swietnie! Kupa radosci!");
                        break;
                    }

                    else
                    {
                        MessageBox.Show("Wez sie do kupy chopie!");
                        break;

                    }

                }
            }


        public Boolean ContainsMethod(string passWrittenCM)

        {
            
            
                while (true)
                {

                    if (passWrittenCM.Contains("tajemnica"))
                    {
                        MessageBox.Show("Dobra robota");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("wpisz ponownie haslo");

                        return false;

                    }
                    
            }


        }

        
    }


}





