public class FollowUpAppointment : Appointment
{
    public FollowUpAppointment(
        string petName,
        string ownerName,
        DateTime appointmentDate
    )
        : base(petName, ownerName, appointmentDate)
    {
    }

    public override string Label()
    {
        return $"Follow-up Appointment for {PetName}";
    }
}
