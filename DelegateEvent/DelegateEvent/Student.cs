using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Student
    {
        public string Fullname { get; set; }
        public int Mark { get; set; }
        public event Action<int> Notify;

        public Student(string fullname,int mark)
        {
            Fullname = fullname;
            Mark = mark;
        }

        public void SendMail()
        {
            Notify(Mark);
        }
    }
}
