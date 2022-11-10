using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{

    public class Student : IVisitable
    {


        public String NameOfStudent;

        public String HealthStatus;

        public Student(String nameOfStudent)
        {
            this.NameOfStudent = nameOfStudent;
        }

        public String getName()
        {
            return NameOfStudent;
        }

        public String getHealthStatus()
        {
            return HealthStatus;
        }

        public void setHealthStatus(String healthStatus)
        {
            this.HealthStatus = healthStatus;
        }

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

    }
}
