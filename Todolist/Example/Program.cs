// See https://aka.ms/new-console-template for more information

var medicalAppointment = new MedicalAppointment(
    "John Smith",
    new DateTime(2023, 4, 3)
    );

medicalAppointment.OverwriteMonthAndDay(5, 1);

medicalAppointment.MoveByMonthsAndDays(1, 2);

var appointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
var appointmentOneWeekFromNow = new MedicalAppointment("Margaret Smith");

var nameOnly = new MedicalAppointment("Name only");

Console.ReadKey();

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine(
            "Appointment will take place on " + medicalAppointment.GetDate());
    }
}

class MedicalAppointment
{
    private string _patientname;
    private DateTime _date;

    public MedicalAppointment(string patientname, DateTime date)
    {
        this._patientname = patientname;
        this._date = date;
    }

    //public MedicalAppointment(string patientname) :
    //    this(patientname, 7)
    //{
    //}

    public MedicalAppointment(string patientname)
    {
        this._patientname = patientname;
    }

    public MedicalAppointment(
        string patientname = "Unknown", int daysFromNow = 7)
    {
        this._patientname = patientname;
        this._date = DateTime.Now.AddDays(daysFromNow);
    }

    public DateTime GetDate() => _date;

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
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