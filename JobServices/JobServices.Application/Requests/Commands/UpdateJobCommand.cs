﻿using JobServices.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobServices.Application.Requests.Commands
{
    public class UpdateJobCommand : IRequest<RCMJobDTO>
    {
        public RCMJobDTO? RCMJob
        {
            get; set;
        }
    }
}
