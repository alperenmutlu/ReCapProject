﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDailyPriceInvalid = "Araba fiyatı eksik veya yanlış";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarsListed = "Arabalar Listelendi";
        public static string Maintenance = "Sistem bakımda";  
        public static string CarsDetailsListed = "Arabalar DETAYLARIYLA Listelendi";
        
        public static string BrandAdded = "Brand Eklendi";
        public static string BrandDeleted = "Brand Silindi";
        public static string BrandUpdated = "Brand Güncellendi";
        
        public static string ColorAdded = "Color Eklendi";
        public static string ColorDeleted = "Color Silindi";
        public static string ColorUpdated = "Color Güncellendi";
        
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
       
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerAdded = "Müşteri Eklendi";
        
        public static string RentalCouldNotAdded = "Bu araba henüz teslim edilmediği için kiralayamazsınız";
        public static string RentAlAdded = "Araba Kiralama İşlemi başarıyla gerçekleşti";
        public static string RentAlUpdated = "Araba Kiralama İşlemi Güncellendi";
        public static string RentalDeleted = "Araba Kiralama İşlemi Silindi";
        public static string RentalDetailsListed = "Araba Kiralama Bilgileri Listelendi";

        public static string CarImagesLimitExceeded = "CarImage Limiti Aşıldı";
        public static string CarImageDeleted = "CarImage Silindi";
        public static string CarImageUpdated = "CarImage Güncellendi";
        public static string CarImageCarIdInvalid = "CarId Geçersiz";

        public static string UserAlreadyExists = "Kullanıcı zaten Mevcut";
        public static string UserRegistered = "Kullanıcı Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string SuccessfullLogin = "Giriş Başarılı";
        public static string PasswordError = "Şifrenizi eksik veya yanlış girdiniz";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz Yok";
    }
}
