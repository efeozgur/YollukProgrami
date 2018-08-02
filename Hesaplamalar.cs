namespace YollukProgrami
{

    public class Hesaplamalar
    {
        private int _kadroDereceGosterge, _gostergeNo,_kacKm, _sure;
        private double _tasitUcreti;
        private bool _kendisiMi;


        public Hesaplamalar(bool Kendisimi, int gostergeNo,int kacKm, double tasitUcreti, int sure)
        {
            _gostergeNo = gostergeNo;
            _kacKm = kacKm;
            _tasitUcreti = tasitUcreti;
            _kendisiMi = Kendisimi;
            _sure = sure;
        }

        public double Yevmiye()
        {
            if (_kendisiMi)
            {
                if (_gostergeNo == 1)
                {
                    return Gosterge.BirinciGrup * 20;
                }
                if (_gostergeNo == 2)
                {
                    return Gosterge.IkinciGrup * 20;
                }
                if (_gostergeNo == 3)
                {
                    return Gosterge.UcuncuGrup  * 20;
                }
                if (_gostergeNo == 4)
                {
                    return Gosterge.DorduncuGrup * 20;
                }
                if (_gostergeNo == 5)
                {
                    return Gosterge.BesinciGrup * 20;
                }

            }
            else
            {
                if (_gostergeNo == 1)
                {
                    return Gosterge.BirinciGrup * 10;
                }
                if (_gostergeNo == 2)
                {
                    return Gosterge.IkinciGrup * 10;
                }
                if (_gostergeNo == 3)
                {
                    return Gosterge.UcuncuGrup * 10;
                }
                if (_gostergeNo == 4)
                {
                    return Gosterge.DorduncuGrup * 10;
                }
                if (_gostergeNo == 5)
                {
                    return Gosterge.BesinciGrup * 10;
                }
            }

            return 0; 

        }

        public double YolMesafeHesap()
        {
            if (_gostergeNo == 1)
            {
                return Gosterge.BirinciGrup * 5 / 100;
            }

            if (_gostergeNo == 2)
            {
                return Gosterge.IkinciGrup * 5 / 100;
            }


            if (_gostergeNo == 3)
            {
                return Gosterge.UcuncuGrup * 5 / 100;
            }

            if (_gostergeNo == 4)
            {
                return Gosterge.DorduncuGrup * 5 / 100;
            }


            if (_gostergeNo == 5)
            {
                return Gosterge.BesinciGrup * 5 / 100;
            }

            return 0; 
        }

        public double YolMesafeUcreti()
        {
            if (_kendisiMi)
            {
                return YolMesafeHesap() * _kacKm;
            }

            return 0; 

        }
        
        public double SureHesap()
        {
            if (_kendisiMi)
            {
                return Yevmiye() / 20 ;
            }
            return Yevmiye() / 20 * 2;
        }

        public double total()
        {
            return Yevmiye() + YolMesafeUcreti() + SureHesap() + _tasitUcreti;
        }

        public double tasitUcreti()
        {
            return _tasitUcreti;
        }
    }

    public struct Gosterge
    {

        public const double BirinciGrup = 51.60;
        public const double IkinciGrup = 48.15;
        public const double UcuncuGrup = 45.20;
        public const double DorduncuGrup = 39.85;
        public const double BesinciGrup = 38.75;
    }
}
