using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace AdventureParkRideTicketingApplication
{
    /// <summary>
    /// This is enum for ridetype
    /// </summary>
    public enum RideTypeHistoryclass{Select,Water,Dry}
    /// <summary>
    /// This is enum for ridestatus...
    /// </summary>
    public enum RideStatusClass{Default,Booked,Cancelled}
        /// <summary>
        /// this is class for getting the ridehistory details
        /// </summary>
    public class RideHistoryDetails
    {

        /// <summary>
        /// this is property for getting card id..
        /// </summary>
        /// <value>return type  string</value>
        public string CardID { get; set; }
        /// <summary>
        ///  this is property for getting rideid
        /// </summary>
        /// <value>return type string</value>
        public string RideId{get;set;}
        /// <summary>
        /// this is proprty for getting ride type
        /// </summary>
        /// <value>return type enum ridetypehistory</value>
        public RideTypeHistoryclass RideType{get;set;}
        /// <summary>
        /// this is property for getting the ridetime
        /// </summary>
        /// <value>return datetime</value>
        public DateTime RideTime{get;set;}
            /// <summary>
            /// This is the propery for getting ridestatus
            /// </summary>
            /// <value>return type ridestatus enum</value>
            public RideStatusClass RideStatus{get;set;}

        private string _rideHistoryId;
        
        private static int s_id3=5000;
        /// <summary>
        ///  this is property for getting the ridehistory id
        /// </summary>
        /// <value>return type string</value>
        public string RideHistoryId{
            get{
                return _rideHistoryId;
            }
        }
        /// <summary>
        ///  this is constructor to initiliaze object value
        /// </summary>
        /// <param name="cardid"></param>
        /// <param name="rideid"></param>
        /// <param name="rideType"></param>
        /// <param name="ridetime"></param>
        /// <param name="rideStatus"></param> <summary>
        /// 
        /// </summary>
        /// <param name="cardid"></param>
        /// <param name="rideid"></param>
        /// <param name="rideType"></param>
        /// <param name="ridetime"></param>
        /// <param name="rideStatus"></param>
        public RideHistoryDetails(string cardid,string rideid,RideTypeHistoryclass rideType,DateTime ridetime,RideStatusClass rideStatus){
            s_id3++;
            CardID=cardid;
            RideId=rideid;
            RideType=rideType;
            RideTime=ridetime;
            RideStatus=rideStatus;
            _rideHistoryId="RIHD"+s_id3;
        }

    }
}