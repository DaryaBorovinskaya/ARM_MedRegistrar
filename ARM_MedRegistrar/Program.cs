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

            //�����������
            //    Traumatologist,    //�����������
            //    ObstetricianGynecologist,  //������-���������
            //    Urologist,      //������
            //    Infectiologist,   //������������
            //    Oncologist,   //�������
            //    Gastroenterologist,  //���������������
            //    Cardiologist,    //���������
            //    Endocrinologist   //������������




            


        }
    }
}