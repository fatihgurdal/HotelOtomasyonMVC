using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Application.Bootstrappers;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.IoC;

namespace ConsoleApplication1
{
    class Program
    {
        private static IServiceStudent _serviceStudent;
        private static IServiceFirm _serviceFirm;

        static void Main(string[] args)
        {
            //Dependency' ler Register ediliyor
            Bootstrapper.Instance
           .Bootstrap(new DependencyBootstrapper());



            //IServiceBase interface' inin hangi class ile calistigi resolve ediliyor.
            _serviceStudent = DependencyContainer.Current.Resolve<IServiceStudent>();

            ////ornek islemler
            InsertStudent();
            UpdateStudent();
            GetStudentById();
            GetAllStudents();

            Console.ReadLine();

            _serviceFirm = DependencyContainer.Current.Resolve<IServiceFirm>();
            var firm = _serviceFirm.GetById(1);
        }

        static void InsertStudent()
        {
            var student = new Student
            {
                Firstname = "Mehmet",
                Lastname = "Yıldız"
            };

            _serviceStudent.Insert(student);


            var addedStudent = _serviceStudent.GetById(student.Id);

            Console.WriteLine("Insert Test --> Firstname:{0} Lastname:{1} Id:{2}", addedStudent.Firstname, addedStudent.Lastname, addedStudent.Id);
        }

        static void GetStudentById()
        {
            var st = _serviceStudent.GetById(1);
            if (st != null)
                Console.WriteLine("GetById Test--> Id:{0}", st.Id);
            else
                Console.WriteLine("GetById Test--> Id: NULL");
        }

        static void UpdateStudent()
        {
            var updatedStudent = _serviceStudent.GetById(1);
            updatedStudent.Firstname = "Ayşe";
            updatedStudent.Lastname = "Yılmaz";

            _serviceStudent.Update(updatedStudent);

            Console.WriteLine("Update Test --> Firstname:{0} Lastname:{1} Id:{2}", updatedStudent.Firstname, updatedStudent.Lastname, updatedStudent.Id);

        }

        static void GetAllStudents()
        {
            var allrecords = _serviceStudent.GetAll();
            Console.WriteLine("GetAll Test");

            foreach (var rc in allrecords)
            {
                Console.WriteLine("Id:{0} Firstname:{1} Lastname:{2}", rc.Id, rc.Firstname, rc.Lastname);
            }
        }
    }
}
