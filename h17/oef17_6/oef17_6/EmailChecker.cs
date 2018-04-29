namespace oef17_6
{
    public static  class EmailChecker
    {
        public static void Check(string mail)
        {
            if (!mail.Contains("@"))
            {
                throw new InvalidEmailException("Voor een @-teken in");
            }
        }
    }
}