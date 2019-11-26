using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExcelDataReader;
using Grpc.Core;
using GrpcServer.Database;
using Microsoft.Extensions.Logging;

namespace GrpcServer.Services
{
    public class StudentsService : Student.StudentBase
    {
        private readonly ILogger<StudentsService> _logger;
        private readonly DatabaseConnection _db;

        public StudentsService(ILogger<StudentsService> logger)
        {
            _logger = logger;
            _db = new DatabaseConnection();
        }

        public override Task<StudentModel> GetStudentInfo(StudentLookupModel request, ServerCallContext context)
        {
            StudentModel student = _db.GetStudent(request.Id);
            return Task.FromResult(student);
        }

        public override async Task GetAllStudents(EmptyRequest request, IServerStreamWriter<StudentModel> responseStream, ServerCallContext context)
        {
            List<StudentModel> students = _db.GetAllStudents();

            foreach (StudentModel student in students)
            {
                await responseStream.WriteAsync(student);
            }
        }

        public override async Task GetAllStudentIds(EmptyRequest request, IServerStreamWriter<StudentLookupModel> responseStream, ServerCallContext context)
        {
            List<StudentLookupModel> ids = _db.GetAllStudentIds();

            foreach (StudentLookupModel id in ids)
            {
                await responseStream.WriteAsync(id);
            }
        }

        public override async Task GetAllStudentsFromExcel(ExcelRequest request, IServerStreamWriter<StudentModel> responseStream, ServerCallContext context)
        {
            List<StudentModel> students = GetAllStudents(request.FilePath);
            foreach (StudentModel student in students)
            {
                await responseStream.WriteAsync(student);
            }
        }

        private List<StudentModel> GetAllStudents(string filePath)
        {
            List<StudentModel> students = new List<StudentModel>();
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            students.Add(new StudentModel
                            {
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Gender = reader.GetString(3),
                                Age = reader.GetInt32(4),
                                EmailAddress = reader.GetString(5),
                                School = reader.GetString(6)

                            });
                        }
                    } while (reader.NextResult());
                }
            }
            return students;
        }
    }
}
