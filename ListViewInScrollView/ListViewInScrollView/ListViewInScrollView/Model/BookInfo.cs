using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoFitSample 
{
    public class ListViewBookInfo : INotifyPropertyChanged
    {
        #region Fields

        private string bookName;
        private string bookDesc;
        private int bookNumber;

        #endregion

        #region Constructor

        public ListViewBookInfo()
        {
            
        }

        #endregion

        #region Properties

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }

        public int BookNumber
        {
            get { return bookNumber; }
            set
            {
                bookNumber = value;
                OnPropertyChanged("BookNumber");
            }
        }

        public string BookDescription
        {
            get { return bookDesc; }
            set
            {
                bookDesc = value;
                OnPropertyChanged("BookDescription");
            }
        }


        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
