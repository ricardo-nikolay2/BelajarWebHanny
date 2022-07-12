namespace BelajarWeb.Rumus
{
    public class Rumus
    {
        public decimal HitungberatPipa(decimal Od,decimal thickness, decimal length,decimal quantity)
        {
            decimal hasil;

            hasil = ((Od - thickness) * thickness * 0.02466m * length * quantity / 1000);
            hasil = Math.Round(hasil, 2);

            return hasil;
        }


        public string HitunghargaSetelahDiskon(decimal harga, decimal diskon, decimal hargaDiskon, decimal hasil)
        {
            string hargasetelahdiskon;

            hargaDiskon = (harga * diskon / 100);

            hasil = harga - hargaDiskon;
            hargasetelahdiskon = hasil.ToString("0,0");

            return hargasetelahdiskon;
        }




    }
}
