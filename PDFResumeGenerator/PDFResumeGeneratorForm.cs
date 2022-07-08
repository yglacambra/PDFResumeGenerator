namespace PDFResumeGenerator
{
    public partial class PDFResumeGeneratorForm : Form
    {
        public PDFResumeGeneratorForm()
        {
            InitializeComponent();
        }
        class PersonalInformation
        {
            public string Name;
            public int Age;
            public string Address;
            public string Nationality;
            public string Religion;
            public string AboutMyself;
        }
        class ContactInformation
        {
            public long ContactNumber;
            public string EmailAddress;

        }
        class SkillsAndQualities
        {   
            public List<string> Skills;
            public List<string> Qualities;
        }
        private void PDFResumeGeneratorForm_Load(object sender, EventArgs e)
        {
           
        }

        private void ResumeInfo()
        {
            PersonalInformation PersonalInfo = new PersonalInformation()
            {
                Name = "Yuan Gabriel S. Lacambra",
                Age = 19,
                Address = "#3 Cojuangco St., Everhills Subdivision, Brgy. Inarawan, Antipolo City, Rizal",
                Nationality = "Filipino",
                Religion = "Agnostic",
                AboutMyself = "Motivated college graduate aspiring to become a computer engineer. Looking for a company that will let me prove my skills."
            };
            ContactInformation ConatctInfo = new ContactInformation()
            {
                ContactNumber = 09956783420,
                EmailAddress = "yuangab10@gmail.com"
            };
            SkillsAndQualities SkillAndQuality = new SkillsAndQualities()
            {
                Skills = new List<string>()
                {
                    "Artificial Intelligence and Machine Learning",
                    "Edge Computing",
                    "Computational Algorithms",
                    "Operating Systems",
                    "Adept at 3 Programming Languages (C#, C++, Python)",
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
            };
        }
    }
}