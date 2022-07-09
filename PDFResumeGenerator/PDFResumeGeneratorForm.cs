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
            public List<InternshipExperience> Internship{ get; set; }

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
                            "District-Level Quizbee Winner"
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
            var TitleFont = FontFactory.GetFont("Franklin Gothic Heavy", 22.0f,1);
            ResumePDF.Open();
            ResumePDF.Add(new Paragraph("Personal Information", TitleFont));   
            ResumePDF.Add(new Paragraph("Name: " + InformationThatWillBePlacedOnTheResume.Name, TextBaseFont));
            ResumePDF.Add(new Paragraph("Age: " + InformationThatWillBePlacedOnTheResume.Age + " years old", TextBaseFont));
            ResumePDF.Add(new Paragraph("Address: " + InformationThatWillBePlacedOnTheResume.Address, TextBaseFont));
            ResumePDF.Add(new Paragraph("Nationality: " + InformationThatWillBePlacedOnTheResume.Name, TextBaseFont));
            ResumePDF.Add(new Paragraph("Religion: " + InformationThatWillBePlacedOnTheResume.Religion, TextBaseFont));
            ResumePDF.Add(new Paragraph("Profile: " + InformationThatWillBePlacedOnTheResume.Profile, TextBaseFont));
            ResumePDF.Add(new Paragraph("Contact Information", TitleFont));
            ResumePDF.Add(new Paragraph("Contact Number: " + InformationThatWillBePlacedOnTheResume.ContactNumber, TextBaseFont));
            ResumePDF.Add(new Paragraph("Email Address: " + InformationThatWillBePlacedOnTheResume.EmailAddress, TextBaseFont));
            ResumePDF.Add(new Paragraph("Skills and Qualities", TitleFont));
            ResumePDF.Add(new Paragraph("Skills:", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[0], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[1], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[2], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[3], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[4], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[5], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[6], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Skills[7], TextBaseFont));
            ResumePDF.Add(new Paragraph("Qualities:", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[0], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[1], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[2], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[3], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[4], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[5], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.QualitiesaAndSkills[0].Qualities[6], TextBaseFont));
            ResumePDF.Add(new Paragraph("Education", TitleFont));
            ResumePDF.Add(new Paragraph("High School", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[0].SchoolName, TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[0].YearAttended, TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[0].Achievements[0], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[0].Achievements[1], TextBaseFont));
            ResumePDF.Add(new Paragraph("College", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[1].SchoolName, TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[1].YearAttended, TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[1].Achievements[0], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.EducationalAttainment[1].Achievements[1], TextBaseFont));
            ResumePDF.Add(new Paragraph("Internship Experience",TitleFont));
            ResumePDF.Add(new Paragraph("Company: " + InformationThatWillBePlacedOnTheResume.Internship[0].Company, TextBaseFont));
            ResumePDF.Add(new Paragraph("Duration: " + InformationThatWillBePlacedOnTheResume.Internship[0].Duration, TextBaseFont));
            ResumePDF.Add(new Paragraph("Job: " + InformationThatWillBePlacedOnTheResume.Internship[0].Job, TextBaseFont));
            ResumePDF.Add(new Paragraph("Experience:", HighlightTextFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.Internship[0].Experience[0], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.Internship[0].Experience[1], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.Internship[0].Experience[2], TextBaseFont));
            ResumePDF.Add(new Paragraph(InformationThatWillBePlacedOnTheResume.Internship[0].Experience[3], TextBaseFont));
            ResumePDF.Close();
        }
        private void BtnReadJSONFile_Click(object sender, EventArgs e)
        {
            string JSONFileInfo = File.ReadAllText(@"Resume Information.json");
            RichTxtBoxJSONFile.Text = JSONFileInfo;
        }
    }
}