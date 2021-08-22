using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program8
    {
       
        class teacher_accounts

        {
     
            public int id { get; set; }
            public string teachername { get; set; }
            public int Class { get; set; }
            public char section { get; set; }
            public string email { get; set; }

        }
        class ass1teacher_records

        {
           
            static public void adding_teachers(teacher_accounts new_account, List<teacher_accounts> teacher_list)
            {
                Console.WriteLine("...............TEACHER'S ACCOUNTS................");
                Console.WriteLine("\nEnter the number of teacher's accounts..");
                int record_count = int.Parse(Console.ReadLine());

                for (int i = 0; i <record_count; i++)
                {
                    Console.WriteLine("\nEnter the teacher's ID :");
                    int ID = int.Parse(Console.ReadLine());                  //read teachers id

                    Console.WriteLine("Enter the teacher's name :");
                    string NM = Console.ReadLine();                          //read teachers name

                    Console.WriteLine("Enter Class :");
                    int clss = int.Parse(Console.ReadLine());               //read teachers class

                    Console.WriteLine("Enter Section :");
                    char secn = Console.ReadLine()[0];                     //read teachers section

                    Console.WriteLine("Enter the teacher's email :");
                    string ED = Console.ReadLine();                        //read teachers email


                    new_account = new teacher_accounts();
                    new_account.id = ID;
                    new_account.teachername = NM;
                    new_account.Class = clss;
                    new_account.section = secn;
                    new_account.email = ED;
                    teacher_list.Add(new_account);

                }
            }




            static public void display_teachers(teacher_accounts new_account, List<teacher_accounts> teacher_list)
            {

                for (int i = 0; i < teacher_list.Count; i++)

                {
                    Console.WriteLine("\n\nID = " + teacher_list[i].id);
                    Console.WriteLine("Teacher Name = " + teacher_list[i].teachername);
                    Console.WriteLine("Class = " + teacher_list[i].Class);
                    Console.WriteLine("Section = " + teacher_list[i].section );
                    Console.WriteLine("Teacher Email = " + teacher_list[i].email + "\n\n");
                }

                if (teacher_list.Count < 1)
                    Console.WriteLine("\n  No teacher's data found \n");

            }
            static public void update_teachers_data(List<teacher_accounts> teacher_list)
            {
                Console.WriteLine("Enter the teacher's id to update account ..");
                int update_id = int.Parse(Console.ReadLine());

                int index = teacher_list.FindIndex(x => x.id == update_id);
                if (index > -1)
                {
                    Console.WriteLine("Enter option \n1. Name \n2. Class\n3. Section\n4. email");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.WriteLine("Enter new name to be updated ..");
                        string nn = Console.ReadLine();
                        teacher_list[index].teachername = nn;
                    }

                    if (option == 2)
                    {
                        Console.WriteLine("Enter new class to be updated ..");
                        int nc = int.Parse(Console.ReadLine());
                        teacher_list[index].Class = nc;
                    }

                    if (option == 3)
                    {
                        Console.WriteLine("Enter new section to be updated ..");
                        char ns = Console.ReadLine()[0];
                        teacher_list[index].section = ns;
                    }
                    if(option == 4)
                    {
                        Console.WriteLine("Enter new email to be updated..");
                        string ei = Console.ReadLine();
                        teacher_list[index].email = ei;
                    } 
                 
                }

                else
                    Console.WriteLine("\nIndex not found in records");

            }




            static public void delete_records(List<teacher_accounts> teacher_list)
            {
                Console.WriteLine("\nEnter the teacher's id to delete record ..");
                int delete_id = int.Parse(Console.ReadLine());
                int index = teacher_list.FindIndex(x => x.id == delete_id);

                if (index > -1)
                {
                    Console.WriteLine("\nTeacher's Name :" + teacher_list[index].teachername + "\nAllocated Class :" + teacher_list[index].Class + "\nAllocated Section :" + teacher_list[index].section +"\ngiven email:" + teacher_list[index].email);
                    Console.WriteLine("Will be deleted from records ..\n");
                    teacher_list.RemoveAt(index);
                }
               
                else
                    Console.WriteLine("ID not found in records \n");



            }


            static void Main(string[] args)
            {
                

                List<teacher_accounts> teacher_list = new List<teacher_accounts>();

            
                teacher_accounts new_account= null;

               


                while (true)
                {
                    Console.WriteLine("Enter option \n 1. Add a record \n 2. Display record  \n 3. Update data\n 4. Delete record\n");
                    //  try
                    //{
                    int choice = int.Parse(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            adding_teachers(new_account, teacher_list);
                            break;

                        case 2:
                            display_teachers(new_account, teacher_list);
                            break;

                        case 3:
                            update_teachers_data(teacher_list);
                            break;

                        case 4:
                            delete_records(teacher_list);
                            Console.WriteLine("Deleted");
                            break;

                        case 5:

                            break;



                    }

                    if (choice == 3 || choice == 5)  // breaking out of the while loop
                        break;
                
                }



            }

        }
    }

}

