using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace First_Class.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        #region Private Members

        private string details;

        #endregion

        #region Public Members

        public Command ReturnCommand { get; }

        public string Details
        {
            get { return details; }
            set { SetProperty(ref details, value); }
        }

        #endregion

        #region Constructor

        public DetailPageViewModel(string detailContent)
        {
            Details = detailContent;

            ReturnCommand = new Command(OnReturn);
        }

        #endregion

        #region Helper Methods

        private async void OnReturn(object obj)
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        }

        #endregion
    }
}
