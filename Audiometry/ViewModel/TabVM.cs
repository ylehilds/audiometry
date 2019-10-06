﻿namespace Audiometry.ViewModel
{
    public abstract class TabVM : ViewModelBase
    {
        public abstract bool AddRecordToDatabase(string accNumber, string examDate, out string msg);
        public abstract bool UpdateRecordInDatabase(string accNumber, string examDate, out string msg);
        public abstract void OpenRecordFromDatabase(string accNumber, string examDate);
        public abstract bool DeleteRecordFromDatabase(string accNumber, string examDate);
        public abstract void InitializeProperties();
    }
}
