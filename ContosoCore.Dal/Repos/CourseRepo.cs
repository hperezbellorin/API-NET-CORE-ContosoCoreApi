using ContosoCore.DAL.EF;
using ContosoCore.DAL.Repos.Base;
using ContosoCore.DAL.Repos.Interface;
using ContosoCore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContosoCore.DAL.Repos
{
    public class CourseRepo : RepoBase<Course>, ICourseRepo
    {
        public CourseRepo(DbContextOptions<ContosoCoreContext> options) : base(options)
        {

        }
        public IQueryable<Course> ObtenerCursos() => Table;

        public override IEnumerable<Course> GetAll() => Table.OrderBy(x => x.Title);
        
    }
}
