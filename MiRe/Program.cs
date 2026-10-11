using MiRe;
using System;
using System.IO;

namespace MiRe
{
    //----------------Objektumok-----------------------//

    class SubjList()
    {
        static List<Subject> NoReq = new List<Subject>();
        private List<Subject> Subjects = new List<Subject>();

        public void AddSubj(Subject subj)
        {
            Subjects.Add(subj);
        }
        public Subject Search(String code)
        {
            Subject found = null;
            return found;
        }
        
        }
    

    

    //----Class
    class Subject(string name, string code, Subject_Type type, Required req, int kredit, int minSem,int maxSem,int recSem, List<Subject> requirements ){
        public string Name = name;
        public string Code = code;
        public Subject_Type Type = type;
        public Required Req = req;
        public int Kredit  = kredit;
        public int MinSem = maxSem;
        public int RecSem = recSem;
        public List<Subject> Requirements = requirements;
        public bool registered = false;
        public bool completed = false;

        public bool check_register(Subject sub)
    {
        bool error = false;
        foreach(Subject x in sub.Requirements)
        {
            if (!x.registered)
            {
                error = true;
            }
        }
        if (error)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}

//---- Enums
enum Subject_Type
{
    Kollikvium,
    Aláírás,
    Gyakorlati,
    Szakdolgozat,
    None
}
enum Required
{
    Kötelezõ,
    Kötelezõen_választott,
    Szabadon_Választott,
    None
}
//------------functions---//

 static public class start
    {
        static public void loadStuff()
        {

        }
        static public void saveStuff()
        {

        }

    }

//--------------------------------------//
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}