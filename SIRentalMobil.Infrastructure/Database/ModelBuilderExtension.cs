﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SIRentalMobil.Domain.Entities;
using SIRentalMobil.Domain.Enums;

namespace SIRentalMobil.Infrastructure.Database;

public static class ModelBuilderExtension
{
    public static ModelBuilder SeedingData(this ModelBuilder modelBuilder)
    {
        #region Penyewa
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                NIK = "1234567890123456",
                Nama = "John Doe",
                Alamat = "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur",
                NoHP = "081234567890",
                Email = "johndoe@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Penyewa
            },
            new User
            {
                Id = 7,
                NIK = "1234567890123455",
                Nama = "John Doe 2",
                Alamat = "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur",
                NoHP = "081234567890",
                Email = "johndoe2@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Penyewa
            },
            new User
            {
                Id = 8,
                NIK = "1234567890123459",
                Nama = "John Doe 3",
                Alamat = "Jln Perca, Kelurahan Airnona, Kecamatan Kota Raja, Kota Kupang, Nusa Tenggara Timur",
                NoHP = "081234567890",
                Email = "johndoe3@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Penyewa
            }
        );
        #endregion

        #region Pemilik
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 2,
                Nama = "Andi Santoso",
                NIK = "5301011234567890",
                Alamat = "Jl. El Tari, Kupang",
                NoHP = "081234567890",
                Email = "andisantoso@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            },
            new User
            {
                Id = 3,
                Nama = "Budi Hartono",
                NIK = "5301022234567891",
                Alamat = "Jl. Fatululi, Kupang",
                NoHP = "081345678901",
                Email = "budihartono@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            },
            new User
            {
                Id = 4,
                Nama = "Citra Puspita",
                NIK = "5301033234567892",
                Alamat = "Jl. Frans Seda, Kupang",
                NoHP = "081456789012",
                Email = "citrapuspita@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            },
            new User
            {
                Id = 5,
                Nama = "Doni Wahyudi",
                NIK = "5301044234567893",
                Alamat = "Jl. W.J. Lalamentik, Kupang",
                NoHP = "081567890123",
                Email = "doniwahyudi@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            },
            new User
            {
                Id = 6,
                Nama = "Elisa Anggrek",
                NIK = "5301055234567894",
                Alamat = "Jl. Timor Raya, Kupang",
                NoHP = "081678901234",
                Email = "elisaanggrek@gmail.com",
                PasswordHash = "AQAAAAIAAYagAAAAEDOL61un4F6xOO9n71b0sKrh5BaGkSo4Brjy0O7Kfle+q33ZWfDN9/rAUaGcuu5XWA==",
                Role = UserRoles.Pemilik
            }
        );
        #endregion

        #region MetodePembayaran
        modelBuilder.Entity<MetodePembayaran>().HasData(
            new MetodePembayaran
            {
                Id = 1,
                Nama = "Tunai"
            },
            new MetodePembayaran
            {
                Id = 2,
                Nama = "OVO"
            },
            new MetodePembayaran
            {
                Id = 3,
                Nama = "GoPay"
            },
            new MetodePembayaran
            {
                Id = 4,
                Nama = "Dana"
            },
            new MetodePembayaran
            {
                Id = 5,
                Nama = "QRIS"
            }
        );
        #endregion

        #region Mobil
        modelBuilder.Entity<Mobil>().HasData(
            new
            {
                Id = 1,
                Nama = "Toyota Avanza",
                Jenis = "Toyota",
                CC = 1500,
                Tahun = 2020,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamax,
                Tarif = 350000d,
                MaksPenumpang = 7,
                MaksHariSewa = 7,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 2
            },
            new
            {
                Id = 2,
                Nama = "Honda Jazz",
                Jenis = "Honda",
                CC = 1300,
                Tahun = 2021,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamax,
                Tarif = 300000d,
                MaksPenumpang = 5,
                MaksHariSewa = 5,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.TidakTersedia,
                PemilikId = 2
            },
            new
            {
                Id = 3,
                Nama = "Mitsubishi Xpander",
                Jenis = "Mitsubishi",
                CC = 1500,
                Tahun = 2019,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamina,
                Tarif = 400000d,
                MaksPenumpang = 7,
                MaksHariSewa = 10,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.TidakTersedia,
                PemilikId = 2
            },

            // Mobil untuk Pemilik 2
            new
            {
                Id = 4,
                Nama = "Daihatsu Sigra",
                Jenis = "Daihatsu",
                CC = 1200,
                Tahun = 2022,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamax,
                Tarif = 400000d,
                MaksPenumpang = 7,
                MaksHariSewa = 5,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 3
            },
            new
            {
                Id = 5,
                Nama = "Toyota Rush",
                Jenis = "Toyota",
                CC = 1500,
                Tahun = 2021,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamina,
                Tarif = 300000d,
                MaksPenumpang = 7,
                MaksHariSewa = 7,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 3
            },
            new
            {
                Id = 6,
                Nama = "Suzuki Ertiga",
                Jenis = "Suzuki",
                CC = 1400,
                Tahun = 2020,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamax,
                Tarif = 350000d,
                MaksPenumpang = 7,
                MaksHariSewa = 6,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 3
            },

            // Mobil untuk Pemilik 3
            new
            {
                Id = 7,
                Nama = "Honda Brio",
                Jenis = "Brio",
                CC = 1999,
                Tahun = 2024,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamina,
                Tarif = 30000d,
                MaksPenumpang = 7,
                MaksHariSewa = 10,
                UrlGambar = new Uri("/assets/Brio.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 4
            },
            new
            {
                Id = 8,
                Nama = "Toyota Fortuner",
                Jenis = "Toyota",
                CC = 2500,
                Tahun = 2022,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamina,
                Tarif = 1000000d,
                MaksPenumpang = 7,
                MaksHariSewa = 12,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 4
            },
            new
            {
                Id = 9,
                Nama = "Honda CRV",
                Jenis = "Honda",
                CC = 2400,
                Tahun = 2020,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamax,
                Tarif = 900000d,
                MaksPenumpang = 7,
                MaksHariSewa = 9,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 4
            },

            // Mobil untuk Pemilik 4
            new
            {
                Id = 10,
                Nama = "Daihatsu Ayla",
                Jenis = "Daihatsu",
                CC = 1200,
                Tahun = 2022,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamax,
                Tarif = 300000d,
                MaksPenumpang = 5,
                MaksHariSewa = 4,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 5
            },
            new
            {
                Id = 11,
                Nama = "Suzuki Mega Carry pick up ",
                Jenis = "Suzuki",
                CC = 1493,
                Tahun = 2021,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamax,
                Tarif = 250000d,
                MaksPenumpang = 5,
                MaksHariSewa = 5,
                UrlGambar = new Uri("/assets/pickup.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 5
            },
            new
            {
                Id = 12,
                Nama = "Honda Mobilio",
                Jenis = "Honda",
                CC = 1500,
                Tahun = 2020,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamax,
                Tarif = 350000d,
                MaksPenumpang = 7,
                MaksHariSewa = 6,
                UrlGambar = new Uri("/assets/Mobilo.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 5
            },

            // Mobil untuk Pemilik 5
            new
            {
                Id = 13,
                Nama = "Toyota HiAce",
                Jenis = "Toyota",
                CC = 2800,
                Tahun = 2019,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamina,
                Tarif = 1200000d,
                MaksPenumpang = 15,
                MaksHariSewa = 15,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 6
            },
            new
            {
                Id = 14,
                Nama = "Isuzu Elf",
                Jenis = "Isuzu",
                CC = 3000,
                Tahun = 2020,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamina,
                Tarif = 1300000d,
                MaksPenumpang = 16,
                MaksHariSewa = 14,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 6
            },
            new
            {
                Id = 15,
                Nama = "Suzuki APV",
                Jenis = "Suzuki",
                CC = 1500,
                Tahun = 2021,
                NomorPlat = "DH1234",
                JenisTransmisi = JenisTransmisi.Manual,
                Dekripsi = "Mobil bersih, wangi, fit untuk segala medan, paham jalan dan mampu mengoperasikan gps/googlemaps/waze dengan baik sehingga mampu menemukan jalan atau alamat dengan lebih cepat dan akurat. ",
                JenisBensin = JenisBensin.Pertamax,
                Tarif = 500000d,
                MaksPenumpang = 7,
                MaksHariSewa = 7,
                UrlGambar = new Uri("/assets/deals-1.png", UriKind.Relative),
                Status = StatusMobil.Tersedia,
                PemilikId = 6
            }
        );
        #endregion

        #region Pemesanan
        modelBuilder.Entity<Pesanan>().HasData(
            new
            {
                Id = 1,
                TanggalPesan = new DateTime(2024, 5, 29, 12, 00, 00),
                Status = StatusPesanan.BelumDiterima,
                TanggalAwalSewa = new DateTime(2024, 5, 29, 12, 00, 00),
                TanggalAkhirSewa = new DateTime(2024, 6, 2, 12, 00, 00),
                PenyewaId = 1,
                MobilId = 3
            },
            new
            {
                Id = 2,
                TanggalPesan = new DateTime(2024, 5, 25, 12, 00, 00),
                Status = StatusPesanan.SudahBayar,
                TanggalAwalSewa = new DateTime(2024, 5, 26, 12, 00, 00),
                TanggalAkhirSewa = new DateTime(2024, 5, 28, 12, 00, 00),
                PenyewaId = 7,
                MobilId = 2
            },
            new
            {
                Id = 3,
                TanggalPesan = new DateTime(2024, 5, 24, 12, 00, 00),
                Status = StatusPesanan.SudahBayar,
                TanggalAwalSewa = new DateTime(2024, 5, 27, 12, 00, 00),
                TanggalAkhirSewa = new DateTime(2024, 5, 30, 12, 00, 00),
                PenyewaId = 8,
                MobilId = 1
            }
        );        
        #endregion

        return modelBuilder;
    }
}
