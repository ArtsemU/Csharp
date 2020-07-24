using System;

namespace ItAcademyLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кредитный калькулятор");

            Console.WriteLine("Пожалуйста укажите сумму кредита:");
            string amountString = Console.ReadLine();
            double creditAmount;
            if (double.TryParse(amountString, out creditAmount))
            {
                Console.WriteLine($"Сумма кредита {creditAmount} принята!");
            }
            else
            {
                Console.WriteLine("Введено не верное значение. Будет принято значение по умолчанию - 1000$");
                creditAmount = 1000;
            }
            Console.WriteLine();

            Console.WriteLine("Пожалуйста укажите процентную ставку кредита:");
            string interestRateString = Console.ReadLine();
            double interestRate;
            if (double.TryParse(interestRateString, out interestRate))
            {
                Console.WriteLine($"Процентная ставка кредита {interestRate} принята!");
            }
            else
            {
                Console.WriteLine("Введено не верное значение. Будет принято значение по умолчанию - 12% годовых");
                interestRate = 0.12;
            }
            Console.WriteLine();

            Console.WriteLine("Пожалуйста укажите срок кредитования в месяцах:");
            string creditTermString = Console.ReadLine();
            int creditTerm;
            if (int.TryParse(creditTermString, out creditTerm))
            {
                Console.WriteLine($"Период кредитования {creditTerm} месяцев принят!");
            }
            else
            {
                Console.WriteLine("Введено не верное значение. Будет принято значение по умолчанию - 12 месяцев");
                creditTerm = 12;
            }
            Console.WriteLine();

            Console.WriteLine("Пожалуйста выбирите тип крида! Введите '1' если хотите дифференцированные платежи, '2' если хотите аннуитетные платежи");
            string selectedCreditType = Console.ReadLine();
            if (selectedCreditType == "1")
            {
                CalculateDiffPayment(creditAmount, interestRate, creditTerm);
            }
            else if (selectedCreditType == "2")
            {
                CalculateAnnuityPayment(creditAmount, interestRate, creditTerm);
            }
            else
            {
                Console.WriteLine("Мы не можем определить тип. Мы покажем Вам оба расчета что бы вы могли сравнить и выбрать подходящий вариант");
                CalculateDiffPayment(creditAmount, interestRate, creditTerm);
                Console.WriteLine();
                CalculateAnnuityPayment(creditAmount, interestRate, creditTerm);

            }
        }

        static public void CalculateDiffPayment(double creditAmount, double yearinterestRate, int creditTerm = 12)
        {
            Console.WriteLine("Расчет дифференцированного платежа");

            double mainPayment = creditAmount / creditTerm;

            double monthInterestRate = yearinterestRate / 12;

            double paymentPerMonth = 0;

            double paymentPersentPerMonth = 0;

            double overPayment = 0;

            double totalPayment = 0;

            for (int i = 0; i <= creditTerm - 1; i++)
            {
                paymentPersentPerMonth = (creditAmount - mainPayment * i) * monthInterestRate;

                paymentPerMonth = mainPayment + paymentPersentPerMonth;

                totalPayment += paymentPerMonth;

                overPayment += paymentPersentPerMonth;

                Console.WriteLine($"Месяц {i + 1}: основной платеж {mainPayment:f}, " +
                    $"плата по процентам: {paymentPersentPerMonth:f}, " +
                    $"переплата: {overPayment:f} " +
                    $"общая сумма месячного платежа: {paymentPerMonth:f}");
            }

            Console.WriteLine($"Итого вы заплатите: {totalPayment:f}");
        }

        static public void CalculateAnnuityPayment(double creditAmount, double yearinterestRate, int creditTerm = 12)
        {
            Console.WriteLine("Расчет аннуитетного платежа");

            double mainPayment = creditAmount / creditTerm;

            double monthInterestRate = yearinterestRate / 12;

            double аnnuityPayment = 0;

            double divider = 0;

            divider = Math.Pow(1 + monthInterestRate, creditTerm) - 1;

            аnnuityPayment = creditAmount * (monthInterestRate + monthInterestRate / divider);

            Console.WriteLine($"Aннуитетный платеж составит {аnnuityPayment:f}. Общая сумма за {creditTerm} составит {(аnnuityPayment * creditTerm):f}");
        }
    }
}
