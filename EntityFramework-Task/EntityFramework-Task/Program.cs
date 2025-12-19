using EntityFramework_Task.Data.Contexts;
using EntityFramework_Task.Data.Entities;
using Microsoft.EntityFrameworkCore;

AppDbContext context = new();

//var students = context.Students.ToList();

//foreach (var student in students)
//{
//    Console.WriteLine($"{student.Id} - {student.Name} {student.Surname}");
//}


//Student s1 = new()
//{
//    Name = "Huseyn",
//    Surname = "Xasiyev",
//    Email = "hxasiyev033@gmail.com"
//};

//Console.WriteLine(context.Entry(s1).State);

//context.Students.Add(s1);
//context.SaveChanges();

//Student s2 = new()
//{
//    Name = "Nesib",
//    Surname = "Esgerbeyli",
//    Email = "nasibasgar@gmail.com"
//};

//context.Students.Add(s2);
//context.SaveChanges();

//Student? student = context.Students.Find(2);

//student!.Email = "nasibasgar1@gmail.com";
//context.SaveChanges();

#region Add
//Student s1 = new()
//{
//    Name = "Hemid",
//    Surname = "Musayev",
//    Email = "hm0@gmail.com"
//};

//Student s2 = new()
//{
//    Name = "Emine",
//    Surname = "Memmedova",
//    Email = "me1@gmail.com"
//};

//context.Students.Add(s1);
//context.SaveChanges();

//context.Students.AddRange(s1, s2);
//context.SaveChanges();

//context.Entry(s1).State = EntityState.Added;
//context.Entry(s2).State = EntityState.Added;
//context.SaveChanges();


#endregion

#region Update
//Student st1 = context.Students.Find(2);
//st1.Name = "Nesbi";
//context.Students.Update(st1);
//context.SaveChanges();

//var modifiedSt1 = new Student
//{
//    Id = 2,
//    Name = "Nesib",
//    Surname = "Esgerbeyli",
//    Email = "nasib@gmail.com"
//};

//context.Update(modifiedSt1);
//context.SaveChanges();

#region BalkUpdate

//context.Students.Where(s=> s.Id > 2)
//    .ExecuteUpdate(s => s
//        .SetProperty(st => st.Email, st => null)); 

#endregion


#endregion

#region Delete

//Student st1 = context.Students.Find(2);
//context.Students.Remove(st1);
//context.SaveChanges();

//var modifiedSt1 = new Student
//{
//    Id = 3,
//    Name = "Nihad",
//    Surname = "Aslanov",
//    Email = ""
//};

//context.Remove(modifiedSt1);
//context.SaveChanges();


#region BalkDelete

//context.Students.Where(s => s.Id > 5)
//    .ExecuteDelete();

#endregion

#endregion

#region Insert

//Student st1 = new Student
//{
//    Name = "Yusif",
//    Surname = "Babayev",
//    Email = "yb1@gmail.com"
//};

//context.Students.Add(st1);
//context.SaveChanges();

#endregion