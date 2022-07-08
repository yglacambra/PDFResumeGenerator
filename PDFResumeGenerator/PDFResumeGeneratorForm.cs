using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            public List<ContactInformation> ContactInfo { get; set; }
            public List<SkillsAndQualities> QualitiesaAndSkills { get; set; }
            public List<School> EducationalAttainment { get; set; }
            public List<InternshipExperience> Internship{ get; set; }

        }
        class ContactInformation
        {
            public long ContactNumber { get; set; }
            public string EmailAddress { get; set; }

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
                ContactInfo = new List<ContactInformation>
                {
                    new ContactInformation()

                    {
                        ContactNumber = 09956783420,
                        EmailAddress = "yuangab10@gmail.com"
                    }
                },
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
        }

      
    }
}