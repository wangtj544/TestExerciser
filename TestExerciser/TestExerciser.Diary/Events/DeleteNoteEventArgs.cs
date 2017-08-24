using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestExerciser.Diary.Logic.Models;

namespace TestExerciser.Diary.Events
{
    public class DeleteNoteEventArgs
    {
        public DeleteNoteEventArgs(Note note, bool isDeleteToRecycle)
        {
            this.Note = note;
            this.IsDeleteToRecycle = isDeleteToRecycle;
        }

        public Note Note { get; set; }

        public bool IsDeleteToRecycle { get; set; }
    }
}
