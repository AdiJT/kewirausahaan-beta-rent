﻿using SIRentalMobil.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SIRentalMobil.Web.Models.PenyewaModels;

public class TambahPesananVM
{
    [Required]
    public required int MobilId { get; set; }

    [Display(Name = "Tanggal Mulai Sewa")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required DateOnly TanggalMulai { get; set; }

    [Display(Name = "Tanggal Akhir Sewa")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public required DateOnly TanggalAkhir { get; set; }
}
