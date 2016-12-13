﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineElection.BLL.Repository
{
    public interface IStudentRepository
    {
        void InsertCandidate();

        List<string> GetStudentListByFaculty(string fac);
        List<string> GetStudentListByBatch(string batch);

    }
}
