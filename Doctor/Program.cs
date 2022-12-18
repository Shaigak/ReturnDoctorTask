using Doctor;

DoctorInformation doctors = new DoctorInformation();
DoctorInformation doctors2 = new DoctorInformation("Eli", "Eliyev", "Masalli ", new DateTime(1996, 03, 08));
DoctorInformation doctors3 = new DoctorInformation("Kerim", "Kazimov", "Goranboy", new DateTime(1994, 11, 08));
DoctorInformation doctors4 = new DoctorInformation("Adil", "Eliyev", "Vasmoy", new DateTime(1999, 11, 08));
DoctorInformation doctors5 = new DoctorInformation("Hesen", "Kazimov", "Sedmoy", new DateTime(2008, 09, 08));

DoctorInformation[] arr = {  doctors2, doctors3, doctors4, doctors5 };

DateTime minDate = new DateTime(1993, 05, 25);
DateTime maxDate = new DateTime(2002, 12, 15);



static void GetDoctorBirth(DoctorInformation[]arr,DateTime minDate,DateTime maxDate)
{

    foreach (var doctors in arr)
    {
        if (doctors.Birthday > minDate && doctors.Birthday < maxDate)
        {
            Console.WriteLine(doctors.Name);
        }
    }
}

GetDoctorBirth(arr,new DateTime(1993, 05, 25), new DateTime(2002, 12, 15));