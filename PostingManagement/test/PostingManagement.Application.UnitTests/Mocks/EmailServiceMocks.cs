using Moq;
using PostingManagement.Application.Contracts.Infrastructure;
using PostingManagement.Application.Models.Mail;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostingManagement.Application.UnitTests.Mocks
{
    public class EmailServiceMocks
    {
        public static Mock<IEmailService> GetEmailService()
        {
            var mockEmailService = new Mock<IEmailService>();
            mockEmailService.Setup(x => x.SendEmail(It.IsAny<Email>())).ReturnsAsync(true);
            return mockEmailService;
        }
    }
}
