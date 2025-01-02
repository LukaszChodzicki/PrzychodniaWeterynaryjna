namespace Przychodnia
{
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Wy�wietlenie formularza logowania
            using (var logowanie = new Logowanie()) // Tworzymy instancj� formularza logowania
            {
                if (logowanie.ShowDialog() == DialogResult.OK) // Je�li u�ytkownik kliknie "Zaloguj"
                {
                    Uzytkownik zalogowanyUzytkownik = logowanie.ZalogowanyUzytkownik;
                    // Uruchamiamy g��wny formularz po zalogowaniu
                    Application.Run(new Przychodnia(zalogowanyUzytkownik));
                }
                else
                {
                    // Je�li logowanie si� nie powiod�o, zamykamy aplikacj�
                    Application.Exit();
                }
            }
        }
    }
}
