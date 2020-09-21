using System;
using CommonServiceLocator;

namespace DiUsingUnity
{
    public class ViewModelLocator
    {
        public MainViewModel ProductsViewModel
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }
    }
}
