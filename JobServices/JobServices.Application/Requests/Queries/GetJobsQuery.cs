﻿using JobServices.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobServices.Application.Requests.Queries
{
    public class GetJobsQuery : IRequest<List<RCMJobDTO>>
    {
    }
}
