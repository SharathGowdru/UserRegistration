using System;

namespace AllEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = new Patterns();
            pattern.IsValidEmail();
            pattern.IsValidSampleEmail("abc@yahoo.com");
            pattern.IsValidSampleEmail("abc-100@yahoo.com");
            pattern.IsValidSampleEmail("abc@gmail.com.com");
            pattern.IsValidSampleEmail("abc.100@yahoo.com");
            pattern.IsValidSampleEmail("abc111@abc.com");
            pattern.IsValidSampleEmail("abc-100@abc.net");
            pattern.IsValidSampleEmail("abc.100@abc.com.au");
            pattern.IsValidSampleEmail("abc@1.com");
            pattern.IsValidSampleEmail("abc+100@gmail.com");
            pattern.IsValidSampleEmail("abc");
            pattern.IsValidSampleEmail("abc@.com.my");
            pattern.IsValidSampleEmail("abc123@gmail.a");
            pattern.IsValidSampleEmail("abc123@.com");
            pattern.IsValidSampleEmail(".abc@abc.com");
            pattern.IsValidSampleEmail("abc()*@gmail.com");
            pattern.IsValidSampleEmail("abc@%*.com");
            pattern.IsValidSampleEmail("abc..2002@gmail.com");
            pattern.IsValidSampleEmail("abc.@gmail.com");
            pattern.IsValidSampleEmail("abc@abc@gmail.com");
        }
    }
}
