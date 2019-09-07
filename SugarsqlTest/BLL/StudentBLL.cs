using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class StudentBLL
    {
        StudentService StudentService = new StudentService();
        public List<Student> SelectAll()
        {
            return StudentService.SelectAll();
        }
        public bool Insert()
        {
            return StudentService.Insert();
        }
        public bool Update()
        {
            return StudentService.Update();
        }
        public bool Delete()
        {
            return StudentService.Delete();
        }
    }
}
