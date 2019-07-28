using System;
using System.Collections.Generic;
using System.Text;

namespace D365Utilities
{
    public class LoginClass
    {
        private int _userID;
        private int _password;
        /// <summary>
        /// Sample Used for Constant
        /// </summary>
        /// <remarks>Dummy Field</remarks>
        private const int Timer = 1;

        public event EventHandler LoginEvent;

        public LoginClass()
        {
            throw new System.NotImplementedException();
        }

        public int UserID
        {
            get => default;
            set
            {
            }
        }

        public int Password
        {
            get => default;
            set
            {
            }
        }

        public void Login()
        {
            throw new System.NotImplementedException();
        }
    }
}