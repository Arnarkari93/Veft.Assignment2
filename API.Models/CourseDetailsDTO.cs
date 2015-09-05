﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    /// <summary>
    /// This class represnets a single course, and contains various details about the course
    /// </summary>
    public class CourseDetailsDTO
    {
        
        public int ID { get; set; }

        /// <summary>
        /// Id of the course
        /// Example: T-514-VEFT
        /// </summary>
        public string TemplateID { get; set; }

        /// <summary>
        /// Name of the course
        /// Example: Web services
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description for a single course
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Repersents the start date for a single course
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Repersents the end date for a single course
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The count of Students in the course
        /// </summary>
        public int StudentCount { get; set; }

    }
}
