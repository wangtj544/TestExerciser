using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestExerciser.Diary.Logic.Models;

namespace TestExerciser.Diary.Events
{
    public class AddNoteEventArgs
    {
        public AddNoteEventArgs(Note note)
        {
            this.Note = note;
        }

        public Note Note { get; private set; }
    }
}
