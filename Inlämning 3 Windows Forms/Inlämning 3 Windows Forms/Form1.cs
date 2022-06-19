using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämning_3_Windows_Forms
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        /**
         * Returns true if the input isn't allowed, i.e if the char isn't a Digit or Backspace.
         */
        private Boolean InputAllowed(KeyPressEventArgs e)
        {
            return !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void personnummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputAllowed(e);
        }

        private void okKnapp_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void avslutKnapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void läggTillPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void AddPerson()
        {
            if (Person.SsnCheck(personnummer.Text))
            {
                Person person = new Person(förnamn.Text, efternamn.Text, personnummer.Text);
                resultBox.Text = person.ToString();
            }
            else
            {
                resultBox.Text = "Felaktigt personnummer! Försök igen.";
            }
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Person
    {

        private string förnamn;
        public string Förnamn { get { return förnamn; } }

        private string efternamn;
        public string Efternamn { get { return efternamn; } }

        private string personnummer;
        public string Personnummer { get { return personnummer; } }

        private string kön;

        public string Kön { get { return kön; } }


        public Person(string förnamn, string efternamn, string personnummer)
        {
            this.förnamn = förnamn;
            this.efternamn = efternamn;
            this.personnummer = personnummer;
            kön = GetGender();
        }

        /**
         * Returns the persons gender as a string, taken from the second to last digit of the personunmmer
         */
        private string GetGender() 
        {
            int gender = int.Parse(personnummer.ToCharArray()[personnummer.Length - 2].ToString());
            if (gender % 2 == 0) return "Kvinna"; else return "Man";
        }


        public override string ToString()
        {
            return $"Förnamn: {förnamn} \r\nEfternamn: {efternamn} \r\nPersonnummer: {personnummer} \r\nKön: {kön}";
        }

        /**
         * Returns true if the social security number is valid. 
         */
        public static Boolean SsnCheck(string _ssn)
        {
            int sum = 0;
            char[] ssn = _ssn.ToCharArray();
            if (ssn.Length == 0) return false;
            try
            {
                for (int i = 0; i < ssn.Length; i++)
                {
                    int factor = 1;
                    if (i % 2 == 0)
                    {
                        factor = 2;
                    }
                    int parsed = int.Parse(ssn[i].ToString()) * factor;
                    int dig1 = parsed % 10;
                    int dig2 = parsed / 10;
                    sum += dig1 + dig2;
                }
                if (sum % 10 == 0)
                {
                    return true;
                }
            }
            catch
            {

            }
            return false;
        }
    }
}
