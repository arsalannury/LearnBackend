bool CanStudentStartNewSession(double grade, out string schoolMessage)
{
    schoolMessage = string.Empty;
    bool res = false;

    switch (grade)
    {
        case <= 9.5:
            schoolMessage = "You must be better than what you are now. the life is too hard";
            res = false;
            break;
        case > 9.5:
            schoolMessage = "Congratulations student! you did the best";
            res = true;
            break;
        default:
            res = false;
            break;
    }

    return res;
}

bool checkArsalan = CanStudentStartNewSession(8, out string message);
Console.WriteLine(message);