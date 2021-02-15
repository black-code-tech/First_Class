using System;
using System.Collections.Generic;
using System.Text;

namespace First_Class.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        private string details;

        public string Details
        {
            get { return details; }
            set { SetProperty(ref details, value); }
        }

        public DetailPageViewModel(string detailContent)
        {
            Details = detailContent;
        }

    }
}
