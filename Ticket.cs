using System;
using System.Collections.Generic;
namespace Movie_Ticket_Bookings{
 public class Ticket{
                                    
     private string name="",password="";
       public Ticket(){}

       public Ticket(string name,string password)
       {
          this.name=name;
          this.password=password;
       }

       public string getName(){
           return name;
       }
       public string getPassword(){
           return password;
       }

                
    int[] Seats=new int[600];


 public void viewSeats(){
        for(int j=0;j<Seats.Length;j++){
            if(j%30==0){
                Console.WriteLine();
                Console.Write(Seats[j]+" ");
            }
            else if(j%10==0){
                Console.Write("      ");
                Console.Write(Seats[j]+" ");
            }

            else{ Console.Write(Seats[j]+" ");}
        }
        SwitchStatement();
    }


 public void bookTicket(){
            Console.WriteLine("\n\nEnter a Seat Number : ");
            string temp =Console.ReadLine();
            int sNum=int.Parse(temp);
            if(Seats[sNum-1]==0){
                Seats[sNum-1]=1;
                Console.WriteLine("\nYour Seat Booked Successfully");
            }
            else{
                Console.WriteLine("\nSeat Already Booked... Try Another");
            }
         viewSeats();
         SwitchStatement();
        }


 public void cancelTicket(){
    Console.WriteLine("\nEnter your seat number to cancel");
    string temp=Console.ReadLine();
    int sNum=int.Parse(temp);
    if(Seats[sNum-1]==1){
        Seats[sNum-1]=0;
        Console.WriteLine("\nYour Ticket Cancelled Successfully");
    }
    else{
        Console.WriteLine("\nTicket is not Booked");
    }
    viewSeats();
    SwitchStatement();
 }

  public void SwitchStatement(){
     Console.WriteLine("\n1.View Seats \n2.Book Ticket \n3.Cancel a Ticket \n");
     string options= Console.ReadLine();
     switch(options
     
     ){
         case "1":viewSeats();
             break;
         case "2":
             bookTicket();
             break;
         case "3":
            cancelTicket();
             break;
         default:
              Console.WriteLine("Input Invalid");
              SwitchStatement();
              break;
       }
    }
  
   }

}

