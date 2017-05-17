﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using JetBrains.Annotations;
using ReactiveUI;
using Restaurant.Abstractions;
using Restaurant.Abstractions.Services;

namespace Restaurant.ViewModels
{
    [UsedImplicitly]
    public class WelcomeViewModel : IWelcomeViewModel
    {
        public WelcomeViewModel(INavigationService navigationService, 
            ISignInViewModel signInViewModel,
            ISignUpViewModel signUpViewModel)
        {
            GoLogin = ReactiveCommand.Create(() => 
                                    navigationService.NavigateAsync(signInViewModel));

            GoRegister = ReactiveCommand.Create(() => 
                                    navigationService.NavigateAsync(signUpViewModel));
        }

        public string Title => "Welcome page";

        /// <summary>
        /// Gets and sets Open regester, 
        /// Command that opens regester page
        /// </summary>
        public ICommand GoRegister { get; }

        /// <summary>
        /// Gets and sets OpenLogin
        /// Command thats opens login page 
        /// </summary>
        public ICommand GoLogin { get;  }
    }
}