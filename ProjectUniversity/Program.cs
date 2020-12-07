using System;

namespace ProjectUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            Room room105 = new Room("105", 50, "Math & Physics");
            Room room206 = new Room("206", 40, "Literature & Languages");
            Room room307 = new Room("307", 90, "Arts");
            Room room318 = new Room("318", 20, "Law");
            Room room337 = new Room("337", 30, "Philosophy");

            Teacher PeterThomson = new Teacher("Peter", "Thomson", 500);
            Teacher JackyGrayson = new Teacher("Jacky", "Grayson", 600);
            Teacher EmmaJones = new Teacher("Emma", "Jones", 700);

            Course MathCourse = new Course("Math", 50, room105, PeterThomson);
            Course EnglishCourse = new Course("English", 40, room206, JackyGrayson);
            Course ActingCourse = new Course("Acting", 90, room307, EmmaJones);
            Course CriminologyCourse = new Course("Criminology", 20, room318, JackyGrayson);
            Course StoicismCourse = new Course("Stoicism", 30, room337, EmmaJones);

            Student TariMussman = new Student("Tari", "Mussman", 20, "Bachelors");
            Student MaxJeanlouis = new Student("Max", "Jeanlouis", 19, "Bachelors");
            Student AnnaleeBrotzman = new Student("Annalee", "Brotzman", 21, "Bachelors");
            Student GusHalberg = new Student("Gus", "Halberg", 25, "Masters");
            Student LesiaDerry = new Student("Lesia", "Derry", 27, "Masters");
            Student EffiePitkin = new Student("Effie", "Pitkin", 30, "PhD");
            Student RalphMorita = new Student("Ralph", "Morita", 20, "Bachelors");
            Student NickyTabler = new Student("Nicky", "Tabler", 19, "Bachelors");
            Student RachelEdwards = new Student("Rachel", "Edwards", 28, "PhD");
            Student JadeGreen = new Student("Jade", "Green", 23, "Masters");

            MathCourse.AddStudentToCourse(TariMussman);
            EnglishCourse.AddStudentToCourse(TariMussman);
            MathCourse.AddStudentToCourse(MaxJeanlouis);
            CriminologyCourse.AddStudentToCourse(MaxJeanlouis);
            EnglishCourse.AddStudentToCourse(AnnaleeBrotzman);
            ActingCourse.AddStudentToCourse(AnnaleeBrotzman);
            StoicismCourse.AddStudentToCourse(AnnaleeBrotzman);
            MathCourse.AddStudentToCourse(GusHalberg);
            ActingCourse.AddStudentToCourse(GusHalberg);
            CriminologyCourse.AddStudentToCourse(LesiaDerry);
            StoicismCourse.AddStudentToCourse(LesiaDerry);
            EnglishCourse.AddStudentToCourse(LesiaDerry);
            MathCourse.AddStudentToCourse(EffiePitkin);
            StoicismCourse.AddStudentToCourse(EffiePitkin);
            MathCourse.AddStudentToCourse(RalphMorita);
            EnglishCourse.AddStudentToCourse(RalphMorita);
            MathCourse.AddStudentToCourse(NickyTabler);
            CriminologyCourse.AddStudentToCourse(NickyTabler);
            ActingCourse.AddStudentToCourse(RachelEdwards);
            StoicismCourse.AddStudentToCourse(RachelEdwards);
            CriminologyCourse.AddStudentToCourse(RachelEdwards);
            ActingCourse.AddStudentToCourse(JadeGreen);
            StoicismCourse.AddStudentToCourse(JadeGreen);
            EnglishCourse.AddStudentToCourse(JadeGreen);

            university.AddCourse(MathCourse);
            university.AddCourse(EnglishCourse);
            university.AddCourse(ActingCourse);
            university.AddCourse(CriminologyCourse);
            university.AddCourse(StoicismCourse);

            university.AddRoom(room105);
            university.AddRoom(room206);
            university.AddRoom(room307);
            university.AddRoom(room318);
            university.AddRoom(room337);

            //university.RemoveStudentFromUniversity(TariMussman);
        }
    }
}
