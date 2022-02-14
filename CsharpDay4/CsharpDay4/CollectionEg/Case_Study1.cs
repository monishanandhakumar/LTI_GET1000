using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_GenericsEg
{
    enum Feedback
    {
        poor=1,good,vergood,Excellent
    }
    class School
    {
      static  string Schoolname;

       public string branchname { get; set; }
        static School()

        {
            Schoolname = "KV";

        }
    }

    class Student:School
    {
        public int id { get; set; }
        public string name { get; set; }
        public int physics { get; set; }
        public int chemistry { get; set; }
        public int maths { get; set; }

        internal Student (int id,string name,int physics,int chemistry,int maths)
        {
            this.id = id;
            this.name = name;
            this.physics = physics;
            this.chemistry = chemistry;
            this.maths = maths;
        }

        internal void CutOffCalculator()
        {
            try
            {
                branchname = "BioMaths";
                float cutoff = ((physics + chemistry + maths) / 3);
               
                if (cutoff > 190)
                {
                    Console.WriteLine("id:{0} || name:{1} || cutoff:{2} ||branch:{3}||Fb:{4}", id, name, cutoff, branchname, Feedback.Excellent);
                }
                else if (cutoff > 170 && cutoff < 189)
                {
                    Console.WriteLine("id:{0} || name:{1} || cutoff:{2} ||branch:{3}||Fb:{4}", id, name, cutoff, branchname, Feedback.good);
                }
                Console.WriteLine("------------------");
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Enter Valid Details!!!" );
            }
           
        }

    }
    class Case_Study1
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Sai", 190, 195, 199));
            students.Add(new Student(2, "Anu", 170, 169, 199));
            students.Add(new Student(3, "Banu", 179, 195, 179));

          foreach(Student s in students)
            {
                
                s.CutOffCalculator();
            }

        }
    }
}
