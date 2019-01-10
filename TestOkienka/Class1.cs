using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



        public void ContainsMethod()

        {

        
           


        }


    }


}





