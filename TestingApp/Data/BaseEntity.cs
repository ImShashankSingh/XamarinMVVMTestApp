using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using SQLite;
using TestingApp.Interfaces;

namespace TestingApp.Data
{
    public abstract class BaseEntity : IEntity
    {
        #region IEntity

        [PrimaryKey, AutoIncrement]
        public int DbId
        {
            get; set;
        }

        //public virtual DateTime CreatedOn
        //{
        //    get; set;
        //}

        public DateTime UpdatedLocallyOn
        {
            get; set;
        }

        public BaseEntity()
        {
            //CreatedOn = DateTime.UtcNow;
            UpdatedLocallyOn = DateTime.UtcNow;
        }

        #endregion
    }

    public abstract class BaseEntityNotified : BaseEntity, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetProperty<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName]string propertyName = null)
        {
            field = value;
            NotifyPropertyChange(propertyName);
        }

        protected void NotifyPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}