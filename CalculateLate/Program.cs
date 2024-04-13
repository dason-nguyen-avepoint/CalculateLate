using CalculateLate;
Calculate obj = new Calculate();
DateTime start_shift = new DateTime(2024, 01, 01, 20, 00, 00);
DateTime end_shift = new DateTime(2024, 01, 02, 06, 00, 00);
DateTime start_break = new DateTime(2024, 01, 01, 20, 00, 00);
DateTime end_break = new DateTime(2024, 01, 01, 23, 00, 00);
//DateTime? start_leave = new DateTime(2024, 01, 01, 23, 00, 00);
//DateTime? end_leave = new DateTime(2024, 01, 02, 1, 00, 00);
DateTime? start_leave = null;
DateTime? end_leave = null;
DateTime check_in = new DateTime(2024, 01, 02, 3, 00, 00);
#region
// Check Exceptions and Exception Handling Datetime before call function
try
{
    if (!((start_shift <= start_break && end_break < end_shift) || (start_shift < start_break && end_break <= end_shift)))
    {
        throw new Exception("Invalid break time. Break time should be within shift hours.");
    }
    TimeSpan result;
    if (start_leave == null || end_leave == null)
    {
        Console.WriteLine("All conditions are met. No exceptions thrown.");
        result = obj.CalculateLate(start_shift, start_break, end_break, check_in);
        Console.WriteLine($"Late: {result.Hours} hour and {result.Minutes} minutes");
    }
    else
    {
        if (!(start_shift < start_leave && start_leave < end_leave && end_leave < end_shift))
        {
            throw new Exception("Invalid leave time. Leave time should be within shift hours.");
        }
        Console.WriteLine("All conditions are met. No exceptions thrown.");
        result = obj.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
        Console.WriteLine($"Late: {result.Hours} hour and {result.Minutes} minutes");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Exception: " + ex.Message);
}
#endregion

