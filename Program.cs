using System;
using System.Collections.Generic;
using AdventureParkRideTicketingApplication;
namespace AdventureParkTicketingApplication;


class Program{
    // create a list of object of userDetails,rideDetails,RidehistoryDetails
    static List<UserDetails>userList=new List<UserDetails>();
    static List<RideDetails>RideDetailsList=new List<RideDetails>();

    static List<RideHistoryDetails>RideHistoryDetailsList=new List<RideHistoryDetails>();

    public static UserDetails s_CurrentUserLogged;
    public static void Main(string[] args)
    {   //add the default list items..
        defaultdetailsadd();
        bool mainMenu=true;
        do{
            System.Console.WriteLine("Welcome to Adventure Park Ride Ticketing Application......................");
            System.Console.WriteLine("Enter the Options You want to do 1.Registration 2.Login 3.Exit");


            //Ask the user to enter the options menu they want...
            bool temp=int.TryParse(Console.ReadLine(),out int options);
            while(!temp){
                System.Console.WriteLine("You Enter wrong Integer Please Enter the options Again 1.Registration 2.Login 3.Exit");
                temp=int.TryParse(Console.ReadLine(),out options);
            }
            //Registration.
            if(options==1){
                Registration();

                
            //login...
            }
            else if(options==2){
                //calling the login methods..
              login();



            }
            //exit.
            else if(options==3){
                
                mainMenu=false;

            }
            else{
                System.Console.WriteLine("You entered Wrong options try again!...........");
                mainMenu=true;
            }
        }while(mainMenu);
    }
    public static void Registration(){
//         •	Name
// •	Age
// •	Weight
// •	WalletBalance
// •	PhoneNumber

    System.Console.WriteLine("Enter your Name: ");
    string name=Console.ReadLine();
    //get the weigth input from user

    System.Console.WriteLine("Enter your Age: ");
    bool temps=int.TryParse(Console.ReadLine(),out int age);
    while(!temps){
        System.Console.WriteLine("Enter the invalid age format try again and enter again");
        temps=int.TryParse(Console.ReadLine(),out age);
    }
    System.Console.WriteLine("Enter your Weigth:");
    bool temp=int.TryParse(Console.ReadLine(),out int Weight);
    while(!temp){
        System.Console.WriteLine("Enter the invalid weight input please enter again");
        temp=int.TryParse(Console.ReadLine(),out Weight);

    }
    //get the walletbalance
    System.Console.WriteLine("Enter your initial wallet balance");
    bool temp1=Double.TryParse(Console.ReadLine(),out double walletbalance);
    while(!temp1){
         System.Console.WriteLine("Enter the invalid Amount input please enter again");
        temp1=Double.TryParse(Console.ReadLine(),out walletbalance);
    }
    //get the user phone number
    System.Console.WriteLine("Enter your phone number..");
    
    bool temp2=long.TryParse(Console.ReadLine(),out long phoneNumber);
    while(!temp2){
        System.Console.WriteLine("Enter the invalid phonenumber format input please enter again");
        temp2=long.TryParse(Console.ReadLine(),out phoneNumber);
    }
    UserDetails useobj=new UserDetails(name,age,Weight,phoneNumber,walletbalance);
    System.Console.WriteLine("Your are successfull Registrated   "+useobj.CardId +"is your card id");
    userList.Add(useobj);
    }







       public static bool isvalidPhonenumber(long phoneNumber){
        //Check the phone is 10 digit or not.....
    if(phoneNumber>999999999 &&phoneNumber<=9999999999){
        return true;
    }
    else{
        return false;
    }
    }
    
    

    
    
    //Adding all default details add methods
    public static void defaultdetailsadd(){
        //Adding all default userlist 
        userList.Add(new UserDetails("user1",5,12,9999999999,500));
        userList.Add(new UserDetails("user2",13,39,8833884488,300));
        userList.Add(new UserDetails("user3",45,80,7656635533,600));
        userList.Add(new UserDetails("user4",30,35,8765774985,100));
        userList.Add(new UserDetails("user5",20,30,9857646543,1000));
         //Adding all default RideDetailsList 
        RideDetailsList.Add(new RideDetails("DryGame",RideTypeclass.Dry,5,10,12,20,50));
        RideDetailsList.Add(new RideDetails("DryGame",RideTypeclass.Dry,10,17,20,35,100));
        RideDetailsList.Add(new RideDetails("DryGame",RideTypeclass.Dry,18,65,35,90,200));
        RideDetailsList.Add(new RideDetails("watergame",RideTypeclass.Water,5,10,12,20,50));
        RideDetailsList.Add(new RideDetails("watergame",RideTypeclass.Water,10,17,20,35,100));
        RideDetailsList.Add(new RideDetails("watergame",RideTypeclass.Water,18,65,35,90,200));
 //Adding all default RideHistoryDetailsList 
    RideHistoryDetailsList.Add(new RideHistoryDetails("CID1001","RID201",RideTypeHistoryclass.Dry,new DateTime(2023,08,08,12,15,00),RideStatusClass.Booked));
    RideHistoryDetailsList.Add(new RideHistoryDetails("CID1002","RID205",RideTypeHistoryclass.Water,new DateTime(2023,08,15,14,20,00),RideStatusClass.Booked));
    RideHistoryDetailsList.Add(new RideHistoryDetails("CID1003","RID206",RideTypeHistoryclass.Water,new DateTime(2023,08,27,10,45,00),RideStatusClass.Cancelled));
    RideHistoryDetailsList.Add(new RideHistoryDetails("CID1004","RID203",RideTypeHistoryclass.Dry,new DateTime(2023,09,07,16,30,00),RideStatusClass.Booked));
    RideHistoryDetailsList.Add(new RideHistoryDetails("CID1005","RID206",RideTypeHistoryclass.Water,new DateTime(2023,09,20,15,40,00),RideStatusClass.Cancelled));

    }
    
    
    
    //Methods for login ...
    public static void login(){
        System.Console.WriteLine("Welcome to login please enter your login id: ");
        string loginid=Console.ReadLine();
        bool validation=false;
        foreach(UserDetails i in userList){
            //check userdetails list . userid is equal to user give id....
            if(i.CardId==loginid){
                //use the static varaible for current user logged in...
                s_CurrentUserLogged=i;
                validation=true;
                //calling the loginsubmenu methods.......
                loginsubmenu();
            }
           
        }
        //if the no user id is present print invalid id.....
        if(!validation){
            System.Console.WriteLine("Enter invalid user id please try again");
        }
    }
    public static void loginsubmenu(){
        bool loginsubmenu=true;
       
        do{
            
             System.Console.WriteLine("Enter the options you want 1.Book Ride 2,Cancel Ride ,3.Wallet Recharge, 4.Ridehistory, 5.WalletBalance, 6.exit");
            //ask the user to enter the options..
        bool temp=int.TryParse(Console.ReadLine(),out int options);
        //checking input format
        while(!temp){
            System.Console.WriteLine("Enter invalid format please try again!.and please enter the options again..");
            temp=int.TryParse(Console.ReadLine(),out options);


        }
        //if the user is press options 1 means it is book ride...
        if(options==1){
            //display the ridedetails list 
            System.Console.WriteLine("rideDetails list............");
            riderlistprint();
            System.Console.WriteLine("Please enter the rideid you want");
            //ask the user which ride they want....
            string rideid=Console.ReadLine();
            bool idchecker=false;
            //iterator through foreach loop in the ridedetails list....
            foreach(RideDetails i in RideDetailsList){
                //if the ride is present or not in ridedetails list....
                if(i.RideId==rideid){
                    idchecker=true;
                    //check for water ride condition
                    if(i.RideType==RideTypeclass.Water){
                        //check for minweight and maxmium weigt
                             if((s_CurrentUserLogged.Weight>=i.MinWeight)&&(s_CurrentUserLogged.Weight<=i.MaxWeight)){
                                //check for insufficient balance if not means procedure will be continue..
                            if(s_CurrentUserLogged.WalletBalance>=i.RidePrice){
                                s_CurrentUserLogged.WalletBalance-=i.RidePrice;
                                DateTime add=DateTime.Now.AddMinutes(30);
                                // Add the all the details to the rideDetailshistory list.....
                                RideHistoryDetailsList.Add(new RideHistoryDetails(s_CurrentUserLogged.CardId,i.RideId,RideTypeHistoryclass.Water,add,RideStatusClass.Booked));
                                System.Console.WriteLine("You are Successfully opted current ride and your Ride time is "+RideHistoryDetailsList[(RideHistoryDetailsList.Count)-1].RideTime);
                            }
                            else{
                                System.Console.WriteLine("Insufficient wallet balance. Recharge your wallet");
                            }

                        }
                        // Due to weight limit condition is not sastified.....
                        else{
                            System.Console.WriteLine("You cannot take selected ride due to weight limit......");
                        }
                    }
                    //if the ridetype is dry means condiition checking....
                    else if(i.RideType==RideTypeclass.Dry){
                        // check for agelimit
                        if((s_CurrentUserLogged.Age>=i.MinAgeLimit)&&(s_CurrentUserLogged.Age<=i.MaxAgeLimit)){
                            //checking for sufficient balance...
                            if(s_CurrentUserLogged.WalletBalance>=i.RidePrice){
                                s_CurrentUserLogged.WalletBalance-=i.RidePrice;
                                DateTime add=DateTime.Now.AddMinutes(30);
                                //add the item to the ridehistorylist....
                                RideHistoryDetailsList.Add(new RideHistoryDetails(s_CurrentUserLogged.CardId,i.RideId,RideTypeHistoryclass.Dry,add,RideStatusClass.Booked));
                                System.Console.WriteLine("You are Successfully opted current ride and your Ride time is "+RideHistoryDetailsList[(RideHistoryDetailsList.Count)-1].RideTime);
                            }
                            else{
                                System.Console.WriteLine("Insufficient wallet balance. Recharge your wallet");
                            }

                        }
                        else{
                            System.Console.WriteLine("You cannot take selected ride due to right age limit......");
                        }

                    }
                }
                
              
            }
            //if no ride is means invalid id enter..
            if(!idchecker){
                System.Console.WriteLine("Invalid id enter........");
            }
             
        }
        //cancelling the ride..
        else if(options==2){
           cancelride();
        }
        //Wallet Recharege...
        else if(options==3){
        
            System.Console.WriteLine("Enterr the amount you want to add....");
            double amount=Convert.ToDouble(Console.ReadLine());
            //calling the methods to add the amount to the balance...
            recharge(amount);
            System.Console.WriteLine("Your current Balance is "+s_CurrentUserLogged.WalletBalance);

        }
        else if(options==4){
            //print the ride history of the current user...
            Ridehistorylist();


        }
        else if(options==5){
            //show the amount in the wallet...
            walletbalancshow();
        }
        else if(options==6){
            //for the exit the process..
            loginsubmenu=false;
        }
        }while(loginsubmenu);
    }
    public static void userlistprint(){
        foreach(UserDetails i in userList){
            System.Console.WriteLine(i.CardId);
        }
    }
    public static void riderlistprint(){
        foreach(RideDetails i in RideDetailsList){
            System.Console.WriteLine("Ride Id: "+i.RideId+" Ride Name: "+i.RideName+" Ride Type: "+i.RideType +" MinAgeLimit "+i.MinAgeLimit+" MaxAgeLimit "+i.MaxAgeLimit+" Minweigth "+i.MinWeight+" MaxWeigth "+i.MaxWeight +" Rideprice "+i.RidePrice);
        }
    }
    public static void Ridehistorylist(){
        foreach(RideHistoryDetails i in RideHistoryDetailsList){
            //check for only the current user ride history..
            if(s_CurrentUserLogged.CardId==i.CardID){
               System.Console.WriteLine("RideHistoryId :"+i.RideHistoryId+" CardID :"+i.CardID+" RideId : "+i.RideId+" RideTime :"+i.RideTime+" RideStatus "+i.RideStatus);
              
            }
        }
    }
    public static void cancelridelist(){
        foreach(RideHistoryDetails i in RideHistoryDetailsList){
            if((s_CurrentUserLogged.CardId==i.CardID)&&(i.RideStatus==RideStatusClass.Booked)){
                System.Console.WriteLine("RideHistoryId :"+i.RideHistoryId+" CardID :"+i.CardID+" RideId : "+i.RideId+" RideTime :"+i.RideTime+" RideStatus "+i.RideStatus);
            }
        }
    }
    public static void cancelride(){
        cancelridelist();
        System.Console.WriteLine("Enter the Ridehistory id you want to cancelled......");
        string rideHistory=Console.ReadLine();
        bool validation=false;
        foreach(RideHistoryDetails i in RideHistoryDetailsList){
            //check for ridehistory id is present or not and if the current user is cancel the ride or not...
            if(i.RideHistoryId==rideHistory &&i.CardID==s_CurrentUserLogged.CardId){
                validation=true;
                //change the ridestatus to cancelled.
                i.RideStatus=RideStatusClass.Cancelled;
                double price=getprice(i.RideId);
                //add the amount to the wallet...
                s_CurrentUserLogged.WalletBalance+=price;
                System.Console.WriteLine($"RideHistoryID :{i.RideHistoryId} cancelled successfully”.");
                
            }
            

        }
        if(!validation){
            System.Console.WriteLine("Invalid RideHistoryID");
        }
    }
    public static double getprice(string rideid){
        foreach(RideDetails i in RideDetailsList){
            if(i.RideId==rideid){
                return i.RidePrice;
            }
        }
        return 0;
    }
    //method to recharge the balance
    public static void recharge(double amount){
        s_CurrentUserLogged.WalletBalance+=amount;
    }
    public static void walletbalancshow(){
        //show the current user balance..
        System.Console.WriteLine("Your current wallet balance is .."+s_CurrentUserLogged.WalletBalance);
    }
    }
 

