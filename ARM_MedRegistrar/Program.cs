namespace ARM_MedRegistrar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Entrance());

            //офтальмолог
            //    Traumatologist,    //травматолог
            //    ObstetricianGynecologist,  //акушер-гинеколог
            //    Urologist,      //уролог
            //    Infectiologist,   //инфекционист
            //    Oncologist,   //онколог
            //    Gastroenterologist,  //гастроэнтеролог
            //    Cardiologist,    //кардиолог
            //    Endocrinologist   //эндокринолог




            


        }
    }
}