﻿using JobServices.BusinessEntities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobServices.BusinessEntities.Models
{
    public class RCMJobs : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get; set;
        }

        [Required]
        public string JobName
        {
            get; set;
        }

        [Required]
        public string JobDescription
        {
            get; set;
        }

        public DateTimeOffset PublishedDate
        {
            get; set;
        }

        public bool IsPublic
        {
            get; set;
        }

        public bool IsArchived
        {
            get; set;
        }

        public DateTimeOffset? ArchiveDate
        {
            get; set;
        }

        public string AddedBy
        {
            get; set;
        }

        public DateTimeOffset AddedOn
        {
            get; set;
        }

        public DateTimeOffset ClosingDate
        {
            get; set;
        }
    }
}
