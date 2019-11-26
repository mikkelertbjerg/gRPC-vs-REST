using Grpc.Core;
using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            StudentModel student;
            StudentLookupModel sid;
            string input;

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var studentClient = new Student.StudentClient(channel);

            Console.WriteLine("(1) INSPECT STUDENT\n(2) ALL STUDENTS\n(3) STUDENTS FROM FILE");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("----- ALL STUDENT IDS -----");
                    using (var requestAllStudentIds = studentClient.GetAllStudentIds(new EmptyRequest()))
                    {
                        while (await requestAllStudentIds.ResponseStream.MoveNext())
                        {
                            sid = requestAllStudentIds.ResponseStream.Current;
                            Console.Write($"{sid.Id}, ");
                        }
                    }
                    Console.WriteLine("\n---------------------------------\n");
                    Console.WriteLine("SELECT STUDENT ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    StudentLookupModel requestStudent = new StudentLookupModel { Id = id };
                    student = await studentClient.GetStudentInfoAsync(requestStudent);

                    Console.WriteLine($"Student with id: {requestStudent.Id}");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Name: {student.FirstName} {student.LastName} " +
                                $"\nGender: {student.Gender}" +
                                $"\nAge: {student.Age}" +
                                $"\nEmail: {student.EmailAddress}" +
                                $"\nPhone: {student.PhoneNumber}" +
                                $"\nSchool: {student.School}" +
                                $"\n---------------------------------");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("----- ALL STUDENTS -----");
                    using (var requestAllStudents = studentClient.GetAllStudents(new EmptyRequest()))
                    {
                        while (await requestAllStudents.ResponseStream.MoveNext())
                        {
                            student = requestAllStudents.ResponseStream.Current;
                            Console.WriteLine($"Name: {student.FirstName} {student.LastName} " +
                                $"\nGender: {student.Gender}" +
                                $"\nAge: {student.Age}" +
                                $"\nEmail: {student.EmailAddress}" +
                                $"\nPhone: {student.PhoneNumber}" +
                                $"\nSchool: {student.School}" +
                                $"\n---------------------------------");
                        }
                    }
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Enter file path");
                    string filePath = Console.ReadLine();
                    ExcelRequest excelRequest = new ExcelRequest { FilePath = filePath };
                    using (var requestStudentsFromExcel = studentClient.GetAllStudentsFromExcel(new ExcelRequest(excelRequest)))
                    {
                        while(await requestStudentsFromExcel.ResponseStream.MoveNext())
                        {
                            student = requestStudentsFromExcel.ResponseStream.Current;
                            Console.WriteLine($"Name: {student.FirstName} {student.LastName} " +
                                $"\nGender: {student.Gender}" +
                                $"\nAge: {student.Age}" +
                                $"\nEmail: {student.EmailAddress}" +
                                $"\nPhone: {student.PhoneNumber}" +
                                $"\nSchool: {student.School}" +
                                $"\n---------------------------------");
                        }
                    }
                        break;
            }
        }
    }
}
