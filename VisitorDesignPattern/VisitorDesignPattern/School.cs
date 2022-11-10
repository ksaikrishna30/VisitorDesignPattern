using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class School
    {

        public ArrayList studentList = new ArrayList();

        public School()
        {
            this.studentList.Add(new Student("Kishan"));
            this.studentList.Add(new Student("Karan"));
            this.studentList.Add(new Student("Vishal"));
            this.studentList.Add(new Student("Kapil"));
        }

        public void doHealthCheckup()
        {
            Doctor doctor = new Doctor("Dr.Sumit");
            foreach (Student student in studentList)
            {
                student.accept(doctor);
            }
        }

    }
}
