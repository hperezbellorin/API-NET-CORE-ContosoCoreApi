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
    public class EnrolmentRepo : RepoBase<Enrollment>, IEnrollmetRepo
    {
        public EnrolmentRepo(DbContextOptions<ContosoCoreContext> options) : base(options)
        {

        }
        public IQueryable<Enrollment> ObtenerInscripciones() => Table;

        public override IEnumerable<Enrollment> GetAll() => Table.OrderBy(x => x.StudentID);

    }
}
