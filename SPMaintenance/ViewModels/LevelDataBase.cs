using SPMaintenance.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMaintenance.ViewModels
{
    class LevelDataBase : INotifyPropertyChanged
    {
        public LevelDataBase Parent { get; set; }



        private string title;
        public string Title
        {

            get { return title; }
            set
            {
                title = value;
                RaisePropertyChanged("Title");
            }
        }

        private bool isExpanded;

        public bool IsExpanded
        {
            get { return isExpanded; }
            set
            {
                isExpanded = value;
                RaisePropertyChanged("IsExpanded");
            }
        }
        public bool DataLoaded { get; set; }
        public SPMNodeType NodeType { get; set; }

        public object SPMData { get; set; }

        public LevelDataBase()
        {
            this.DataLoaded = false;
            this.NodeType = SPMNodeType.None;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
