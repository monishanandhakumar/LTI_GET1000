using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InHeritanceEg
{
    //Base or parent
    class Exam
    {
        public int id { get; set; }
        public string examname { get; set; }

        internal Exam(int id, string examname)
        {
            this.id = id;
            this.examname = examname;
        }

       internal void Examinfo()
        {
            Console.WriteLine("Examid:{0} || ExamName:{1}",id,examname);
        }


    }

    //derived or child class
    class Student :Exam
    {
        public int id { get; set; }
        public string sname { get; set; }
        public string contactno { get; set; }
        public string status { get; set; }

        internal Student(int id, string examname,int sid,string sname,string contactno,string status):base(id,examname)
        {
           this. id = sid;
            this.sname = sname;
            this.contactno = contactno;
            this.status = status;
        }

        internal void PrintData()
        {
            Console.WriteLine("sid:{0} || sname:{1}|| contactno:{2}",id,sname,contactno);
        }
        internal void Examstatus()
        {
            Console.WriteLine("Eid :{0} ||sid:{1} || status:{2}", base.id, id, status);
        }

    }

    
    class GovtExam
    {

        static void Main()
        {
            Student student = new Student(1000,"TRB",101, "Hari", "890677900","Attended");
            student.Examinfo(); //calling parent class method

            student.PrintData();

            student.Examstatus();
        }
    }
}
