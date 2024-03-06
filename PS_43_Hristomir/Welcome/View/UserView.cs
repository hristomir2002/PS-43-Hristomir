﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            this._viewModel = viewModel; 
        }

        public void Display()
        {
            Console.WriteLine("Welcome \n User: {0} \n Role: {1}", _viewModel.Name, _viewModel.Role);
        }

        public void DisplayError()
        {
            throw new Exception("Something went wrong!");
        }
    }
}
