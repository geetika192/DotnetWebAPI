using System;
using EfP.Domain;
using EfP.Repository;

namespace EfP
{
    class Controller
    {//Allocating the memory of the interface
        Irepo repo = (Irepo)new Repo();
        public void UserController()
        {
            User user = new User();

            Console.WriteLine("-------------Welcome To UserController----------------\n");
            Console.WriteLine("\nList of the Operations You Can Perform On UserController:\n\n1.)Insert New User\n2.)Update The Existing User\n3.)Delete The Existing User\n4.)Search the User By User_Td\n5.)Get all User List\n");
            Console.WriteLine("Enter the Operation Number You Want to perform");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Enter FirstName");
                    Console.WriteLine("Enter LastName");
                    Console.WriteLine("Enter UserName");
                    Console.WriteLine("Enter Gender");
                    Console.WriteLine("Enter Country");

                    int reult = repo.Add_User(new User
                    {
                        UserFirstName = Console.ReadLine(),
                        UserLastName = Console.ReadLine(),
                        UserName = Console.ReadLine(),
                        Gender = Console.ReadLine(),
                        Country = Console.ReadLine()
                    });
                    Console.WriteLine(reult);
                    break;


                case 2:
                    System.Console.WriteLine("Enter Id");
                    int Userid = Convert.ToInt32(Console.ReadLine());
                    var Record_Found = repo.Search_user_By_User_Id(Userid);
                    if (Record_Found != null)
                    {
                        Record_Found.UserID = Userid;
                        Console.WriteLine("Enter UserFirstName");
                        Record_Found.UserFirstName = Console.ReadLine();
                        Console.WriteLine("Enter UserLastName");
                        Record_Found.UserLastName = Console.ReadLine();
                        Console.WriteLine("Enter UserName");
                        Record_Found.UserName = Console.ReadLine();
                        Console.WriteLine("Enter Gender");
                        Record_Found.Gender = Console.ReadLine();
                        Console.WriteLine("Enter country");
                        Record_Found.Country = Console.ReadLine();
                        repo.Update_User();
                        Console.WriteLine("Record Updated SuccessFully!!!!!");
                    }
                    else
                    {
                        Console.WriteLine("No record Found");
                    }
                    break;


                case 3:
                    Console.WriteLine("Enter UserId");
                    int id = Convert.ToInt32(Console.ReadLine());
                    int deleterecord = repo.Delete_User(id);
                    if (deleterecord == 0)
                    {
                        Console.WriteLine("No Record Exists");
                    }
                    else
                    {
                        System.Console.WriteLine("Record Deleted Successfully!!!!!!!");
                    }
                    break;


                case 4:
                    Console.WriteLine("Enter UserId");
                    int UId = Convert.ToInt32(Console.ReadLine());
                    var Fetch_Record = repo.Search_user_By_User_Id(UId);
                    if (Fetch_Record.UserName == null)
                    {
                        Console.WriteLine("No Record Found");
                    }
                    Console.WriteLine(Fetch_Record.UserName);
                    break;


                case 5:
                    var Fetch_Records = repo.Get_User_List();
                    if (Fetch_Records == null)
                    {
                        Console.WriteLine("No Record Found");
                    }
                    else
                    {
                        foreach (var i in Fetch_Records)
                        {
                            Console.WriteLine(i.UserFirstName + " " + i.UserLastName + "\n" + i.UserName + '\n' + i.Country);
                            Console.ReadLine();
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }

        }

    }

    class Program
    {
        static void Main()
        {
            Controller p = new Controller();
            p.UserController();
        }
    }
}
