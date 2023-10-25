using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class User 
    {
        private string _username;
        private string _password;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName 
        {
            get => _username;
            set
            {

            }
        }
        public string Password 
        {
            get => _password;
            set     
            {
                if(value == null) 
                { 
                    throw new InvalidPasswordException(nameof(value)); 
                }
                
            } 
        }
    }
}
