﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BanSach.Models;

namespace BanSach.Models
{
    public class KhachHangService
    {
        private readonly dbSach db;

        public KhachHangService(dbSach context)
        {
            db = context;
        }
        public bool KiemTraEmailTonTai(string email)
        {
            return db.KhachHang.Any(kh => kh.Email == email);
        }

        public bool KiemTraSDTTonTai(string phoneNumber)
        {
            return db.KhachHang.Any(kh => kh.SoDT == phoneNumber);
        }

        public void TaoKhachHang(KhachHang khachHang)
        {
            db.KhachHang.Add(khachHang);
            db.SaveChanges();
        }
    }
}