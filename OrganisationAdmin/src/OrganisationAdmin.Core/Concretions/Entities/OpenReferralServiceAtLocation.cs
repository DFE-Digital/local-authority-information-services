//using OrganisationAdmin.Core.Concretions.Entities.Aggregates;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrganisationAdmin.Core.Concretions.Entities;

//public class OpenReferralServiceAtLocation : EntityBase<string>
//{
//    private OpenReferralServiceAtLocation() { }
//    public OpenReferralServiceAtLocation(string id,
//        Location location,
//        ICollection<Holiday_Schedule>? holidayScheduleCollection, ICollection<OpenReferralRegular_Schedule>? regular_schedule
//        )
//    {
//        Id = id;
//        Location = location;
//        HolidayScheduleCollection = holidayScheduleCollection;
//        Regular_schedule = regular_schedule;
//    }

//    public Location Location { get; init; } = default!;
//    public virtual ICollection<Holiday_Schedule>? HolidayScheduleCollection { get; init; }
//    public virtual ICollection<OpenReferralRegular_Schedule>? Regular_schedule { get; init; }
//}
