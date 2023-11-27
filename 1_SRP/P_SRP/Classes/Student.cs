using P_SRP.Classes;
namespace P_SRP.Classes;

public class Student {
    public string? Name { get; set; }
    public DateTime DoB { get; set; }

    public bool Save() {
        Console.WriteLine("Saving...");
        // Save to DB
        Console.WriteLine("Done Saving..");

        return true;
    }

    public bool Delete() {
        Console.WriteLine("Deleting...");
        // Delete from DB
        Console.WriteLine("Done Deleting...");

        return true;
    }

    public IList<Course> Subscribe(Course course) {
        Console.WriteLine("Enrolling to course...");

        if (course.Type == "online") {
            Console.WriteLine("online course");
        } else if (course.Type == "live") {
            Console.WriteLine("live course");
        }

        // Payment processing

        // Save couse subscription to DB

        // Send email confirmation

        Console.WriteLine("Done Enrolling...");

        return ([]);
    }
}