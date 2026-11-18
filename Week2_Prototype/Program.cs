// Create two appointment objects
Appointment appointment1 = new Appointment(
    "Max",
    "Maria Santos",
    new DateTime(2026, 12, 3, 9, 0, 0)
);

Appointment appointment2 = new Appointment(
    "Milo",
    "Juan Dela Cruz",
    new DateTime(2026, 12, 3, 11, 0, 0)
);

// Display the first appointment
appointment1.DisplayInfo();

// Reschedule the first appointment
Console.WriteLine("\nTesting valid reschedule:");
appointment1.Reschedule(
    new DateTime(2026, 12, 5, 10, 0, 0)
);

// Cancel the first appointment
Console.WriteLine("\nTesting cancellation:");
appointment1.Cancel();

// Try to reschedule a cancelled appointment
Console.WriteLine("\nTesting rejected action:");
bool result = appointment1.Reschedule(
    new DateTime(2026, 12, 6, 10, 0, 0)
);

Console.WriteLine("Reschedule accepted: " + result);

// Display the second appointment
appointment2.DisplayInfo();

// Reschedule the second appointment
Console.WriteLine("\nTesting second appointment:");
appointment2.Reschedule(
    new DateTime(2026, 12, 7, 11, 0, 0)
);

// Create a regular appointment
Appointment regularAppointment = new Appointment(
    "Max",
    "Maria Santos",
    new DateTime(2026, 12, 3, 9, 0, 0)
);

// Create a follow-up appointment
FollowUpAppointment followUp = new FollowUpAppointment(
    "Milo",
    "Juan Dela Cruz",
    new DateTime(2026, 12, 5, 10, 0, 0)
);

// Store both objects in one Appointment array
Appointment[] appointments =
{
    regularAppointment,
    followUp
};

// Display their labels
Console.WriteLine("=== VETCARE APPOINTMENT LABELS ===");

foreach (Appointment appointment in appointments)
{
    Console.WriteLine(appointment.Label());
}
