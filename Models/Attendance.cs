using System.Runtime.InteropServices;
using System.IO.Pipes;
using System.Net.Mime;
using api.Interfaces;
using api.Models;
using api.Database;
using System;
using MySql.Data.MySqlClient;

namespace api.Models
{
    public class Attendance
    {
        public string Id {get; set;}
        public string StudentId {get; set;}
        public string SwipeDate {get; set;}
        public string SwipeTime {get; set;}
        public string StudentLat {get; set;}
        public string StudentLng {get; set;}
        public string StudentEvent {get; set;}
        public string StudentName {get; set;}
        public string StudentEmail {get; set;}

        public ISaveAttendance Save {get; set;}

        public Attendance(){
            Save = new SaveAttendance();
        }

        public override string ToString(){
            return $"{StudentId} on {SwipeDate} for {StudentEvent} at {StudentLat}, {StudentLng}";
        }

    }
}