using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.ListView.XForms;
using Syncfusion.DataSource.Extensions;

namespace AutoFitSample 
{
    public class ListViewAutoFitContentViewModel : INotifyPropertyChanged
    {
        #region Fields

        private ObservableCollection<ListViewBookInfo> bookInfo;

        #endregion

        #region Constructor

        public ListViewAutoFitContentViewModel()
        {
            GenerateSource();
        }

        #endregion

        #region Properties

        public ObservableCollection<ListViewBookInfo> BookInfo
        {
            get { return bookInfo; }
            set { this.bookInfo = value; }
        }

        #endregion

        #region Generate Source

        private void GenerateSource()
        {
            ListViewBookInfoRepository bookInfoRepository = new ListViewBookInfoRepository();
            bookInfo = bookInfoRepository.GetBookInfo();
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
