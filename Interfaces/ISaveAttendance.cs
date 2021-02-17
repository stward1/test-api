using api.Models;
namespace api.Interfaces
{
    public interface ISaveAttendance
    {
         public void CreateAttendance(Attendance studentAttendance);
         public void UpdateAttendance(Attendance studentAttendance);
    }
}