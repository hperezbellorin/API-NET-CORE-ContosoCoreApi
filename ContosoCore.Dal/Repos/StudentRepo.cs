using ContosoCore.DAL.Repos.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ContosoCore.Models.Entities;
using ContosoCore.DAL.Repos.Base;
using Microsoft.EntityFrameworkCore;
using ContosoCore.DAL.EF;

namespace ContosoCore.DAL.Repos
{
    public class StudentRepo : RepoBase<Student>, IStudentRepo
    {

        public StudentRepo(DbContextOptions<ContosoCoreContext> options) : base(options)
        {
            
        }
        public override IEnumerable<Student> GetAll() => Table.OrderBy(x => x.FisrtMidName);
        public IQueryable<Student> ObtenerEstudiantes() => Table;
    }
}
