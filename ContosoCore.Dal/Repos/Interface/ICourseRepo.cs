using ContosoCore.DAL.Repos.Base;
using ContosoCore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ContosoCore.DAL.Repos.Interface
{
    public interface ICourseRepo: IRepo<Course>
    {
        IQueryable<Course> ObtenerCursos();
    }
}
