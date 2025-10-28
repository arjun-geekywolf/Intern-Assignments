using System;


        Students db = new Students();


        db.InsertStudentInline("Arjun", "10A");

        db.InsertStudent("Anand", "9B");

        db.GetStudentById(1);

        db.UpdateStudent(1, "Arjun", "8C");

        db.GetStudentById(1);

        db.DeleteStudent(1);

        db.GetStudentById(1);

        Console.ReadKey();