// See https://aka.ms/new-console-template for more information

var medicalAppointment = new MedicalAppointment(
    "John Smith",
    new DateTime(2023, 4, 3)
    );

medicalAppointment.OverwriteMonthAndDay(5, 1);

medicalAppointment.MoveByMonthsAndDays(1, 2);

Console.ReadKey();

class MedicalAppointment
{
    private string _patientname;
    private DateTime _date;

    public MedicalAppointment(string patientname, DateTime date)
    {
        _patientname = patientname;
        _date = date;
    }

    public MedicalAppointment(string patientname) :
        this(patientname, 7)
    {
    }
    
    public MedicalAppointment(string patientname, int daysFromNow)
    {
        _patientname = patientname;
        _date = DateTime.Now.AddDays(daysFromNow);
    }



    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year,
            _date.Month + monthsToAdd,
            _date.Day + daysToAdd
            );
    }
}