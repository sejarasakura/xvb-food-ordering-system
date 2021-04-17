using System;
using System.Text.RegularExpressions;

namespace VisualBasicAssignment
{
    public class ValidatePayment
    {
        // Create Regex.
        private static readonly Regex masterRegex = new Regex(@"^5[1-5][0-9]{14}|^(222[1-9]|22[3-9]\\d|2[3-6]\\d{2}|27[0-1]\\d|2720)[0-9]{12}$");
        private static readonly Regex visaRegex = new Regex(@"^4\d{12}(?:\d{3})?$");
        private static readonly Regex digitRegex = new Regex(@"^\d?$");
        private static readonly Regex nameRegex = new Regex("^[ a-zA-Z]*?$");
        private static readonly Regex ccvRegex = new Regex("^[0-9]{3}?$");
        private static readonly Regex expRegex = new Regex("^[0-9]{2}[/]{1}[0-9]{2}?$");
        private static readonly Regex phoneRegex = new Regex("^60[0-9]{9}?$");

        // Mastercard Checker
        public static bool isMastercard(string text)
        {
            if (text is null)
            {
                return false;
            }
            // Step 2: call Match on Regex.
            var match = masterRegex.Match(text);
            return match.Success;
        }

        // Visacard Checker
        public static bool isVisacard(string text)
        {
            if (text is null)
            {
                return false;
            }
            // Step 2: call Match on Regex.
            var match = visaRegex.Match(text);
            return match.Success;
        }

        internal static bool isPhoneNumber(string text)
        {
            if (text is null)
            {
                return false;
            }
            // Step 2: call Match on Regex.
            var match = phoneRegex.Match(text);
            return match.Success;
        }

        // Digit Checker
        public static bool isDigit(string text)
        {
            if (text is null)
            {
                return false;
            }
            // Step 2: call Match on Regex.
            var match = digitRegex.Match(text);
            return match.Success;
        }

        // Name Checker
        public static bool isName(string text)
        {
            if (text is null)
            {
                return false;
            }
            // Step 2: call Match on Regex.
            var match = nameRegex.Match(text);
            return match.Success;
        }

        // Exp Checker
        public static bool isExp(string text)
        {
            if (text is null)
            {
                return false;
            }
            // Step 2: call Match on Regex.
            var match = expRegex.Match(text);
            return match.Success;
        }

        // CCV Checker
        public static bool isCCV(string text)
        {
            if (text is null)
            {
                return false;
            }
            // Step 2: call Match on Regex.
            var match = ccvRegex.Match(text);
            return match.Success;
        }

        // Visacard Checker
        public static bool isPaymentEnough(int paymentId, double payTotal)
        {
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    var p = db.Payments.Find((object)paymentId);
                    // Dim pDetails As List(Of PaymentDetail) = p.PaymentDetails.ToList

                    if (p is null)
                    {
                        return false;
                    }

                    if (p.total_pay > payTotal == true)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                // For i = 0 To p.PaymentDetails.Count
                // pDetails.ElementAt(i).
                // Next

                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }

            return default;
        }
    }
}