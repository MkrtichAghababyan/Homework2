using JsonTry;
using Newtonsoft.Json;




    var university1 = new ClassUniversities();

    university1.universities = new Universities();
    university1.universities.university = "South Carolina StateUniversity";

    List<Student> listStudent = new List<Student>();
    Student student1 = new Student
    {
        name = "StephenCousins"
    };
    Student student2 = new Student
    {
        name = "Austin A. Newton"
    };
    Student student3 = new Student
    {
        name = "Adam Wilhite"
    };
    Student student4 = new Student
    {
        name = "Enis Kurtay YILMAZ"
    };

    listStudent.Add(student1);
    listStudent.Add(student2);
    listStudent.Add(student3);
    listStudent.Add(student4);

    university1.universities.students = listStudent;
    string json = JsonConvert.SerializeObject(university1);

    Console.WriteLine(json);


