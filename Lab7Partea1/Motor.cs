namespace Lab7Partea1
{

    /*
    Motorul
    - este caracterizat de
    - Capacitate cilindrica
    - Putere
    - Tipul combustibilului 
    */
    public class Motor
    {
        private int capacitateCilindrica;
        private int putere;
        private string tipulCombustibilului;
        public Motor(int capacitateCilindrica, int putere, string tipulCombustibilului) 
        {
            this.capacitateCilindrica = capacitateCilindrica;
            this.putere = putere;
            this.tipulCombustibilului = tipulCombustibilului;
        }

        /// <summary>
        /// Returneaza valoarea campului capacitateCilindrica
        /// </summary>
        /// <returns></returns>
        public int GetCapacitateCilindrica()
        {
            return capacitateCilindrica;
        }

        /// <summary>
        /// Atribuie o valoare int primita ca parametru campului capacitateCilindrica
        /// </summary>
        /// <param name="capacitateCilindrica"></param>
        public void SetCapacitateCilindrica(int capacitateCilindrica)
        {
            this.capacitateCilindrica = capacitateCilindrica;
        }

        /// <summary>
        /// Returneaza valoarea campului putere
        /// </summary>
        /// <returns></returns>
        public int GetPutere()
        {
            return putere;
        }

        /// <summary>
        /// Atribuie o valoare int primita ca parametru campului putere
        /// </summary>
        /// <param name="putere"></param>
        public void SetPutere(int putere)
        {
            this.putere = putere;
        }

        /// <summary>
        /// Returneaza valoarea campului tipulCombustibilului
        /// </summary>
        /// <returns></returns>
        public string GetTipulCombustibilului()
        {
            return tipulCombustibilului;
        }

        /// <summary>
        /// Atribuie o valoare string primita ca parametru campului tipulCombustibilului
        /// </summary>
        /// <param name="tipulCombustibilului"></param>
        public void SetTipulCombustibilului(string tipulCombustibilului)
        {
            this.tipulCombustibilului = tipulCombustibilului;
        }

        /// <summary>
        /// Returneaza o forma printabila a campurilor obiectului.
        /// </summary>
        /// <returns></returns>
        public string Tipareste()
        {
            return $"{capacitateCilindrica},{putere},{tipulCombustibilului}";

        }
    }
}