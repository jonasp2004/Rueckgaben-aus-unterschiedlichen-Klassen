namespace Rückgaben_aus_unterschiedlichen_Klassen {
    internal class Verarbeitung {
        internal static bool Alter(int a) {
            int TempAlter = a - 18;
            if(TempAlter >= 0) {
                return true;
            } else {
                return false;
            }
        }

        internal static string Anrede(string a) {
            if(a.Contains("Hansen") || a.Contains("Peters")) {
                return "Frau ";
            } else if (a.Contains("Meyer") || a.Contains("Andresen") || a.Contains("Scheel") || a.Contains("Müller")) {
                return "Herr ";
            } else {
                return "Frau / Herr ";
            }
        }
    }
}
