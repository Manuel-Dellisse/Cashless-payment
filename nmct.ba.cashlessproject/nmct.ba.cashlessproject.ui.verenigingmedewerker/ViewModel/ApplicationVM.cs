﻿using GalaSoft.MvvmLight.Command;
using nmct.ba.cashlessproject.model;
using nmct.ba.cashlessproject.ui.verenigingmedewerker.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Thinktecture.IdentityModel.Client;

namespace nmct.ba.cashlessproject.ui.verenigingmedewerker.ViewModel
{
    class ApplicationVM : ObservableObject
    {
        public ApplicationVM()
        {
            Pages.Add(new LoginVM());

            CurrentPage = Pages[0];
        }

        private object currentPage;
        public object CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; OnPropertyChanged("CurrentPage"); }
        }

        private List<IPage> pages;
        public List<IPage> Pages
        {
            get
            {
                if (pages == null)
                    pages = new List<IPage>();
                return pages;
            }
        }

        public ICommand ChangePageCommand
        {
            get { return new RelayCommand<IPage>(ChangePage); }
        }

        public void ChangePage(IPage page)
        {
            CurrentPage = page;
        }
    }
}
