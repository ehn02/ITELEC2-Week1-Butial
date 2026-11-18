public class Appointment
{
    public string PetName { get; }
    public string OwnerName { get; }

    public DateTime AppointmentDate { get; private set; }

    public bool IsCancelled { get; private set; }

    // Constructor
    public Appointment(string petName, string ownerName,
                       DateTime appointmentDate)
    {
        PetName = petName;
        OwnerName = ownerName;
        AppointmentDate = appointmentDate;
        IsCancelled = false;
    }

    // Method 1: Reschedule appointment
    public bool Reschedule(DateTime newDate)
    {
        if (IsCancelled)
        {
            Console.WriteLine("Cannot reschedule. Appointment is cancelled.");
            return false;
        }

        if (newDate <= DateTime.Now)
        {
            Console.WriteLine("Invalid date. Choose a future date.");
            return false;
        }

        AppointmentDate = newDate;
        Console.WriteLine("Appointment successfully rescheduled!");
        return true;
    }

    // Method 2: Cancel appointment
    public void Cancel()
    {
        IsCancelled = true;
        Console.WriteLine("Appointment cancelled successfully.");
    }

    // Display appointment information
    public void DisplayInfo()
    {
        Console.WriteLine("\n--- Appointment Information ---");
        Console.WriteLine("Pet Name: " + PetName);
        Console.WriteLine("Owner Name: " + OwnerName);
        Console.WriteLine("Appointment Date: " + AppointmentDate);
        Console.WriteLine("Cancelled: " + IsCancelled);
    }

    public virtual string Label()
    {
        return $"Appointment for {PetName}";
    }
}
