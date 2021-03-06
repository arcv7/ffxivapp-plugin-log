﻿// FFXIVAPP.Plugin.Log ~ SettingsViewModel.cs
// 
// Copyright © 2007 - 2016 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FFXIVAPP.Common.ViewModelBase;
using FFXIVAPP.Plugin.Log.Helpers;
using FFXIVAPP.Plugin.Log.Views;

namespace FFXIVAPP.Plugin.Log.ViewModels
{
    internal sealed class SettingsViewModel : INotifyPropertyChanged
    {
        public SettingsViewModel()
        {
            AddTabCommand = new DelegateCommand(AddTab);
        }

        #region Declarations

        public ICommand AddTabCommand { get; private set; }

        #endregion

        #region Command Bindings

        /// <summary>
        /// </summary>
        private static void AddTab()
        {
            var xKey = SettingsView.View.TName.Text;
            string xValue;
            var xRegularExpression = SettingsView.View.TRegEx.Text;
            if (SettingsView.View.Codes.SelectedItems.Count < 1)
            {
                xValue = "";
            }
            else
            {
                xValue = SettingsView.View.Codes.SelectedItems.Cast<object>()
                                     .Aggregate("", (current, item) => current + (item.ToString()
                                                                                      .Split(',')[0] + ","))
                                     .Replace("[", "");
                xValue = xValue.Substring(0, xValue.Length - 1);
            }
            if (xKey == "" || xValue == "" || xRegularExpression == "")
            {
            }
            else
            {
                TabItemHelper.AddTabByName(xKey, xValue, xRegularExpression);
                SettingsView.View.TName.Text = "";
                SettingsView.View.Codes.UnselectAll();
                MainView.View.MainViewTC.SelectedIndex = MainView.View.MainViewTC.Items.Count - 1;
                ShellView.View.ShellViewTC.SelectedIndex = 0;
            }
        }

        #endregion

        #region Property Bindings

        private static SettingsViewModel _instance;

        public static SettingsViewModel Instance
        {
            get { return _instance ?? (_instance = new SettingsViewModel()); }
        }

        #endregion

        #region Loading Functions

        #endregion

        #region Utility Functions

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}
