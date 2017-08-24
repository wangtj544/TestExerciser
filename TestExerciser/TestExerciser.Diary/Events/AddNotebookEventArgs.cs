using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExerciser.Diary.Events
{
    public class AddNotebookEventArgs
    {
        public AddNotebookEventArgs(ViewModels.NotebookViewModel notebookViewModel)
        {
            this.NotebookViewModel = notebookViewModel;
        }

        public ViewModels.NotebookViewModel NotebookViewModel { get; private set; }
    }
}
