using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Details.Models
{
    public  class Employee:Designation
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public int  Emp_Designation { get; set; }
        public int  Emp_Department { get; set; }
        public List<Behaviour_Traits> Behaviour_List { get; set; }
    }
    public class Designation:Department
    {
        public int Designation_Id { get; set; }
        public string Designation_Name{ get; set; }
        public SelectList Designation_List { get; set; }
    }
    public class Department
    {
        public int Department_Id { get; set; }
        public string Department_Name { get; set; }
        public SelectList Department_List { get; set; }
    }
    public class Behaviour_Traits
    {
        public string Behaviour { get; set; }
        public int Rating { get; set; }
    }
}