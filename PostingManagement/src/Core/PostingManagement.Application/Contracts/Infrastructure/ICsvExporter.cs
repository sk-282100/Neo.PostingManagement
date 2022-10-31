using PostingManagement.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace PostingManagement.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
