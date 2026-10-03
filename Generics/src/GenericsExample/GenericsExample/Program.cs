using GenericsExample;

// part 1
var studentStore = new Store<Student>();
studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
studentStore.Add(new Student { Id = 2, Name = "Marwan" });
studentStore.Add(new Student { Id = 3, Name = "Aya" });
studentStore.Add(new Student { Id = 4, Name = "Nada" });
studentStore.Add(new Student { Id = 5, Name = "Youssef" });

var courseStore = new Store<Course>();
courseStore.Add(new Course { Id = 101, Title = "C# Basics", Price = 99.99m });
courseStore.Add(new Course { Id = 102, Title = "OOP", Price = 149.99m });
courseStore.Add(new Course { Id = 103, Title = "Advanced C#", Price = 129.99m });

var student = studentStore.GetById(3);
var course = courseStore.GetById(102);

Console.WriteLine($"Found Student: {student?.Name}");
Console.WriteLine($"Found Course: {course?.Title}");
Console.WriteLine();

// part 2
try
{
    studentStore.Add(new Student { Id = 1, Name = "Ziad" });
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"[Caught Exception]: {ex.Message}");
}
Console.WriteLine();

// part 3
var pageTwoStudents = studentStore.GetAll().Page(2, 2);

foreach (var stud in pageTwoStudents)
{
    Console.WriteLine($"ID: {stud.Id}, Name: {stud.Name}");
}

var plainStudentList = new List<Student>
        {
            new Student { Id = 10, Name = "Mohamed" },
            new Student { Id = 20, Name = "Abdelrahman" }
        };

var foundStudent = plainStudentList.FindById(20);

Console.WriteLine($"Result from plain List: {foundStudent?.Name ?? "Not Found"}");


// must NOT compile
//var stringStore = new Store<string>();