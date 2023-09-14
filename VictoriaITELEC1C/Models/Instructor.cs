﻿namespace VictoriaITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int InstructorId { get; set; }

        public string InsFirst { get; set; }

        public string InsLast { get; set; }

        public Boolean IsTenured { get; set; }

        public Rank InstructorRank { get; set; }

        public DateTime HiringDate { get; set; }

        public string InsAdd { get; set; }

        public string InsPhone { get; set; }

    }
}
