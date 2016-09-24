using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DFCManager.Models
{
    public class EmailPartsAnalyser
    {
        public static void headerAnalyse(String header)
        {
            String obj = "";
            String numDFC;

            String[] parts = header.Split('\n');

            foreach (String part in parts)
            {
                
                if (part.Contains("fiche DFC"))
                {
                    int from = part.IndexOf("DFC n ") + "DFC n ".Length;
                    int to = part.LastIndexOf(" a evolue.");

                    numDFC = part.Substring(from, to - from);
                }
                else
                {
                    if (part.Contains("object"))
                    {
                        obj = part.Split(':')[1];
                    }
                    else
                    {
                        if (!part.Contains("DFC file")) 
                            obj += part;
                    }
                    
                }
            }
        }

        public static void familleAnalyse(String body)
        {
            String famille;

            String[] parts = body.Split('\n');

            foreach (String part in parts)
            {
                if (!part.Contains("Cockpit"))
                {
                    int from = part.IndexOf("-") + "-".Length;
                    int to = part.LastIndexOf(":");

                    famille = part.Substring(from, to - from);
                }
            }
        }
    
    }
}