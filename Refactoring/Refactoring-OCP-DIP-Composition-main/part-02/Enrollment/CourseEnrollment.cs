using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part02.Enrollment
{
    public class CourseEnrollment
    {
        private readonly PaymentGateway _paymentGateway = new();
        private readonly SeatInventory _seatInventory = new();
        private readonly InvoiceGenerator _invoiceGenerator = new();
        private readonly EmailService _emailService = new();

        public void EnrollStudent(string studentId, string courseId, decimal amount)
        {
            _paymentGateway.Charge(studentId, amount);

            _seatInventory.Reserve(courseId, studentId);

            var invoiceId = _invoiceGenerator.Create(studentId, amount);

            _emailService.Send(
                studentId,
                "Enrollment confirmed",
                $"Invoice {invoiceId} for {courseId}"
            );
        }
    }
}
