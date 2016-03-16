﻿using System;
using System.Collections.Generic;

namespace ASP.NET_VersionedAPI.Code.V2._2
{
    public class ExampleV2d2Adapter : IExampleAdapter
    {
        private List<string> _users = new List<string>
        {
            "tuahneaM niboR",
            "eoD nhoJ",
            "eoD enaJ"
        };

        /// <summary>
        /// Adds a user to our list
        /// 
        /// NOTE: Implementation has changed compared to V1
        /// </summary>
        /// <param name="fullName">The full name of the user to add</param>
        public void AddUser(string fullName)
        {
            // Our implementation has changed compared to V1, we now reverse the name! 
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            string reversedFullName = new string(charArray);

            // Add reversed name
            _users.Add(reversedFullName);
        }

        /// <summary>
        /// Returns a list of all users
        /// </summary>
        /// <returns>A list of all users</returns>
        public List<string> GetUsers()
        {
            return _users;
        }
    }
}