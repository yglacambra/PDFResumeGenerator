using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.fonts;


namespace PDFResumeGenerator
{
    public partial class PDFResumeGeneratorForm : Form
    {
        public PDFResumeGeneratorForm()
        {
            InitializeComponent();
        }
        class ResumeInfo
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
            public string Nationality { get; set; }
            public string Religion { get; set; }
            public string Profile { get; set; }
            public long ContactNumber { get; set; }
            public string EmailAddress { get; set; }
            public List<SkillsAndQualities> QualitiesaAndSkills { get; set; }
            public List<School> EducationalAttainment { get; set; }
            public List<InternshipExperience> Internship { get; set; }

        }
        class SkillsAndQualities
        {
            public List<string> Skills { get; set; }
            public List<string> Qualities { get; set; }
        }
        class School
        {
            public string SchoolName { get; set; }
            public string YearAttended { get; set; }
            public List<string> Achievements { get; set; }
        }
        class InternshipExperience
        {
            public string Company { get; set; }
            public string Duration { get; set; }
            public string Job { get; set; }
            public List<string> Experience { get; set; }
        }

        private void PDFResumeGeneratorForm_Load(object sender, EventArgs e)
        {
            ResumeInfo ResumeInformation = new ResumeInfo()
            {
                Name = "Yuan Gabriel S. Lacambra",
                Age = 21,
                Address = "#3 Cojuangco St., Everhills Subdivision, Brgy. Inarawan, Antipolo City, Rizal",
                Nationality = "Filipino",
                Religion = "Agnostic",
                Profile = "Motivated recent college graduate aspiring to become a computer engineer. Looking for a company where I can use my educational background to develop and hone my skills.",
                ContactNumber = 09956783420,
                EmailAddress = "yuangab10@gmail.com",
                QualitiesaAndSkills = new List<SkillsAndQualities>
                {
                    new SkillsAndQualities()
                    {
                        Skills = new List<string>()
                        {
                            "Artificial Intelligence and Machine Learning",
                            "Edge Computing",
                            "Computational Algorithms",
                            "Operating Systems",
                            "Thorough understanding of the.NET technology and developing Java apps.",
                            "Strong programming and analytical abilities",
                            "Strong familiarity with database management systems including Oracle, MS Access, and MySQL.",
                            "Well-Versed at 3 Programming Languages (C#, C++, Python)",
                        },
                        Qualities = new List<string>()
                        {
                            "Meticulous and Organized",
                            "Fast Learner. Can learn new technologies and skills quickly.",
                            "High technical competence",
                            "Highly dependable and adaptable",
                            "Logical and analytical thinker. Incredibly adept at solving problems",
                            "Amiable and gets along with everyone",
                            "Diligent and highly persistent"
                        }
                    }

                },
                EducationalAttainment = new List<School>
                {
                    new School()
                    {
                        SchoolName = "Fuschia High School",
                        YearAttended = "2013-2019",
                        Achievements = new List<string>()
                        {
                            "Graduated Salutatorian",
                        }
                    },
                    new School()
                    {
                        SchoolName = "Alfaroa College",
                        YearAttended = "2019-2023",
                        Achievements = new List<string>()
                        {
                            "Graduated Cum Laude",
                            "President's Lister"
                        }
                    }
                },
                Internship = new List<InternshipExperience>
                {
                    new InternshipExperience()
                    {
                        Company = "JAVA Systems Philippiones",
                        Duration = "2021-2023",
                        Job = "Computer Engineering",
                        Experience = new List<string>()
                        {
                            "Helped with project testing, evaluation, debugging, and documentation.",
                            "Implemented and troubleshot the wireless and LAN Network.",
                            "Created and tested operating systems and firmware.",
                            "Participated in code and design reviews."
                        }
                    }
                }

            };
            string ResumeInfos = JsonConvert.SerializeObject(ResumeInformation, Formatting.Indented);
            File.WriteAllText(@"Resume Information.json", ResumeInfos);
        }

        private void BtnGenerateResume_Click(object sender, EventArgs e)
        {
            WritePDFResume();
        }

        private void WritePDFResume()
        {
            string JSONFileInfo = File.ReadAllText(@"Resume Information.json");
            ResumeInfo InformationThatWillBePlacedOnTheResume = JsonConvert.DeserializeObject<ResumeInfo>(JSONFileInfo);
            Document ResumePDF = new Document(PageSize.A3);
            PdfWriter ResumePDFWriter = PdfWriter.GetInstance(ResumePDF, new FileStream("LACAMBRA_YUAN.pdf", FileMode.Create));
            var TextBaseFont = FontFactory.GetFont("Arial", 14.0f, BaseColor.BLACK);
            var HighlightTextFont = FontFactory.GetFont("Arial", 14.0f, 1);
            var TitleFont = FontFactory.GetFont("Franklin Gothic", 20.0f, 1);
            ResumePDF.Open();
            ResumePDF.Add(new Paragraph("Personal Information", TitleFont));
            //Adding the Name
            Chunk NameChunkLeft = new Chunk("Name: ", HighlightTextFont);
            Chunk NameChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.Name, TextBaseFont);
            Phrase NamePhrase = new Phrase();
            NamePhrase.Add(NameChunkLeft);
            NamePhrase.Add(NameChunkRight);
            ResumePDF.Add(new Paragraph(NamePhrase));
            //Adding the Age
            Chunk AgeChunkLeft = new Chunk("Age: ", HighlightTextFont);
            Chunk AgeChunkMiddle = new Chunk(InformationThatWillBePlacedOnTheResume.Age.ToString(), TextBaseFont);
            Chunk AgeChunkRight = new Chunk(" years old", TextBaseFont);
            Phrase AgePhrase = new Phrase();
            AgePhrase.Add(AgeChunkLeft);
            AgePhrase.Add(AgeChunkMiddle);
            AgePhrase.Add(AgeChunkRight);
            ResumePDF.Add(new Paragraph(AgePhrase));
            //Adding the Address
            Chunk AddressChunkLeft = new Chunk("Address: ", HighlightTextFont);
            Chunk AddressChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.Address, TextBaseFont);
            Phrase AddressPhrase = new Phrase();
            AddressPhrase.Add(AddressChunkLeft);
            AddressPhrase.Add(AddressChunkRight);
            ResumePDF.Add(new Paragraph(AddressPhrase));
            //Adding the Nationality
            Chunk NationalityChunkLeft = new Chunk("Nationality: ", HighlightTextFont);
            Chunk NationalityChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.Nationality, TextBaseFont);
            Phrase NationalityPhrase = new Phrase();
            NationalityPhrase.Add(NationalityChunkLeft);
            NationalityPhrase.Add(NationalityChunkRight);
            ResumePDF.Add(new Paragraph(NationalityPhrase));
            //Adding the Religion
            Chunk ReligionChunkLeft = new Chunk("Religion: ", HighlightTextFont);
            Chunk ReligionChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.Religion, TextBaseFont);
            Phrase ReligionPhrase = new Phrase();
            ReligionPhrase.Add(ReligionChunkLeft);
            ReligionPhrase.Add(ReligionChunkRight);
            ResumePDF.Add(new Paragraph(ReligionPhrase));
            //Adding the Profile
            Chunk ProfileChunkLeft = new Chunk("Profile: ", HighlightTextFont);
            Chunk ProfileChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.Profile, TextBaseFont);
            Phrase ProfilePhrase = new Phrase();
            ProfilePhrase.Add(ProfileChunkLeft);
            ProfilePhrase.Add(ProfileChunkRight);
            ResumePDF.Add(new Paragraph(ProfilePhrase));
            //Adding the Contact Info
            ResumePDF.Add(new Paragraph("Contact Information", TitleFont));
            //Adding the Contact Number
            Chunk ContactNumberChunkLeft = new Chunk("Contact Number: ", HighlightTextFont);
            Chunk ContactNumberChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.ContactNumber.ToString(), TextBaseFont);
            Phrase ContactNumberPhrase = new Phrase();
            ContactNumberPhrase.Add(ContactNumberChunkLeft);
            ContactNumberPhrase.Add(ContactNumberChunkRight);
            ResumePDF.Add(new Paragraph(ContactNumberPhrase));
            //Adding the Email Address
            Chunk EmailAddressChunkLeft = new Chunk("Email Address: ", HighlightTextFont);
            Chunk EmailAddressChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.EmailAddress, TextBaseFont);
            Phrase EmailAddressPhrase = new Phrase();
            EmailAddressPhrase.Add(EmailAddressChunkLeft);
            EmailAddressPhrase.Add(EmailAddressChunkRight);
            ResumePDF.Add(new Paragraph(EmailAddressPhrase));
            //Adding the Skills and Qualities
            ResumePDF.Add(new Paragraph("Skills and Qualities", TitleFont));
            //Adding the Skills
            ResumePDF.Add(new Paragraph("Skills:", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[0], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[1], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[2], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[3], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[4], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[5], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[6], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[7], TextBaseFont));
            //Adding the Qualities
            ResumePDF.Add(new Paragraph("Qualities:", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[0], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[1], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[2], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[3], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[4], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[5], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[6], TextBaseFont));
            //Adding the Education
            ResumePDF.Add(new Paragraph("Education", TitleFont));
            //Adding the HighSchool
            ResumePDF.Add(new Paragraph("High School", HighlightTextFont));
            //Adding the High School Name
            Chunk HighSchoolNameChunkLeft = new Chunk("School: ", HighlightTextFont);
            Chunk HighSchoolNameChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.EducationalAttainment[0].SchoolName, TextBaseFont);
            Phrase HighSchoolNamePhrase = new Phrase();
            HighSchoolNamePhrase.Add(HighSchoolNameChunkLeft);
            HighSchoolNamePhrase.Add(HighSchoolNameChunkRight);
            ResumePDF.Add(new Paragraph(HighSchoolNamePhrase));
            //Adding Year Attended (High School)
            Chunk YearAttendedHighSchoolChunkLeft = new Chunk("Year Attended: ", HighlightTextFont);
            Chunk YearAttendedHighSchoolChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.EducationalAttainment[0].YearAttended, TextBaseFont);
            Phrase YearAttendedHighSchoolPhrase = new Phrase();
            YearAttendedHighSchoolPhrase.Add(YearAttendedHighSchoolChunkLeft);
            YearAttendedHighSchoolPhrase.Add(YearAttendedHighSchoolChunkRight);
            ResumePDF.Add(new Paragraph(YearAttendedHighSchoolPhrase));
            //Adding High School Achievements
            ResumePDF.Add(new Paragraph("Achievements:", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[0].Achievements[0], TextBaseFont));
            //Adding the College
            ResumePDF.Add(new Paragraph("College", HighlightTextFont));
            //Adding the College Name
            Chunk CollegeNameChunkLeft = new Chunk("School: ", HighlightTextFont);
            Chunk CollegeNameChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.EducationalAttainment[1].SchoolName, TextBaseFont);
            Phrase CollegeNamePhrase = new Phrase();
            CollegeNamePhrase.Add(CollegeNameChunkLeft);
            CollegeNamePhrase.Add(CollegeNameChunkRight);
            ResumePDF.Add(new Paragraph(CollegeNamePhrase));
            //Adding Year Attended (College)
            Chunk YearAttendedCollegeChunkLeft = new Chunk("Year Attended: ", HighlightTextFont);
            Chunk YearAttendedCollegeChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.EducationalAttainment[1].YearAttended, TextBaseFont);
            Phrase YearAttendedCollegePhrase = new Phrase();
            YearAttendedCollegePhrase.Add(YearAttendedCollegeChunkLeft);
            YearAttendedCollegePhrase.Add(YearAttendedCollegeChunkRight);
            ResumePDF.Add(new Paragraph(YearAttendedCollegePhrase));
            //Adding College Achievements
            ResumePDF.Add(new Paragraph("Achievements:", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[1].Achievements[0], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[1].Achievements[1], TextBaseFont));
            //Adding Internship Experience
            ResumePDF.Add(new Paragraph("Internship Experience", TitleFont));
            //Adding Company Name
            Chunk CompanyNameChunkLeft = new Chunk("Company: ", HighlightTextFont);
            Chunk CompanyNameChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.Internship[0].Company, TextBaseFont);
            Phrase CompanyNamePhrase = new Phrase();
            CompanyNamePhrase.Add(CompanyNameChunkLeft);
            CompanyNamePhrase.Add(CompanyNameChunkRight);
            ResumePDF.Add(new Paragraph(CompanyNamePhrase));
            //Adding Internship Duration
            Chunk InternshipDurationChunkLeft = new Chunk("Duration: ", HighlightTextFont);
            Chunk InternshipDurationChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.Internship[0].Duration, TextBaseFont);
            Phrase InternshipDurationPhrase = new Phrase();
            InternshipDurationPhrase.Add(InternshipDurationChunkLeft);
            InternshipDurationPhrase.Add(InternshipDurationChunkRight);
            ResumePDF.Add(new Paragraph(InternshipDurationPhrase));
            //Adding Internship Job
            Chunk InternshipJobChunkLeft = new Chunk("Job: ", HighlightTextFont);
            Chunk InternshipJobChunkRight = new Chunk(InformationThatWillBePlacedOnTheResume.Internship[0].Job, TextBaseFont);
            Phrase InternshipJobPhrase = new Phrase();
            InternshipJobPhrase.Add(InternshipJobChunkLeft);
            InternshipJobPhrase.Add(InternshipJobChunkRight);
            ResumePDF.Add(new Paragraph(InternshipJobPhrase));
            //Adding Internship Experience
            ResumePDF.Add(new Paragraph("Experience:", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.Internship[0].Experience[0], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.Internship[0].Experience[1], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.Internship[0].Experience[2], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.Internship[0].Experience[3], TextBaseFont));
            ResumePDF.Close();
        }
    }
}