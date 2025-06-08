using SIRentalMobil.Domain.Abstracts;
using SIRentalMobil.Domain.Enums;

namespace SIRentalMobil.Domain.Entities;

public class Pesanan : Entity
{
    public double TarifAplikasi = 0.1;

    public DateTime TanggalPesan { get; set; }
    public DateTime TanggalAwalSewa { get; set; }
    public DateTime TanggalAkhirSewa { get; set; }
    public StatusPesanan Status { get; set; }

    public int JumlahHariSewa => (int)Math.Ceiling(TanggalAkhirSewa.Subtract(TanggalAwalSewa).TotalDays) + 1;
    private double _totalHargaTanpaTarif => Mobil.Tarif * JumlahHariSewa;
    public double TotalHarga => _totalHargaTanpaTarif + TarifAplikasi * _totalHargaTanpaTarif;


    public User Penyewa { get; set; }
    public Mobil Mobil { get; set; }
    public Pembayaran? Pembayaran { get; set; }
}