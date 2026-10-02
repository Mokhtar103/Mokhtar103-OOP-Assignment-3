using RefactoringLab;
using RefactoringLab.Part01.src;

ShippingCostCalculator shipping = new AramexShippingCalculator();

Console.WriteLine($"Aramex 2kg -> {shipping.Calculate(2)}");

shipping = new FedExShippingCalculator();

Console.WriteLine($"FedEx 2kg -> {shipping.Calculate(2)}");

shipping = new ExpressShippingCalculator(); // new carrier

Console.WriteLine($"Express 2kg -> {shipping.Calculate(2)}");

Console.WriteLine();

IOrderRepository repo = new SqlOrderRepository();
IEmailSender emailSender = new SmtpEmailSender();

OrderProcessor processor = new OrderProcessor(repo, emailSender);
processor.Process(1001, "customer@example.com");
Console.WriteLine();


new Notifier(new EmailChannel())
    .Send("customer@example.com", "Your order ships tomorrow", DateTime.Today.AddHours(18), true);

new Notifier(new SmsChannel())
    .Send("+201000000000", "OTP 4821", isUrgent: true);

new Notifier(new LoggerChannel())
    .Send("read.txt", "Done", isUrgent: true);

//new UrgentSmsNotification()
//    .Send("+201000000000", "OTP 4821");

//{ SendAt = DateTime.Today.AddHours(18) }
//    .Send("customer@example.com", "Your order ships tomorrow");