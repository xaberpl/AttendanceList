using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AttendanceList
{
    public static class csvExporter
    {
        public static void Export(List<JoinAttendance> list)
        {
            using (StreamWriter writetext = new StreamWriter("export.csv"))
            {
                foreach (JoinAttendance joinAttendance in list)
                {
                    string StudentFirstName = joinAttendance.StudentFirstName;
                    string StudentLastName = joinAttendance.StudentLastname;
                    string TeacherFirstName = joinAttendance.TeacherFirstName;
                    string TeacherLastName = joinAttendance.TeacherLastName;
                    string Date = joinAttendance.Data;
                    string Presence = joinAttendance.Presence;

                    string input = StudentFirstName + ";" + StudentLastName + ";" + TeacherFirstName + ";" + TeacherLastName + ";" + Date + ";" + Presence;


                    // get the correct encodings 
                    var srcEncoding = Encoding.UTF8; // utf-8
                    var destEncoding = Encoding.GetEncoding(1252); // windows-1252

                    // convert the source bytes to the destination bytes
                    var destBytes = Encoding.Convert(srcEncoding, destEncoding, srcEncoding.GetBytes(input));

                    // process the byte[]
                    File.WriteAllBytes("myFile", destBytes); // write it to a file OR ...
                    string destString = destEncoding.GetString(destBytes); // ... get the string
                    writetext.WriteLine(destString); 
                }
            }

        }
    }
}
