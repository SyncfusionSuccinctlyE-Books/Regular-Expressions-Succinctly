using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexTester
{
    public class HelpDeskParser
    {
        private Regex SplitLines = new Regex(@"(?<=[\.!\?])\s+");
        private Dictionary<string, string> RegExprList = new Dictionary<string, string>();

        public string AssignedTo;
        public string UserDate;
        public string UserTime;
        public string EmailAddr;
        public string PhoneNumber;
        public string ComplainURL;

        public HelpDeskParser()
        {
            // Load the patterns into the RegExprList
            RegExprList.Add("ASSIGNEDTO", "(Joh{0,1}n|Sue|Su[sz]ie|[BW]ill)");
            RegExprList.Add("USERDATE", @"((sun(day)?|mon(day)?|tue(sday)?|wed(nesday)?|thu(rsday)?|fri(day)?|sat(urday)?),?\s)?((jan(uary)?|feb(ruary)?|mar(ch)?|apr(il)?|may|jun(e)?|jul(y)?|aug(ust)?|sep(tember)?|oct(ober)?|nov(ember)?|dec(ember)?)\s)+((0?[1-9]|[1-2][0-9]|3[0-1]),?(\s|st|nd|rd|th))+([1-2][0-9][0-9][0-9]){0,1}");
            RegExprList.Add("USERTIME", @"\b([1-9]|[0-2]|0[1-9])((:[0-5][0-9]){0,1}\s{0,}[aApP][mM])\b");
            RegExprList.Add("EMAILADDRESS",@"\b([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)\b");
            RegExprList.Add("PHONENUMBER", @"\b((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}\b");
            RegExprList.Add("COMPLAINURL", @"(www\.){0,1}\w{1,}\.(net|com|org|edu|info) ");
        }


        public bool ExtractHelpDeskInfo(string msg)
        {
            // Clear out previous values
            AssignedTo  = "";
            UserDate    = "";
            UserTime    = "";
            EmailAddr   = "";
            PhoneNumber = "";
            ComplainURL = "";

            foreach (KeyValuePair<string, string> entry in RegExprList)
            {
                Match theMatch = Regex.Match(msg, entry.Value, RegexOptions.IgnoreCase);
                if (theMatch.Success)
                   {
                   switch (entry.Key)
                       {
                         case "ASSIGNEDTO": { AssignedTo = theMatch.Value; break; };
                         case "USERDATE": { UserDate = theMatch.Value; break; };
                         case "USERTIME": { UserTime = theMatch.Value; break; };
                         case "EMAILADDRESS" : { EmailAddr = theMatch.Value ; break ; };
                         case "PHONENUMBER": { PhoneNumber = theMatch.Value ; break ; };
                         case "COMPLAINURL": { ComplainURL = theMatch.Value; break; };
                         default:
                            break;
                       }
                  }
            }
            return true;
        }

    }
}
