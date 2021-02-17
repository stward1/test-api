using api.Interfaces;
using api.Models;
using MySql.Data.MySqlClient;
namespace api.Database
{
    public class SaveAttendance : ISaveAttendance
    {
        public void CreateAttendance(Attendance studentAttendance){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO attendance(studentId, studentName, studentEmail, studentEvent,";
            stm += @"swipeDate, swipeTime, studentLat, studentLng) ";
            stm += @"VALUES(@studentId, @studentName, @studentEmail, @studentEvent,";
            stm += @"@swipeDate, @swipeTime, @studentLat, @studentLng)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@studentId", studentAttendance.StudentId);
            cmd.Parameters.AddWithValue("@studentName", studentAttendance.StudentName);
            cmd.Parameters.AddWithValue("@studentEmail", studentAttendance.StudentEmail);
            cmd.Parameters.AddWithValue("@studentEvent", studentAttendance.StudentEvent);
            cmd.Parameters.AddWithValue("@swipeDate", studentAttendance.SwipeDate);
            cmd.Parameters.AddWithValue("@swipeTime", studentAttendance.SwipeTime);
            cmd.Parameters.AddWithValue("@studentLat", studentAttendance.StudentLat);
            cmd.Parameters.AddWithValue("@studentLng", studentAttendance.StudentLng);

            cmd.Prepare();

            cmd.ExecuteNonQuery();

        }
        public void UpdateAttendance(Attendance studentAttendance){
            
        }
        
    }
}