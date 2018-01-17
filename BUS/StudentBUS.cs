﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BUS
{
    public class StudentBUS
    {
        private StudentDAL obj = new StudentDAL();
        public List<Student> Student_GetByTop(string Top, string Where, string Order)
        {
            return obj.Student_GetByTop(Top, Where, Order);
        }
         public bool Student_Insert(Student data)
        {
            return obj.Student_Insert(data);
        }

        public bool Student_Update(Student data)
        {
            return obj.Student_Update(data);
        }

        public bool Student_Delete(string ID)
        {
            return obj.Student_Delete(ID);
        }
    }
}
