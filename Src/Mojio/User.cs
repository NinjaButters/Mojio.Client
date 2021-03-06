﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Mojio
{
    /// <summary>
    /// User
    /// </summary>
    public partial class User : GuidEntity
    {

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Display(Name="First Name")]
        [MaxLength(32, ErrorMessage="Maximum lenght 32 characters")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [Display(Name = "Last Name")]
        [MaxLength(32, ErrorMessage = "Maximum lenght 32 characters")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the user count.
        /// </summary>
        /// <value>
        /// The user count.
        /// </value>
        public int UserCount { get; set; }

        /// <summary>
        /// optional number of credits
        /// </summary>
        /// <value>
        /// The credits.
        /// </value>
        public int? Credits { get; set; }

        /// <summary>
        /// record creation timestamp
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// most recent activity timestamp
        /// </summary>
        /// <value>
        /// The last activity date.
        /// </value>
        public DateTime LastActivityDate { get; set; }

        /// <summary>
        /// most recent login timestamp
        /// </summary>
        /// <value>
        /// The last login date.
        /// </value>
        public DateTime LastLoginDate { get; set; }        
    }
}
