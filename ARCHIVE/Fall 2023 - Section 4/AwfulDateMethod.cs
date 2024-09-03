// version 1 of my date validator method from asn 3
// judge freely, I completely re-did this to make it more user-friendly and, well, less awful.

static string PromptValidDateTheHardWay()
        {
            bool isValidDate = false;
            string date;

            do
            {
                date = Prompt("Please enter the date in the format mm-dd-yyyy: ");

                if (date.Length == 10

                   // check month:
                   && (date[0] == '0' || date[0] == '1') && Char.IsDigit(date[1])

                   // separator:
                   && date[2] == '-'

                   // check day:
                   && (date[3] == '0' || date[3] == '1' || date[3] == '2' || date[3] == '3') && Char.IsDigit(date[4])

                   // check seperator:
                   && date[5] == '-'

                   // check year:
                   && Char.IsDigit(date[6]) && Char.IsDigit(date[7]) && Char.IsDigit(date[8]) && Char.IsDigit(date[9]))
                {
                    // valid format (mm-dd-yyyy): next let's try to create it as a date object
                    string[] dateParts = date.Split('-');

                    int month = int.Parse(dateParts[0]);
                    int day = int.Parse(dateParts[1]);
                    int year = int.Parse(dateParts[2]);

                    try
                    {
                        DateTime dateValidator = new DateTime(year, month, day);
                        isValidDate = true;
                    }
                    catch
                    {
                        PrintErrorMessage("That's not a valid date. Please try again.");
                    }
                }
                else
                    PrintErrorMessage("That's not a valid format. Please try again.");

            } while (!isValidDate);

            return date;
        }

       
