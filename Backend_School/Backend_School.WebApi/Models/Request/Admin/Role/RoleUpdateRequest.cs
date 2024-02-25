﻿using System;

namespace Backend_School.WebApi.Models.Request
{
    public class RoleUpdateRequest
    {
        public long Id { get; set; }
        public string NamaRole { get; set; }
        public string Deskripsi { get; set; }
        public bool? Aktif { get; set; }
        public string PenggunaPerbarui { get; set; }
        public string TerminalPerbarui { get; set; }
        public DateTime? TanggalPerbarui { get; set; }
    }
}