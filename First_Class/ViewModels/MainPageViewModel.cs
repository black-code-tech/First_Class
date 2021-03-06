﻿using First_Class.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace First_Class.ViewModels
{
    public class MainPageViewModel: BaseViewModel
    {

        #region Private Members
        private string text;

        #endregion

        #region Public Members

        public Command SaveCommand { get; }
        public Command SelectedCommand { get; }
        public Command DeleteCommand { get; }


        public string Text
        {       
            get { return text; }
            set { SetProperty(ref text, value); }
        }


        private ObservableCollection<string> applist;

        public ObservableCollection<string> Applist
        {
            get { return applist; }
            set { SetProperty(ref applist, value); }
        }

        #endregion

        #region Constructor
        public MainPageViewModel()
        {
            Applist = new ObservableCollection<string>();
            SaveCommand = new Command(OnSave);
            SelectedCommand = new Command<string>(OnItemSelected);
            DeleteCommand = new Command(OnDelete);
        }
        #endregion

        #region Helper Methods

        private void OnDelete(object obj)
        {
            Text = string.Empty;
            Applist.Clear();
        }

        private void OnSave(object obj)
        {
            Applist.Add(Text);
            Text = string.Empty;
        }
        
        private async void OnItemSelected(string detail)
        {
            if (string.IsNullOrEmpty(detail))
            {
                return;
            }

            await App.Current.MainPage.Navigation.PushModalAsync(new DetailPage(detail));
        }

        #endregion
    }
}
