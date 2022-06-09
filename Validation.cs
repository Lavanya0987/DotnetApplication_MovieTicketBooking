using System;
using System.Collections.Generic;
namespace Movie_Ticket_Bookings{
 public class Validation
    {
        public void validate(){
       // Ticket b=new Ticket();

        List<Ticket> Tickets=new List<Ticket>();

        Ticket person1=new Ticket("ASM","Password@123");

        Ticket person2=new Ticket("Lavanya","Password@1234");

        Ticket person3=new Ticket("Karthik","Password@12345");

        Ticket person4=new Ticket("Dhilip","Password@123456");

        Ticket person5=new Ticket("Saranya","Password@123456");

        Tickets.Add(person1);

        Tickets.Add(person2);

        Tickets.Add(person3);

        Tickets.Add(person4);

        Tickets.Add(person5);

        Console.WriteLine("Welcome to our ABC Ticket...\nEnter to continue....\n1.LogIn\n2.Signup");

        string choice = Console.ReadLine();

        if(choice.Equals("1")){

        Console.WriteLine("Enter Username");

            string name=Console.ReadLine();

        Console.WriteLine("Enter Password");

            string pass=Console.ReadLine();

            foreach(Ticket s in Tickets){

               if(name.Equals(s.getName())&&pass.Equals(s.getPassword())){

                Console.WriteLine("Logged In Successfully");

                   s.SwitchStatement();}

               else{Console.WriteLine("Error"); }

               

               }

        }    

        else if(choice.Equals("2")){

        Console.WriteLine("Enter Username");

            string name=Console.ReadLine();

        Console.WriteLine("Enter Password");

            string pass=Console.ReadLine();
           
            Ticket Ticketk=new Ticket(name,pass);

            Tickets.Add(Ticketk);

            Console.WriteLine("Registered Successfully");

            Ticketk.SwitchStatement();

        }

        else{

        Console.WriteLine("Input Invalid");

        }

        }   

 

    }

}