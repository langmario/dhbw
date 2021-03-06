﻿using Aufgabe_11.Framework;
using Aufgabe_11.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Aufgabe_11.ViewModels
{
    public class WindowAddViewModel : ViewModelBase
    {
        public Employee Model { get; set; }
        public ICommand OkCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public IEnumerable<Gender> Genders => Enum.GetValues(typeof(Gender)) as IEnumerable<Gender>;

        public string Firstname
        {
            get => Model.Firstname;
            set
            {
                Model.Firstname = value;
                OnPropertyChanged();
            }
        }
        public string Lastname
        {
            get => Model.Surname;
            set
            {
                Model.Surname = value;
                OnPropertyChanged();
            }
        }
        public Gender Gender
        {
            get => Model.Gender;
            set
            {
                Model.Gender = value;
                OnPropertyChanged();
            }
        }
        public string Street
        {
            get => Model.Address.Street;
            set
            {
                Model.Address.Street = value;
                OnPropertyChanged();
            }
        }
        public string StreetNumber
        {
            get => Model.Address.StreetNumber;
            set
            {
                Model.Address.StreetNumber = value;
                OnPropertyChanged();
            }
        }
        public int PostCode
        {
            get => Model.Address.PostCode;
            set
            {
                Model.Address.PostCode = value;
                OnPropertyChanged();
            }
        }
        public string City
        {
            get => Model.Address.City;
            set
            {
                Model.Address.City = value;
                OnPropertyChanged();
            }
        }
    }
}
