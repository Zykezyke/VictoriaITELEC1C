using System;
using VictoriaITELEC1C.Models;
using VictoriaITELEC1C.Services;

namespace VictoriaITELEC1C.Services
{
    public class InstructorDummy : IInstructorDummy
    {
        public List<Instructor> InstructorList { get; }

        public InstructorDummy() 
        {
            InstructorList = new List<Instructor>()
            {
            new Instructor()
            {
                InstructorId = 1, InsFirst = "Gabriel", InsLast = "Montano", HiringDate = DateTime.Parse("2022-08-26"), IsTenured = false, InstructorRank = Rank.Instructor, InsPhone = "+639335557565", InsAdd = "276-279 San Jose Ext., Bgy. San Isidro Antipolo City"
            },
            new Instructor()
            {
                InstructorId = 2, InsFirst = "Leo", InsLast = "Lintag", HiringDate = DateTime.Parse("2022-08-07"), IsTenured = true, InstructorRank = Rank.Professor, InsPhone = "+63933227422", InsAdd = "J W S Center 731 Aurora Boulevard 1100 Quezon City"
            },
            new Instructor()
            {
                InstructorId = 3, InsFirst = "Frederick", InsLast = "Rey", HiringDate = DateTime.Parse("2022-03-25"), IsTenured = false, InstructorRank = Rank.AssistantProfessor, InsPhone = "+639827323910", InsAdd = "88 Capitol Hills Drive Matandang Balara Quezon City"
            },
            new Instructor()
            {
                InstructorId = 4, InsFirst = "Eugenia", InsLast = "Zhuo", HiringDate = DateTime.Parse("2020-01-25"), IsTenured = true, InstructorRank = Rank.AssociateProfessor, InsPhone = "+639202838482", InsAdd = "G/F El Nino Apartelle140 N. Domingo Cubao 1109 Quezon City"
            }

        };
        }
    }
}
