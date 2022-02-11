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
            Console.WriteLine("Exam constructor");
            this.id = id;
            this.examname = examname;
        }

       internal void Examinfo()
        {
            Console.WriteLine("Examid:{0} || ExamName:{1}",id,examname);
        }
        ~Exam()
        {
            Console.WriteLine("Exam destructor");
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
            Console.WriteLine("Student constructor");
            this. id = sid;
            this.sname = sname;
            this.contactno = contactno;
            this.status = status;
        }

        internal void PrintData()
        {
            Console.WriteLine("sid:{0} || sname:{1}|| contactno:{2}",id,sname,contactno);
        }
       protected void Examstatus()
        {
            Console.WriteLine("Eid :{0} ||sid:{1} || status:{2}", base.id, id, status);
        }
        ~Student()
        {
            Console.WriteLine("Student destructor");
        }
    }

    class  ExamResult:Student
    {
        public int score { get; set; }
                           //exam                 //student                                               //examresult
       internal ExamResult(int id, string examname, int sid, string sname, string contactno, string status,int score):base(id,examname,sid,sname,contactno,status)
        {
            Console.WriteLine("ExamResult constructor");
            this.score = score;
        }

        internal void Result()
        {
            Examstatus();
            Console.WriteLine("Ename:{0}|| Sid:{1} || Score:{2}",examname,id,score);
        }

        ~ExamResult()
        {
            Console.WriteLine("ExamResult destructor");
        }
        
    }
    class GovtExam
    {

        static void Main()
        {
            /*  Student student = new Student(1000,"TRB",101, "Hari", "890677900","Attended");
              student.Examinfo(); //calling parent class method

              student.PrintData();*/

            //student.Examstatus();

            ExamResult examResult = new ExamResult(1000, "TRB", 101, "Hari", "890677900", "Attended", 190);
            examResult.Examinfo(); //grandparent
            examResult.Result();

          
        }
    }
}
