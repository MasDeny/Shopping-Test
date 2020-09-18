using RecruitmentTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTest.Services.Communication
{
    public class ShoppingResponse : BaseResponse
    {
        public Shopping Shopping { get; private set; }



        private ShoppingResponse(bool success, string message, Shopping shopping) : base(success, message)
        {

            Shopping = shopping;

        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="visitor">Saved category.</param>
        /// <returns>Response.</returns>
        public ShoppingResponse(Shopping shopping) : this(true, string.Empty, shopping)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public ShoppingResponse(string message) : this(false, message, null)
        { }


    }
}
