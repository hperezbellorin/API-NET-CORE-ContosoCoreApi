using ContosoCore.DAL.Repos.Base;
using ContosoCore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ContosoCore.DAL.Repos.Interface
{
    public interface IEnrollmetRepo : IRepo<Enrollment>
    {
        IQueryable<Enrollment> ObtenerInscripciones();
    }
}
