class Student {

    public void DisplaySubjects(params string[] subjects) {

        for(int i = 0; i < subjects.Length; i++) {

            Console.WriteLine(subjects[i]);
        }
        
    }

    class Program
    {

        static void Main()
        {

            //create object of student class
            Student s = new Student();

            //access display subjects method
            s.DisplaySubjects("Theory of Computation", "Computer Networks", "Discrete Mathemetics", "Digital System Design", "Basics of C");

            Console.ReadKey();
        }

    }

}