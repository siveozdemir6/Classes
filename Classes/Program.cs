using Classes;

Person student1 = new Person();
student1.Name = "Ted";
student1.Surname = "Mosby";
student1.BirthDate = new DateTime(1979, 7, 28);

Person student2 = new Person();
student2.Name = "Marshall";
student2.Surname = "Eriksen";
student2.BirthDate = new DateTime(1979, 3, 24);

Person student3 = new Person();
student3.Name = "Robin";
student3.Surname = "Scherbatsky";
student3.BirthDate = new DateTime(1981, 4, 26);

Person teacher1 = new Person();
teacher1.Name = "Lily";
teacher1.Surname = "Aldrin";
teacher1.BirthDate = new DateTime(1980, 9, 12);

Person teacher2 = new Person();
teacher2.Name = "Barney";
teacher2.Surname = "Stinson";
teacher2.BirthDate = new DateTime(1978, 3, 23);
Console.WriteLine("----------------------ÖĞRENCİ BİLGİLERİ---------------------------");
student1.WriteInfo();
student2.WriteInfo();   
student3.WriteInfo();
Console.WriteLine("----------------------ÖĞRETMEN BİLGİLERİ--------------------------");
teacher1.WriteInfo();
teacher2.WriteInfo();



