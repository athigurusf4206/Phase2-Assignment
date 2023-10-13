using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureParkRideTicketingApplication
{   
    /// <summary>
    /// This class is used to get the username age weight phonenumber,walletbalance 
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// This is property for getting the username
        /// </summary>
        /// <value>this is string type</value>
        public String  UserName { get; set; }
        /// <summary>
        /// This is property for getting the age of the user
        /// </summary>
        /// <value>return type is int</value>
        public int Age { get; set; }
        /// <summary>
        /// This is property for getting the weigth of the user.
        /// </summary>
        /// <value>return type is double</value>
        public double Weight{get;set;}
        /// <summary>
        /// This is property for getting the phonenumber of the user..
        /// </summary>
        /// <value>return type is long</value>
        public long PhoneNumber{get;set;}
        /// <summary>
        /// This is property of getting the balance amount of the user
        /// </summary>
        /// <value>return type double</value>
            public double WalletBalance{get;set;}
        /// <summary>
        /// This is autoincrement cardid
        /// </summary>
        private string _cardId;
        private static int s_id1=1000;
    /// <summary>
    /// This is propertyu of card id
    /// </summary>
    /// <value>return type is string</value>
        public string CardId{
            get{
                return _cardId;
            }
        }
        /// <summary>
        /// This is constructor for the object to initiliaze the value
        /// </summary>
        /// <param name="userName">To passing the username</param>
        /// <param name="age">to passing the age of the user</param>
        /// <param name="weight">To passing the weight of the user</param>
        /// <param name="phoneNumber"> To passing the phonenumber of the user</param>
        /// <param name="walletbalance"> to passing the walletbalance of the user</param>
        public UserDetails(string userName,int age,double weight,long phoneNumber,double walletbalance){
            s_id1++;
            UserName=userName;
            Age=age;
            Weight=weight;
            PhoneNumber=phoneNumber;
            WalletBalance=walletbalance;
            _cardId="CID"+s_id1;


        }
    }
}