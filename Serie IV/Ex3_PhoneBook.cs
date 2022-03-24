using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class PhoneBook
    {
        private Dictionary<string, string> _annuaire;

        public PhoneBook()
        {
            _annuaire = new Dictionary<string, string>();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length == 10 && phoneNumber[0] == '0' && phoneNumber[1] != '0')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContainsPhoneContact(string phoneNumber)
        {
            return _annuaire.ContainsKey(phoneNumber);
        }

        public void PhoneContact(string phoneNumber)
        {
            if(ContainsPhoneContact(phoneNumber) == true)
            {
                Console.WriteLine(phoneNumber);
            }

        }

        public bool AddPhoneNumber(string phoneNumber, string name)
        {
            if(IsValidPhoneNumber(phoneNumber) == true && ContainsPhoneContact(phoneNumber) == false)
            {
                _annuaire.Add(phoneNumber, name);
                return true;
            }
            else
            {
            return false;
            }
        }

        public bool DeletePhoneNumber(string phoneNumber)
        {
            if (IsValidPhoneNumber(phoneNumber) && ContainsPhoneContact(phoneNumber))
            {
                _annuaire.Remove(phoneNumber);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayPhoneBook()
        {
            Console.WriteLine("Annuaire Téléphonique :");
            Console.WriteLine("-----------------------");
            foreach(KeyValuePair<string,string> item in _annuaire)
            {
                Console.WriteLine(item.Key + " ; " + item.Value);
            }
            Console.WriteLine("-----------------------");
        }
    }
}
