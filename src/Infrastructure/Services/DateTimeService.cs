using ProjectExample.Application.Common.Interfaces;

namespace ProjectExample.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
