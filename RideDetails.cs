using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureParkRideTicketingApplication
{
    /// <summary>
    /// This is enum type of ride type to select whether watet or dry
    /// </summary>
    public enum RideTypeclass{Select,Water,Dry}
    /// <summary>
    /// This is the class for getting the ride details....
    /// </summary>
    public class RideDetails
    {

        /// <summary>
        /// This is property from getting the ridename;
        /// </summary>
        /// <value>return type string</value>
        public string RideName { get; set; }
        /// <summary>
        /// This is the property for getting the ridetype
        /// </summary>
        /// <value>return the ridetypeclass enum</value>
        public RideTypeclass RideType{get;set;}
        /// <summary>
        /// This is property for getting the min agelimit
        /// </summary>
        /// <value>return type is integer.</value>
        public int MinAgeLimit{get;set;}
        /// <summary>
        /// This is the property for getting the maxagelimit..
        /// </summary>
        /// <value>return type integer</value>
        public int MaxAgeLimit{get;set;}
            /// <summary>
            /// This is property of getting the min weight
            /// </summary>
            /// <value>return type double</value>
        public double MinWeight{get;set;}
        /// <summary>
        /// This is property of getting the max weight
        /// </summary>
        /// <value>return type double </value>
        public double MaxWeight{get;set;}
        /// <summary>
        /// this is the property of getting rideprice
        /// </summary>
        /// <value>return type double</value>
        public double RidePrice{get;set;}
        /// <summary>
        /// This is property for getting the rideid
        /// </summary>
        private string _rideId;

        private static int s_id2=200;
        /// <summary>
        /// This is property of getting ride id..
        /// </summary>
        /// <value></value>
            public string RideId{
            get{
                return _rideId;
            }
        }
        /// <summary>
        /// This is constructor for initliaze the object value.
        /// </summary>
        /// <param name="ridename"></param>
        /// <param name="ridetype"></param>
        /// <param name="minagelimit"></param>
        /// <param name="maxagelimit"></param>
        /// <param name="minweigt"></param>
        /// <param name="maxweigth"></param>
        /// <param name="rideprice"></param> <summary>
        /// 
        /// </summary>
        /// <param name="ridename"></param>
        /// <param name="ridetype"></param>
        /// <param name="minagelimit"></param>
        /// <param name="maxagelimit"></param>
        /// <param name="minweigt"></param>
        /// <param name="maxweigth"></param>
        /// <param name="rideprice"></param>
            public RideDetails(string ridename,RideTypeclass ridetype,int minagelimit,int maxagelimit,double minweigt,double maxweigth,double rideprice){
            s_id2++;
            RideName=ridename;
            RideType=ridetype;
            MinAgeLimit=minagelimit;
            MaxAgeLimit=maxagelimit;
            MinWeight=minweigt;
            MaxWeight=maxweigth;
            RidePrice=rideprice;
            _rideId="RID"+s_id2;
        }
    }
}