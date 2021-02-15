using System;
using System.Collections.Generic;
using System.Text;

namespace First_Class.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        private string deatails;

        public string MyProperty
        {
            get { return deatails; }
            set { myVar = value; }
        }

        public DetailPageViewModel(string detailContent)
        {

        }

    }
}
