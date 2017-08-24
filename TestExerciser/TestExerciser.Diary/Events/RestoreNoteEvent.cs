using TestExerciser.Diary.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExerciser.Diary.Events
{
    public class RestoreNoteEvent
    {
        public RestoreNoteEvent(Note note)
        {
            this.Note = note;
        }

        public Note Note { get; set; }
    }
}
