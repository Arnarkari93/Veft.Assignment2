﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services.Entities
{
    /// <summary>
    /// This class represents a course template in the database
    /// </summary>
    [Table("Courses")]
    class Course
    {
        /// <summary>
        /// A unique identifier for the course
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// The template id for a course. Foreign key to the CourseTemplate table
        /// Example "T-504-VEFT"
        /// </summary>
        public int TemplateID { get; set; }
        /// <summary>
        /// The start date for a course
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// The end date for a course
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// The semester and year the course is taught in
        /// Example "201501"
        /// </summary>
        public string Semester { get; set; }
    }
}
