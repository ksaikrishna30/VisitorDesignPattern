using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Doctor : IVisitor
    {
        private String nameOfDoctor;

        public Doctor(String nameOfDoctor)
        {
            this.nameOfDoctor = nameOfDoctor;
        }

        public String getName()
        {
            return nameOfDoctor;
        }

        public void visit(IVisitable visitable)
        {
            Student student = (Student)visitable;
            student.setHealthStatus("Good");
            Console.WriteLine("Doctor: '" + this.getName() + "' does the checkup of the student: '"
                            + student.getName()
                            + $"' and Reported health status as {student.getHealthStatus()}\n");

        }

    }
}
