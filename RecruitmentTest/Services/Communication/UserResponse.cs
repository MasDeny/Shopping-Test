﻿using RecruitmentTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTest.Services.Communication
{
    public class UserResponse : BaseResponse
    {
        public User User { get; private set; }



        private UserResponse(bool success, string message, User user) : base(success, message)
        {

            User = user;

        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="visitor">Saved category.</param>
        /// <returns>Response.</returns>
        public UserResponse(User user) : this(true, string.Empty, shopping)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public UserResponse(string message) : this(false, message, null)
        { }
    }
}
